CREATE OR REPLACE PROCEDURE QLKS.DatPhongKH(
    TENKH IN NVARCHAR2,
    SDT IN VARCHAR,
    DIACHI IN NVARCHAR2,
    EMAIL IN VARCHAR,
    SOFAX IN VARCHAR,
    TENDOAN IN NVARCHAR2,
    SOLUONGNGUOI IN INT,
    TENLOAIPHONG IN NVARCHAR2,
    MAPHONG IN VARCHAR,
    NGAYDEN IN DATE,
    SODEMLUUTRU IN INT
)
AS
BEGIN
    DECLARE
        makh VARCHAR(10);
        madp VARCHAR(10);
    BEGIN
        EXECUTE IMMEDIATE 'INSERT INTO QLKS.KHACHHANG VALUES ('',:1, :2, :3, :4, :5, :6, :7)'
            USING TENKH,SDT, DIACHI,EMAIL,SOFAX,TENDOAN,SOLUONGNGUOI;
        
        select KH.MAKH INTO makh from QLKS.KHACHHANG KH ORDER BY KH.MAKH DESC FETCH FIRST 1 ROWS ONLY; 
        EXECUTE IMMEDIATE 'INSERT INTO QLKS.DATPHONG VALUES ('',:1, :2, :3, :4)'
            USING makh,TENLOAIPHONG,NGAYDEN,SODEMLUUTRU;
        
        select DP.MADATPHG INTO madp from QLKS.DATPHONG DP ORDER BY DP.MADATPHG DESC FETCH FIRST 1 ROWS ONLY; 
        EXECUTE IMMEDIATE 'INSERT INTO QLKS.CHITIETPHONGDAT VALUES (:1, :2)'
            USING madp, MAPHONG;
        update QLKS.PHONG P set TINHTRANG = 1 WHERE P.MAPHONG = MAPHONG;
        update QLKS.PHONG P set TTDONDEP = 1  WHERE P.MAPHONG = MAPHONG;
    END;
END;
exec QLKS.DatPhongKH('Nguyen Thi Lanh','0396451235','Quan5','lanhnguyen@gmail.com','135',NULL,NULL,'Phong 4 nguoi','P002',TO_DATE('2023-07-03','YYYY-MM-DD'),3);

SELECT*FROM QLKS.DICHVU;
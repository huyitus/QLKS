ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
exec QLKS.DatPhongKH('Nguyen Thi A','0245689741','Quan 7','Nguyenthia@gmail.com','145','Phong 4 nguoi','P010',TO_DATE('2023-08-15','YYYY-MM-DD'),2);
drop procedure QLKS.DatPhongKH;
CREATE OR REPLACE PROCEDURE QLKS.DatPhongKH(
    TENKH IN NVARCHAR2,
    SDT IN VARCHAR,
    DIACHI IN NVARCHAR2,
    EMAIL IN VARCHAR,
    SOFAX IN VARCHAR,
    TENLOAIPHONG IN NVARCHAR2,
    MAPHG IN VARCHAR,
    NGAYDEN IN DATE,
    SODEMLUUTRU IN INT
)
AS
    makh VARCHAR(10);
    madp VARCHAR(10);
BEGIN
    INSERT INTO QLKS.KHACHHANG VALUES ('', TENKH, SDT, DIACHI, EMAIL, SOFAX,null,null);
    
    select KH.MAKH INTO makh from QLKS.KHACHHANG KH ORDER BY KH.MAKH DESC FETCH FIRST 1 ROWS ONLY; 
        
    INSERT INTO QLKS.DATPHONG VALUES ('', makh, TENLOAIPHONG, NGAYDEN, SODEMLUUTRU);
    
    select DP.MADATPHG INTO madp from QLKS.DATPHONG DP ORDER BY DP.MADATPHG DESC FETCH FIRST 1 ROWS ONLY; 
    
    INSERT INTO QLKS.CHITIETPHONGDAT VALUES (madp, MAPHG);
    
    UPDATE QLKS.PHONG P SET TINHTRANG = 1, TTDONDEP = 'Da don' WHERE  P.MAPHONG=MAPHG;
END;
/

CREATE OR REPLACE PROCEDURE QLKS.DatPhongDoanKH(
    TENKH IN NVARCHAR2,
    SDT IN VARCHAR,
    DIACHI IN NVARCHAR2,
    EMAIL IN VARCHAR,
    SOFAX IN VARCHAR,
    TENDOAN IN NVARCHAR2,
    SOLUONGNGUOI IN INT,
    TENLOAIPHONG IN NVARCHAR2,
    MAPHG IN VARCHAR,
    NGAYDEN IN DATE,
    SODEMLUUTRU IN INT
)
AS
    makh VARCHAR(10);
    madp VARCHAR(10);
BEGIN
    INSERT INTO QLKS.KHACHHANG VALUES ('', TENKH, SDT, DIACHI, EMAIL, SOFAX,TENDOAN,SOLUONGNGUOI);
    
    select KH.MAKH INTO makh from QLKS.KHACHHANG KH ORDER BY KH.MAKH DESC FETCH FIRST 1 ROWS ONLY; 
        
    INSERT INTO QLKS.DATPHONG VALUES ('', makh, TENLOAIPHONG, NGAYDEN, SODEMLUUTRU);
    
    select DP.MADATPHG INTO madp from QLKS.DATPHONG DP ORDER BY DP.MADATPHG DESC FETCH FIRST 1 ROWS ONLY; 
    
    INSERT INTO QLKS.CHITIETPHONGDAT VALUES (madp, MAPHG);
    UPDATE QLKS.PHONG P SET TINHTRANG = 1, TTDONDEP = 'Da don' WHERE P.MAPHONG = MAPHG;
END;
/
SELECT * FROM QLKS.PHONG WHERE TINHTRANG = '0';
SELECT * FROM QLKS.PHONG;
SELECT * FROM QLKS.KHACHHANG;
SELECT * FROM QLKS.CHITIETPHONGDAT;
SELECT * FROM QLKS.DATPHONG;
/

------------- LE TAN TINH TIEN HOA DON ---------------------
----Function le tan tinh tien dich vu
CONN QLKS/QLKS1234;
CREATE OR REPLACE FUNCTION getSumServices(MAPHG IN NVARCHAR2) 
RETURN INT
IS
    tongtien INT := 0;
BEGIN
    FOR service_row IN (SELECT SOLUONG, GIA FROM QLKS.CHITIETDATDV, QLKS.DICHVU  WHERE QLKS.CHITIETDATDV.MADV=QLKS.DICHVU.MADV AND QLKS.CHITIETDATDV.MAPHONG=MAPHG) 
    LOOP
        tongtien:=tongtien+service_row.SOLUONG*service_row.GIA;
    END LOOP;  
    RETURN tongtien;
END;
/
---Function le tan tinh tien phong
CREATE OR REPLACE FUNCTION getSumRoom(USERROOM IN NVARCHAR2) 
RETURN INT
IS
    tienphong INT :=0;
BEGIN
    FOR room_row IN (SELECT GIA FROM QLKS.LOAIPHONG LP, QLKS.DATPHONG DPHG, QLKS.CHITIETPHONGDAT CTPD WHERE LP.TENLOAIPHONG=DPHG.TENLOAIPHONG AND DPHG.MADATPHG=CTPD.MADATPHG AND CTPD.MAPHG=USERROOM) 
    LOOP
        tienphong:=tienphong + room_row.GIA;
    END LOOP;  
    RETURN tienphong;
END;
/
----Store le tan tinh tien hoa don
CREATE OR REPLACE PROCEDURE pr_TinhTienHoaDon(USERROOM IN NVARCHAR2)
IS
c1 SYS_REFCURSOR;
bill INT := 0;
tienphong INT:=0;
tiendichvu INT:=0;
begin
    SELECT QLKS.getSumRoom(USERROOM) INTO tienphong FROM DUAL;
    SELECT QLKS.getSumServices(USERROOM) INTO tiendichvu FROM DUAL;
    OPEN c1 FOR
        SELECT tienphong+tiendichvu FROM DUAL;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/

---Proc check ma nhan vien co ton tai khong
CREATE OR REPLACE PROCEDURE pr_CheckNhanVien(MANHANVIEN IN NVARCHAR2)
IS
c1 SYS_REFCURSOR;
begin
    OPEN c1 FOR
     --SELECT NHANVIEN.TENNV FROM NHANVIEN WHERE NHANVIEN.MANV=MANHANVIEN AND NHANVIEN.PHG=MAPHONGBAN_TP;
    SELECT COUNT(*) FROM NHANVIEN WHERE NHANVIEN.MANV=MANHANVIEN;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
----Proc check ma phong co ton tai khong
CREATE OR REPLACE PROCEDURE pr_CheckMaPhong(MAPHG IN NVARCHAR2)
IS
c1 SYS_REFCURSOR;
begin
    OPEN c1 FOR
     --SELECT NHANVIEN.TENNV FROM NHANVIEN WHERE NHANVIEN.MANV=MANHANVIEN AND NHANVIEN.PHG=MAPHONGBAN_TP;
    SELECT COUNT(*) FROM PHONG WHERE PHONG.MAPHONG=MAPHG;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
GRANT EXECUTE ON QLKS.pr_CheckNhanVien TO letan;
GRANT EXECUTE ON QLKS.pr_CheckMaPhong TO letan;
GRANT EXECUTE ON QLKS.pr_TinhTienHoaDon TO letan;

---------------LE TAN THEM DANG KY TOUR DU LICH
--Proc check MaTour co ton tai khong
CREATE OR REPLACE PROCEDURE pr_CheckMaTour(MATOURDULICH IN NVARCHAR2)
IS
c1 SYS_REFCURSOR;
begin
    OPEN c1 FOR
     --SELECT NHANVIEN.TENNV FROM NHANVIEN WHERE NHANVIEN.MANV=MANHANVIEN AND NHANVIEN.PHG=MAPHONGBAN_TP;
    SELECT COUNT(*) FROM TOURDULICH WHERE TOURDULICH.MATOUR=MATOURDULICH;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
GRANT EXECUTE ON QLKS.pr_CheckMaTour TO letan;

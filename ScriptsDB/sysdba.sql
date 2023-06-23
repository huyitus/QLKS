ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

DROP USER QLKS CASCADE;
CREATE USER QLKS IDENTIFIED BY QLKS1234;
GRANT ALL PRIVILEGES TO QLKS;
GRANT CREATE SESSION TO QLKS;
CONN QLKS/QLKS1234;

ALTER TABLE HOADON DROP CONSTRAINT FK_HD_NV;
ALTER TABLE DATPHONG DROP CONSTRAINT FK_DP_KH;
ALTER TABLE DKTOUR DROP CONSTRAINT FK_DKT_KH;
ALTER TABLE PHONG DROP CONSTRAINT FK_PHG_LOAIPHG;
ALTER TABLE DATPHONG DROP CONSTRAINT FK_DP_LP;
ALTER TABLE CHITIETPHONGDAT DROP CONSTRAINT FK_CTPD_PHG;
ALTER TABLE CHITIETDATDV DROP CONSTRAINT FK_CTDV_PHG;
ALTER TABLE CHITIETPHONGDAT DROP CONSTRAINT FK_CTPD_DP;
ALTER TABLE HOADON DROP CONSTRAINT FK_HD_DP;
ALTER TABLE CHITIETDATDV DROP CONSTRAINT FK_CTDV_DV;
ALTER TABLE DKTOUR DROP CONSTRAINT FK_DKT_TOUR;
ALTER TABLE DOITAC DROP CONSTRAINT FK_DT_MTR;

DROP TABLE NHANVIEN;
DROP TABLE KHACHHANG;
DROP TABLE LOAIPHONG;
DROP TABLE PHONG;
DROP TABLE DATPHONG;
DROP TABLE CHITIETPHONGDAT;
DROP TABLE DICHVU;
DROP TABLE CHITIETDATDV;
DROP TABLE HOADON;
DROP TABLE TOURDULICH;
DROP TABLE DKTOUR;
DROP TABLE DOITAC;
DROP TABLE QUYDINH;



CREATE TABLE QLKS.NHANVIEN (
    MANV NVARCHAR2(10),
    TENNV NVARCHAR2(35),
    DIACHI NVARCHAR2(100),
    SDT VARCHAR(11),
    CHUCVU NVARCHAR2(20),
    PRIMARY KEY (MANV)
);

CREATE TABLE QLKS.KHACHHANG (
    MAKH NVARCHAR2(10),
    TENKH NVARCHAR2(35),
    SDT VARCHAR(11),
    DIACHI NVARCHAR2(100),
    EMAIL VARCHAR(50),
    SOFAX VARCHAR(11),
    TENDOAN NVARCHAR2(35),
    SOLUONGNGUOI INT,
    PRIMARY KEY (MAKH)
);

CREATE TABLE QLKS.LOAIPHONG (
    TENLOAIPHONG NVARCHAR2(50),
    SOLUONG INT,
    SOPHONGTRONG INT,
    GIA INT,
    MOTA NVARCHAR2(200),
    PRIMARY KEY (TENLOAIPHONG)
);

CREATE TABLE QLKS.PHONG (
    MAPHONG NVARCHAR2(10),
    TENLOAIPHONG NVARCHAR2(50),
    TINHTRANG NUMBER(1,0),
    TTDONDEP NVARCHAR2(20),
    PRIMARY KEY (MAPHONG)
);

CREATE TABLE QLKS.DATPHONG (
    MADATPHG NVARCHAR2(10),
    MAKH NVARCHAR2(10),
    TENLOAIPHONG NVARCHAR2(50),
    NGAYDEN DATE,
    SODEMLUUTRU INT,
    PRIMARY KEY (MADATPHG)
);

CREATE TABLE QLKS.CHITIETPHONGDAT (
    MADATPHG NVARCHAR2(10),
    MAPHG NVARCHAR2(10),
    PRIMARY KEY (MADATPHG, MAPHG)
);

CREATE TABLE QLKS.DICHVU (
    MADV NVARCHAR2(10),
    TENDV NVARCHAR2(100),
    GIA INT,
    PRIMARY KEY (MADV)
);

CREATE TABLE QLKS.CHITIETDATDV (
    MAPHONG NVARCHAR2(10),
    MADV NVARCHAR2(10),
    SOLUONG INT,
    PRIMARY KEY (MAPHONG, MADV)
);

CREATE TABLE QLKS.HOADON (
    MAHD NVARCHAR2(10),
    MANV NVARCHAR2(10),
    MADATPHG NVARCHAR2(10),
    NGAYLAP DATE,
    TONGTIEN INT,
    PRIMARY KEY (MAHD)
);

CREATE TABLE QLKS.TOURDULICH (
    MATOUR NVARCHAR2(10),
    TENTOUR NVARCHAR2(100),
    DIADIEM NVARCHAR2(200),
    GIA INT,
    THOIGIAN DATE,
    PRIMARY KEY (MATOUR)
);

CREATE TABLE QLKS.DKTOUR (
    MADKTOUR NVARCHAR2(10),
    MATOUR NVARCHAR2(10),
    MAKH NVARCHAR2(10),
    SONGUOITG INT,
    HINHTHUCDICHUYEN NVARCHAR2(20),
    THOIGIANXUATPHAT DATE,
    NHUCAUDACBIET NVARCHAR2(100),
    PRIMARY KEY (MADKTOUR)
);

CREATE TABLE QLKS.DOITAC (
    MADT NVARCHAR2(10),
    TENDT NVARCHAR2(20),
    MATOUR NVARCHAR2(10),
    DIACHI NVARCHAR2(200),
    SDT VARCHAR(11),
    EMAIL VARCHAR(50),
    PRIMARY KEY (MADT)
);

CREATE TABLE QLKS.QUYDINH (
    MAQD NVARCHAR2(10),
    NOIDUNG NVARCHAR2(200),
    PRIMARY KEY (MAQD)
);
/

INSERT INTO QLKS.CHITIETPHONGDAT VALUES ('DP001', 'P001');
INSERT INTO QLKS.CHITIETPHONGDAT VALUES ('DP002', 'P002');
INSERT INTO QLKS.CHITIETPHONGDAT VALUES ('DP003', 'P003');
INSERT INTO QLKS.CHITIETPHONGDAT VALUES ('DP004', 'P004');
INSERT INTO QLKS.CHITIETPHONGDAT VALUES ('DP005', 'P005');
 
INSERT INTO QLKS.CHITIETDATDV VALUES('P001', 'DV001', 1);
INSERT INTO QLKS.CHITIETDATDV VALUES('P001', 'DV002', 1);
INSERT INTO QLKS.CHITIETDATDV VALUES('P004', 'DV001', 1);
INSERT INTO QLKS.CHITIETDATDV VALUES('P003', 'DV004', 1);
INSERT INTO QLKS.CHITIETDATDV VALUES('P005', 'DV004', 1);
 
INSERT INTO QLKS.HOADON VALUES('HD001', 'NV001', 'DP001', TO_DATE('2022-07-10', 'YYYY-MM-DD'), 2350000);
INSERT INTO QLKS.HOADON VALUES('HD002', 'NV001', 'DP002', TO_DATE('2022-07-13', 'YYYY-MM-DD'), 2500000);
INSERT INTO QLKS.HOADON VALUES('HD003', 'NV001', 'DP003', TO_DATE('2022-07-15', 'YYYY-MM-DD'), 2500000);
INSERT INTO QLKS.HOADON VALUES('HD004', 'NV001', 'DP004', TO_DATE('2022-07-16', 'YYYY-MM-DD'), 2005000);
INSERT INTO QLKS.HOADON VALUES('HD005', 'NV001', 'DP005', TO_DATE('2022-07-18', 'YYYY-MM-DD'), 2280000);

---Table TourDuLich
INSERT INTO QLKS.TOURDULICH(MATOUR,TENTOUR,DIADIEM, THOIGIAN) VALUES ('T001','Du lich Nha Trang','Nha Trang',TO_DATE('2023-07-11','YYYY-MM-DD'));
INSERT INTO QLKS.TOURDULICH(MATOUR,TENTOUR,DIADIEM, THOIGIAN) VALUES ('T002','Tour dao Phu Quy','Binh Thuan',TO_DATE('2023-07-14','YYYY-MM-DD'));
INSERT INTO QLKS.TOURDULICH(MATOUR,TENTOUR,DIADIEM, THOIGIAN) VALUES ('T003','Du lich Da Lat','Da Lat',TO_DATE('2023-08-15','YYYY-MM-DD'));
INSERT INTO QLKS.TOURDULICH(MATOUR,TENTOUR,DIADIEM, THOIGIAN) VALUES ('T004','Kham pha pho co Hoi An','Quang Nam',TO_DATE('2023-08-23','YYYY-MM-DD'));
INSERT INTO QLKS.TOURDULICH(MATOUR,TENTOUR,DIADIEM, THOIGIAN) VALUES ('T005','Du lich Maldives','An Do',TO_DATE('2023-11-01','YYYY-MM-DD'));

---Table DKTour
INSERT INTO QLKS.DKTOUR(MADKTOUR, MATOUR, MAKH, SONGUOITG, HINHTHUCDICHUYEN,THOIGIANXUATPHAT, NHUCAUDACBIET) VALUES ('DK001','T001','KH001',3, 'Tu tuc di chuyen','2023-06-30',NULL);
INSERT INTO QLKS.DKTOUR(MADKTOUR, MATOUR, MAKH, SONGUOITG, HINHTHUCDICHUYEN,THOIGIANXUATPHAT, NHUCAUDACBIET) VALUES ('DK002','T005','KH003', 2,'Tu tuc di chuyen','2023-06-30',NULL);
INSERT INTO QLKS.DKTOUR(MADKTOUR, MATOUR, MAKH, SONGUOITG, HINHTHUCDICHUYEN,THOIGIANXUATPHAT, NHUCAUDACBIET) VALUES ('DK003','T002', 'KH002',1,'Tu tuc di chuyen','2023-06-26','An chay');
INSERT INTO QLKS.DKTOUR(MADKTOUR, MATOUR, MAKH, SONGUOITG, HINHTHUCDICHUYEN,THOIGIANXUATPHAT, NHUCAUDACBIET) VALUES ('DK004','T003','KH004',7, 'Dua don','2023-06-30',NULL);
INSERT INTO QLKS.DKTOUR(MADKTOUR, MATOUR, MAKH, SONGUOITG, HINHTHUCDICHUYEN,THOIGIANXUATPHAT, NHUCAUDACBIET) VALUES ('DK005','T004','KH005',4,'Dua don','2023-07-30',NULL);
---Table DoiTac
INSERT INTO QLKS.DOITAC VALUES(N'DT001',N'SaiGonTourist', N'T003', N'Le Loi, Q1','0938225877',N'info@saigontourist.com.vn');
INSERT INTO QLKS.DOITAC VALUES(N'DT002',N'VietTravel', N'T005', N'Pasteur, Q3','0938228898',N'info@vietravel.com.vn');
INSERT INTO QLKS.DOITAC VALUES(N'DT003',N'Thien Anh Travel', N'T001', N'Duong so 5, Go Vap','02866805803',N'dulichthienanh.vn@gmail.com');
INSERT INTO QLKS.DOITAC VALUES(N'DT004',N'Tugo', N'T002', N'Ly Tu Trong, Q1','02873065543',N'support@tugo.com.vn');
INSERT INTO QLKS.DOITAC VALUES(N'DT005',N'Du Lich Viet', N'T004', N'Hoang Van Thu, Phu Nhuan','02873056789',N'info@dulichviet.com');

---Table QuyDinh
INSERT INTO QLKS.QUYDINH VALUES(N'QD1', N'Vui long xuat trinh ho chieu hoac CCCD de lam thu tuc nhan phong');
INSERT INTO QLKS.QUYDINH VALUES(N'QD2', N'Khong mang chat gay no, chat doc hai, vat nuoi hoac thuc pham co mui tanh, hoi vao khach san');
INSERT INTO QLKS.QUYDINH VALUES(N'QD3', N'Khong dua them nguoi la vao phong khi chua dang ki voi Le tan');
INSERT INTO QLKS.QUYDINH VALUES(N'QD4', N'Khong lam hu hong tai san trong phong khach san, neu lam hu Quy khach se phai boi thuong');
INSERT INTO QLKS.QUYDINH VALUES(N'QD5', N'Thoi gian tra phong la 12h30, neu muon phai thanh toan phi tuong ung. Trong truong hop can thiet, vui long lien he Le tan');

---Table DichVu
INSERT INTO QLKS.DICHVU VALUES(N'DV001',N'Giat ui','200000');
INSERT INTO QLKS.DICHVU VALUES(N'DV002',N'Cho thue xe may','500000');
INSERT INTO QLKS.DICHVU VALUES(N'DV003',N'Spa','1000000');
INSERT INTO QLKS.DICHVU VALUES(N'DV004',N'Dua ruoc san bay','500000');
INSERT INTO QLKS.DICHVU VALUES(N'DV005',N'Cho thue phong hop','2000000');

INSERT INTO QLKS.NHANVIEN VALUES('NV001', 'Nguyen Thi Dung', 'Hung Vuong, Q1', '0788123000', 'Le tan');
INSERT INTO QLKS.NHANVIEN VALUES('NV002', 'Tran Bao Ngoc', 'Nguyen Thi Minh Khai, Q3', '0173305925', 'Le tan');
INSERT INTO QLKS.NHANVIEN VALUES('NV003', 'Huynh Van Chien', 'Ngo Quyen, Q10', '09853855551', 'Le tan');
INSERT INTO QLKS.NHANVIEN VALUES('NV004', 'Nguyen Cuc Phuong', 'Pham Ngoc Thach, Q1', '0539682201', 'Le tan');
INSERT INTO QLKS.NHANVIEN VALUES('NV005', 'Pham Hong Hanh', 'Vo Van Tan, Q3', '0582295576', 'Le tan');

INSERT INTO QLKS.KHACHHANG VALUES('KH001', 'Tran Ngoc Nguyen', '0924563643', 'Nguyen Trai, Go Vap', 'tnn@gmail.com', '123', null, null);
INSERT INTO QLKS.KHACHHANG VALUES('KH002', 'Nguyen Van Quan', '0264850126', 'Vo Van Ngan, Thu Duc', 'nvq@gmail.com', '145', null, null);
INSERT INTO QLKS.KHACHHANG VALUES('KH003', 'Nguyen Dinh Viet', '0836625519', 'Le Van Viet, Q9', 'ndv@gmail.com', '297', null, null);
INSERT INTO QLKS.KHACHHANG VALUES('KH004', 'Pham Ngoc Huyen', '0222573275', 'Hai Ba Trung, Q1', 'pnh@gmail.com', '682', 'Doan 123', 10);
INSERT INTO QLKS.KHACHHANG VALUES('KH005', 'Huynh Anh Tuan', '0173385742', 'Vo Thi Sau, Q8', 'hat@gmail.com', '917', 'Doan abc', 6);



--TABLE NHANVIEN
ALTER TABLE QLKS.HOADON ADD CONSTRAINT FK_HD_NV FOREIGN KEY (MANV) REFERENCES QLKS.NHANVIEN (MANV); 
--TABLE KHACHHANG
ALTER TABLE QLKS.DATPHONG ADD CONSTRAINT FK_DP_KH FOREIGN KEY (MAKH) REFERENCES QLKS.KHACHHANG (MAKH); 
ALTER TABLE QLKS.DKTOUR ADD CONSTRAINT FK_DKT_KH FOREIGN KEY (MAKH) REFERENCES QLKS.KHACHHANG (MAKH); 
--TABLE LOAIPHONG
ALTER TABLE QLKS.PHONG ADD CONSTRAINT FK_PHG_LOAIPHG FOREIGN KEY (TENLOAIPHONG) REFERENCES QLKS.LOAIPHONG (TENLOAIPHONG);
ALTER TABLE QLKS.DATPHONG ADD CONSTRAINT FK_DP_LP FOREIGN KEY (TENLOAIPHONG) REFERENCES QLKS.LOAIPHONG (TENLOAIPHONG);
--TABLE PHONG
ALTER TABLE QLKS.CHITIETPHONGDAT ADD CONSTRAINT FK_CTPD_PHG FOREIGN KEY (MAPHG) REFERENCES QLKS.PHONG (MAPHONG);
ALTER TABLE QLKS.CHITIETDATDV ADD CONSTRAINT FK_CTDV_PHG FOREIGN KEY (MAPHONG) REFERENCES QLKS.PHONG (MAPHONG); 
--TABLE DATPHONG
ALTER TABLE QLKS.CHITIETPHONGDAT ADD CONSTRAINT FK_CTPD_DP FOREIGN KEY (MADATPHG) REFERENCES QLKS.DATPHONG (MADATPHG);
ALTER TABLE QLKS.HOADON ADD CONSTRAINT FK_HD_DP FOREIGN KEY (MADATPHG) REFERENCES QLKS.DATPHONG (MADATPHG); 
--TABLE DICHVU
ALTER TABLE QLKS.CHITIETDATDV ADD CONSTRAINT FK_CTDV_DV FOREIGN KEY (MADV) REFERENCES QLKS.DICHVU (MADV); 
--TABLE TOURDULICH
ALTER TABLE QLKS.DKTOUR ADD CONSTRAINT FK_DKT_TOUR FOREIGN KEY (MATOUR) REFERENCES QLKS.TOURDULICH (MATOUR); 
ALTER TABLE QLKS.DOITAC ADD CONSTRAINT FK_DT_MTR FOREIGN KEY (MATOUR) REFERENCES QLKS.TOURDULICH (MATOUR); 

INSERT INTO QLKS.LOAIPHONG VALUES('Phong don', 20, 14, 500000, null);
INSERT INTO QLKS.LOAIPHONG VALUES('Phong doi', 10, 8, 1000000, null);
INSERT INTO QLKS.LOAIPHONG VALUES('Phong 4 nguoi', 8, 5, 1800000, null);
INSERT INTO QLKS.LOAIPHONG VALUES('Phong 6 nguoi', 8, 6, 2500000, null);
INSERT INTO QLKS.LOAIPHONG VALUES('Phong VIP', 5, 2, 3000000, null);

INSERT INTO QLKS.PHONG VALUES('P001','Phong don',0,'Da don');
INSERT INTO QLKS.PHONG VALUES('P002','Phong 4 nguoi',0,'Da don');
INSERT INTO QLKS.PHONG VALUES('P003','Phong doi',0,'Da don');
INSERT INTO QLKS.PHONG VALUES('P004','Phong don',0,'Dang don');
INSERT INTO QLKS.PHONG VALUES('P005','Phong VIP',1,'Da don');

ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD';
INSERT INTO QLKS.DATPHONG VALUES ('DP001','KH001','Phong doi','2023-06-28',2);
INSERT INTO QLKS.DATPHONG VALUES ('DP002','KH002','Phong doi','2023-06-26',2);
INSERT INTO QLKS.DATPHONG VALUES ('DP003','KH003','Phong VIP','2023-06-20',1);
INSERT INTO QLKS.DATPHONG VALUES ('DP004','KH004','Phong 4 nguoi','2023-06-28',2);
INSERT INTO QLKS.DATPHONG VALUES ('DP005','KH005','Phong don','2023-06-22',1);

SELECT*FROM QLKS.HOADON HD, QLKS.NHANVIEN NV WHERE HD.MANV=NV.MANV AND HD.MANV='NV001';
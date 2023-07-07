ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

-- Tao cac tai khoan
drop user daily1;
drop user letan;
CREATE USER daily1 IDENTIFIED BY daily1;
CREATE USER letan IDENTIFIED BY 123456;

-- Cap quyen cho cac tai khoan
GRANT CREATE SESSION TO daily1;
GRANT SELECT ON QLKS.PHONG TO daily1;
GRANT INSERT ON QLKS.YEUCAUDP TO daily1;

-----------le tan ------------
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

-- Tao cac tai khoan
drop user daily1;
drop user letan;
CREATE USER daily1 IDENTIFIED BY daily1;
CREATE USER letan IDENTIFIED BY 123456;

-- Cap quyen cho cac tai khoan
GRANT CREATE SESSION TO daily1;
GRANT SELECT ON QLKS.PHONG TO daily1;
GRANT INSERT ON QLKS.YEUCAUDP TO daily1;

GRANT SELECT, INSERT, UPDATE ON QLKS.KHACHHANG TO letan;
GRANT SELECT ON QLKS.DICHVU TO letan;
GRANT CREATE SESSION TO letan;
GRANT SELECT,UPDATE,INSERT ON QLKS.DATPHONG TO letan;
GRANT SELECT, DELETE ON QLKS.YEUCAUDP TO letan;
GRANT SELECT, UPDATE,INSERT ON QLKS.PHONG TO letan;
GRANT SELECT ON QLKS.LOAIPHONG TO letan;
GRANT SELECT ON QLKS.DICHVU TO letan;
GRANT SELECT, INSERT, UPDATE, DELETE ON QLKS.TOURDULICH TO letan;
GRANT SELECT, INSERT, UPDATE, DELETE ON QLKS.DKTOUR TO letan;
GRANT SELECT ON QLKS.QUYDINH TO letan;
GRANT SELECT, UPDATE, INSERT ON QLKS.CHITIETPHONGDAT to letan;

GRANT SELECT ON QLKS.NHANVIEN TO letan;
GRANT SELECT,INSERT ON QLKS.HOADON TO letan;


GRANT SELECT, INSERT, UPDATE, DELETE ON QLKS.KHACHHANG TO letan;
GRANT SELECT, INSERT, DELETE ON QLKS.CHITIETDATDV TO letan;
GRANT execute on QLKS.PhanPhong to letan;
grant execute on QLKS.DatPhongKH to letan;
grant execute on QLKS.DatPhongDoanKH to letan;


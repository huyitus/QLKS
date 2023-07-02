ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

-- Tao cac tai khoan
CREATE USER daily1 IDENTIFIED BY daily1;
CREATE USER letan IDENTIFIED BY letan;

-- Cap quyen cho cac tai khoan
GRANT CREATE SESSION TO daily1;
GRANT CREATE SESSION TO letan;

GRANT SELECT ON QLKS.PHONG TO daily1;
GRANT INSERT ON QLKS.YEUCAUDP TO daily1;

GRANT SELECT ON QLKS.KHACHHANG TO letan;
GRANT SELECT ON QLKS.DATPHONG TO letan;
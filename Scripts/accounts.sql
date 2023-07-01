-- Tao cac tai khoan cho cac dai ly
CREATE USER daily1 IDENTIFIED BY daily1;

-- Cap quyen cho cac tai khoan cua dai ly
GRANT CREATE SESSION TO daily1;
GRANT SELECT ON QLKS.PHONG TO daily1;
GRANT INSERT ON QLKS.YEUCAUDP TO daily1;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;



namespace QLKS.DAL
{
    class ReceptionistRoomDAL
    {
        public class ThongTinDatPhongDAL
        {
            public string ID_DatPhong { get; set; }
            public string TenKhachHang { get; set; }
            public string TenLoaiPhong { get; set; }
            public string NgayDen { get; set; }
            public int SoDemLuuTru { get; set; }

            public ThongTinDatPhongDAL(string ID_datPhong, string tenKhachHang, string tenLoaiPhong, string ngayDen, string soDemLuuTru)
            {
                ID_DatPhong = ID_datPhong;
                TenKhachHang = tenKhachHang;
                TenLoaiPhong = tenLoaiPhong;
                NgayDen = ngayDen;
                SoDemLuuTru = soDemLuuTru == null ? 0 : int.Parse(soDemLuuTru);
            }

            public static List<ThongTinDatPhongDAL> LoadThongTinDatPhong()
            {
                List<ThongTinDatPhongDAL> thongtindatphong = new List<ThongTinDatPhongDAL>();
                string query = "SELECT DP.MADATPHG, KH.TENKH, DP.TENLOAIPHONG, DP.NGAYDEN, DP.SODEMLUUTRU FROM QLKS.KHACHHANG KH, QLKS.DATPHONG DP WHERE KH.MAKH=DP.MAKH";

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var ID_datPhong = reader.GetString(0);
                        var tenKhachHang = reader.GetString(1);
                        var tenLoaiPhong = reader.GetString(2);
                        var ngayDen = reader.GetString(3);
                        var soDemLuuTru = reader.GetString(4);

                        ThongTinDatPhongDAL ttdp = new ThongTinDatPhongDAL(ID_datPhong, tenKhachHang, tenLoaiPhong, ngayDen, soDemLuuTru);
                        thongtindatphong.Add(ttdp);
                    }
                }
                return thongtindatphong;
            }

            public static List<ThongTinDatPhongDAL> Search(string tenKH)
            {
                string query = string.Format("SELECT DP.MADATPHG, KH.TENKH, DP.TENLOAIPHONG, DP.NGAYDEN, DP.SODEMLUUTRU FROM QLKS.KHACHHANG KH, QLKS.DATPHONG DP WHERE KH.MAKH=DP.MAKH AND KH.TENKH = '" + tenKH + "'");

                List<ThongTinDatPhongDAL> thongtintimkiem = new List<ThongTinDatPhongDAL>();

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var ID_datPhong = reader.GetString(0);
                        var tenKhachHang = reader.GetString(1);
                        var tenLoaiPhong = reader.GetString(2);
                        var ngayDen = reader.GetString(3);
                        var soDemLuuTru = reader.GetString(4);

                        ThongTinDatPhongDAL ttdp = new ThongTinDatPhongDAL(ID_datPhong, tenKhachHang, tenLoaiPhong, ngayDen, soDemLuuTru);
                        thongtintimkiem.Add(ttdp);
                    }
                }
                return thongtintimkiem;
            }
        }
        public class ThongTinPhongDAL
        {
            public string MaPhong { get; set; }
            public string TenLoaiPhong { get; set; }
            public string TinhTrang { get; set; }
            public string TTDonDep { get; set; }



            public ThongTinPhongDAL(string maPhong, string tenLoaiPhong, string tinhTrang, string TTdonDep)
            {
                MaPhong = maPhong;
                TenLoaiPhong = tenLoaiPhong;
                TinhTrang = tinhTrang;
                TTDonDep = TTdonDep;
            }

            public static List<ThongTinPhongDAL> Loadthongtinphong(bool isEmpty, bool isClean)
            {
                string cond1 = isEmpty ? "TINHTRANG = 0" : "1 = 1";
                string cond2 = isClean ? "TTDONDEP = 'Chua don'" : "1 = 1";
                string query = string.Format("SELECT * FROM QLKS.PHONG WHERE {0} AND {1}", cond1, cond2);

                List<ThongTinPhongDAL> rooms = new List<ThongTinPhongDAL>();

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var maPhong = reader.GetString(0);
                        var tenLoaiPhong = reader.GetString(1);
                        var tinhTrang = reader.GetString(2);
                        if (int.Parse(tinhTrang) == 1)
                            tinhTrang = "Dang Thue";
                        else
                            tinhTrang = "Con Trong";
                        var TTdonDep = reader.GetString(3);
                        ThongTinPhongDAL room = new ThongTinPhongDAL(maPhong, tenLoaiPhong, tinhTrang, TTdonDep);
                        rooms.Add(room);
                    }
                }
                return rooms;
            }
        }
    }
}

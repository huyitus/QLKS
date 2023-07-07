using QLKS.BAL;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{

    class ReceptionistOrderRoomDAL
    {

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

            public static List<ThongTinPhongDAL> Loadthongtinphong()
            {
                string query = "SELECT * FROM QLKS.PHONG WHERE TINHTRANG = '0'";

                List<ThongTinPhongDAL> rooms = new List<ThongTinPhongDAL>();

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var maPhong = reader.GetString(0);
                        var tenLoaiPhong = reader.GetString(1);
                        var tinhTrang = reader.GetString(2);
                        tinhTrang = "Con Trong";
                        var TTdonDep = reader.GetString(3);
                        ThongTinPhongDAL room = new ThongTinPhongDAL(maPhong, tenLoaiPhong, tinhTrang, TTdonDep);
                        rooms.Add(room);
                    }
                }
                return rooms;
            }

            public static List<ThongTinPhongDAL> LoadthongtinphongTheoLoai(string loaiphong)
            {
                string query = string.Format("SELECT * FROM QLKS.PHONG WHERE TINHTRANG = '0' AND TENLOAIPHONG = '" + loaiphong + "'");

                List<ThongTinPhongDAL> rooms = new List<ThongTinPhongDAL>();

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var maPhong = reader.GetString(0);
                        var tenLoaiPhong = reader.GetString(1);
                        var tinhTrang = reader.GetString(2);
                        tinhTrang = "Con Trong";
                        var TTdonDep = reader.GetString(3);
                        ThongTinPhongDAL room = new ThongTinPhongDAL(maPhong, tenLoaiPhong, tinhTrang, TTdonDep);
                        rooms.Add(room);
                    }
                }
                return rooms;
            }
        }

        public class LoaiPhongDAL
        {
            public string LoaiPhong { get; set; }
            public LoaiPhongDAL(string loaiPhong)
            {
                LoaiPhong = loaiPhong;
            }
            public static List<LoaiPhongDAL> loadLoaiPhong()
            {
                List<LoaiPhongDAL> loaiphong = new List<LoaiPhongDAL>();
                string query = "SELECT TENLOAIPHONG FROM QLKS.LOAIPHONG";
                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var loaiPhong = reader.GetString(0);
                        LoaiPhongDAL ttLoaiPhong = new LoaiPhongDAL(loaiPhong);
                        loaiphong.Add(ttLoaiPhong);
                    }
                }
                return loaiphong;
            }
        }

        public static bool DatPhongTheoNhom(string ten, string sdt, string diachi, string email, string sofax, string tendoan, string soluongnguoi, string loaiphong, string maphong, string ngayden, string sodemluutru)
        {
            string query = "begin QLKS.DatPhongDoanKH('" + ten + "','" + sdt + "','" + diachi + "','" + email + "','" + sofax + "','" + tendoan + "'," + soluongnguoi + ",'" + loaiphong + "','" + maphong + "',TO_DATE('" + ngayden + "','YYYY-MM-DD')," + sodemluutru + "); end;";
            using (var command = new OracleCommand(query, SessionBAL.sConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (OracleException)
                {
                    return false;
                }
            }
        }
        public static bool DatPhong(string ten, string sdt, string diachi, string email, string sofax, string loaiphong, string maphong, string ngayden, string sodemluutru)
        {
            string query = "begin QLKS.DatPhongKH('" + ten + "','" + sdt + "','" + diachi + "','" + email + "','" + sofax + "','" + loaiphong + "','" + maphong + "',TO_DATE('" + ngayden + "','YYYY-MM-DD')," + sodemluutru + "); end;";
            using (var command = new OracleCommand(query, SessionBAL.sConnection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (OracleException)
                {
                    return false;
                }
            }
        }
    }
}

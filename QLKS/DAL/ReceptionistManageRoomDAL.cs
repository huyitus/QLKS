using Oracle.ManagedDataAccess.Client;
using QLKS.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAL
{
    class ReceptionistManageRoomDAL
    {
        public class QuanLyPhongDAL
        {
            public string MaPhong { get; set; }
            public string TenLoaiPhong { get; set; }
            public string TenKH { get; set; }

            public QuanLyPhongDAL(string maPhong, string tenLoaiPhong, string tenKH)
            {
                MaPhong = maPhong;
                TenLoaiPhong = tenLoaiPhong;
                TenKH = tenKH;
            }
            public static List<QuanLyPhongDAL> LoadThongTinPhong()
            {
                string query = "SELECT CT.MAPHG, DPG.TENLOAIPHONG, KH.TENKH FROM QLKS.KHACHHANG KH, QLKS.DATPHONG DPG, QLKS.CHITIETPHONGDAT CT WHERE DPG.MADATPHG = CT.MADATPHG AND DPG.MAKH = KH.MAKH;";

                List<QuanLyPhongDAL> quanlyphong = new List<QuanLyPhongDAL>();

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var maPhong = reader.GetString(0);
                        var tenLoaiPhong = reader.GetString(1);
                        var tenKH = reader.GetString(2);

                        var qlp = new QuanLyPhongDAL(maPhong, tenLoaiPhong, tenKH);
                        quanlyphong.Add(qlp);
                    }
                }
                return quanlyphong;

            }
            public static List<QuanLyPhongDAL> Search(string maphong)
            {
                string query = string.Format("SELECT CT.MAPHG, DP.TENLOAIPHONG, KH.TENKH FROM QLKS.KHACHHANG KH, QLKS.DATPHONG DP, QLKS.CHITIETPHONGDAT CT WHERE DP.MADATPHG = CT.MADATPHG AND DP.MAKH = KH.MAKH AND CT.MAPHG = '" + maphong + "'");

                List<QuanLyPhongDAL> thongtintimkiem = new List<QuanLyPhongDAL>();

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var maPhong = reader.GetString(0);
                        var tenLoaiPhong = reader.GetString(1);
                        var tenKH = reader.GetString(2);

                        QuanLyPhongDAL qlp = new QuanLyPhongDAL(maPhong, tenLoaiPhong, tenKH);
                        thongtintimkiem.Add(qlp);
                    }
                }
                return thongtintimkiem;
            }
        }

        public class DV_PhongDAL
        {
            public string MaPhong { get; set; }
            public string MaDV { get; set; }
            public string SoLuong { get; set; }

            public DV_PhongDAL(string maPhong, string madv, string soluong)
            {
                MaPhong = maPhong;
                MaDV = madv;
                SoLuong = soluong;
            }

            public static List<DV_PhongDAL> LoadDV_Phong()
            {
                string query = "SELECT * FROM QLKS.CHITIETDATDV;";

                List<DV_PhongDAL> dvphong = new List<DV_PhongDAL>();

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var maPhong = reader.GetString(0);
                        var maDV = reader.GetString(1);
                        var soLuong = reader.GetString(2);

                        var dvp = new DV_PhongDAL(maPhong, maDV, soLuong);
                        dvphong.Add(dvp);
                    }
                }
                return dvphong;
            }
            public static List<DV_PhongDAL> Search(string maphong)
            {
                string query = string.Format("SELECT * FROM QLKS.CHITIETDATDV WHERE MAPHONG = '" + maphong + "'");

                List<DV_PhongDAL> thongtintimkiem = new List<DV_PhongDAL>();

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var maPhong = reader.GetString(0);
                        var maDV = reader.GetString(1);
                        var soLuong = reader.GetString(2);

                        var dvp = new DV_PhongDAL(maPhong, maDV, soLuong);
                        thongtintimkiem.Add(dvp);
                    }
                }
                return thongtintimkiem;
            }
            public static bool Del(string id)
            {
                string query = string.Format("DELETE FROM QLKS.CHITIETDATDV WHERE MADV='{0}'", id);
                using (var command = new OracleCommand(query, SessionBAL.sConnection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            public static bool Insert(string maphong, string madv, string sl)
            {
                string query = string.Format("INSERT INTO QLKS.CHITIETDATDV VALUES('{0}', '{1}', '{2}')", maphong, madv, sl);
                using (var command = new OracleCommand(query, SessionBAL.sConnection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAL
{
    class ReceptionistManageRoomDAL
    {
        public string MaPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public string TenKH { get; set; }

        public ReceptionistManageRoomDAL(string maPhong, string tenLoaiPhong, string tenKH)
        {
            MaPhong = maPhong;
            TenLoaiPhong = tenLoaiPhong;
            TenKH = tenKH;
        }
        public static List<ReceptionistManageRoomDAL> LoadThongTinPhong()
        {
            string query = "SELECT DP.TENLOAIPHONG, CT.MAPHG, KH.TENKH FROM QLKS.KHACHHANG KH, QLKS.DATPHONG DP, QLKS.CHITIETPHONGDAT CT WHERE DP.MADATPHG = CT.MADATPHG AND DP.MAKH = KH.MAKH;";

            List<ReceptionistManageRoomDAL> quanlyphong = new List<ReceptionistManageRoomDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var maPhong = reader.GetString(0);
                    var tenLoaiPhong = reader.GetString(1);
                    var tenKH = reader.GetString(2);

                    var qlp = new ReceptionistManageRoomDAL(maPhong, tenLoaiPhong, tenKH);
                    quanlyphong.Add(qlp);
                }
            }
            return quanlyphong;

        }

        public static List<ReceptionistManageRoomDAL> Search(string maphong)
        {
            string query = string.Format("SELECT DP.TENLOAIPHONG, CT.MAPHG, KH.TENKH FROM QLKS.KHACHHANG KH, QLKS.DATPHONG DP, QLKS.CHITIETPHONGDAT CT WHERE DP.MADATPHG = CT.MADATPHG AND DP.MAKH = KH.MAKH AND CT.MAPHG = '" + maphong + "'");

            List<ReceptionistManageRoomDAL> thongtintimkiem = new List<ReceptionistManageRoomDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var maPhong = reader.GetString(0);
                    var tenLoaiPhong = reader.GetString(1);
                    var tenKH = reader.GetString(2);

                    ReceptionistManageRoomDAL qlp = new ReceptionistManageRoomDAL(maPhong, tenLoaiPhong, tenKH);
                    thongtintimkiem.Add(qlp);
                }
            }
            return thongtintimkiem;
        }
    }
}

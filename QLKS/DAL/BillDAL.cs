using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLKS.DAL
{
    class BillDAL
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string MaDatPhong { get; set; }
        public DateTime NgayLap { get; set; }
        public int TongTien { get; set; }
        public BillDAL(string mahd, string manv, string mdp, DateTime ngaylap, int sum)
        {
            MaHD = mahd;
            MaNV = manv;
            MaDatPhong = mdp;
            NgayLap = ngaylap;
            TongTien = sum;
        }
        public static List<BillDAL> GetBill()
        {
            string query = "SELECT * FROM QLKS.HOADON";

            List<BillDAL> bills = new List<BillDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var mahd = reader.GetString(0);
                    var manv = reader.GetString(1);
                    var mdp = reader.GetString(2);
                    var ngaylap = reader.GetDateTime(3);
                    var sum = reader.GetInt32(4);

                    var bill = new BillDAL(mahd, manv, mdp, ngaylap, sum);
                    bills.Add(bill);
                }
            }

            return bills;
        }
        public static BillDAL GetBillInf(string id)
        {
            string query = "SELECT * FROM QLKS.HOADON WHERE MAHD='" + id + "'";

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                if (reader != null && reader.Read())
                {
                    var mahd = reader.GetString(0);
                    var manv = reader.GetString(1);
                    var mdp = reader.GetString(2);
                    var ngaylap = reader.GetDateTime(3);
                    var sum = reader.GetInt32(4);

                    var bill = new BillDAL(mahd, manv, mdp, ngaylap, sum);
                    return bill;
                }
            }

            return null;
        }
        public static string Execute_pr_TinhTienHoaDon(string maphong)
        {
            string query = "begin QLKS.pr_TinhTienHoaDon('" + maphong + "'); end;";
            string kq = Utility.ExecuteScalar(query).ToString();
            return kq;
        }
        public static string Execute_pr_CheckNhanVien(string manhanvien)
        {
            string query = "begin QLKS.pr_CheckNhanVien('" + manhanvien + "'); end;";
            string kq = Utility.ExecuteScalar(query).ToString();
            return kq;
        }
        public static string Execute_pr_CheckMaPhong(string maphong)
        {
            string query = "begin QLKS.pr_CheckMaPhong('" + maphong + "'); end;";
            string kq = Utility.ExecuteScalar(query).ToString();
            return kq;
        }
        public static string SelectMaDatPhong (string maphong)
        {
            string query = "SELECT * FROM QLKS.CHITIETPHONGDAT WHERE MAPHG='" + maphong + "'";
            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                if (reader != null && reader.Read())
                {
                    var userRoom = reader.GetString(0);
                    return userRoom;
                }
            }
            return null;
        }
        public static bool Insert(string manhanvien, string madatphong, DateTime tglaphd, int tongtien)
        {
            string total = tongtien.ToString();
            DateTime date = Convert.ToDateTime(tglaphd);
            String ngaybd = date.ToString("yyyy-MM-dd");

            string query = "INSERT INTO QLKS.HOADON VALUES ('','" + manhanvien + "','" + madatphong + "',TO_DATE('" + ngaybd + "','YYYY-MM-DD')," + tongtien + ")";
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
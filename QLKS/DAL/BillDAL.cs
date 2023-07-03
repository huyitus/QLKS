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

                    var bill = new BillDAL(mahd, manv,mdp,ngaylap,sum);
                    bills.Add(bill);
                }
            }

            return bills;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS.BAL;
using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace QLKS.DAL
{
    class DKTourDAL
    {
        public string MaDKTour { get; set; }
        public string MaTour { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public int SoNguoiTG { get; set; }
        public string HinhThucDiChuyen { get; set; }
        public DateTime ThoiGianXuatPhat { get; set; }
        public string NhuCauDacBiet { get; set; }

        public DKTourDAL(string madktour, string matour, string tenkh, string sdt, int songuoi, string hinhthuc, DateTime tg, string yeucau)
        {
            MaDKTour = madktour;
            MaTour = matour;
            TenKH = tenkh; 
            SDT = sdt;
            SoNguoiTG=songuoi;
            HinhThucDiChuyen = hinhthuc;
            ThoiGianXuatPhat = tg;
            NhuCauDacBiet = yeucau;
        }
        public static List<DKTourDAL> GetDKTour()
        {
            string query = "SELECT * FROM QLKS.DKTOUR";

            List<DKTourDAL> dkt = new List<DKTourDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var madktour = reader.GetString(0);
                    var matour = reader.GetString(1);
                    var tenkh = reader.GetString(2);
                    var sdt = reader.GetString(3);
                    var songuoi = reader.GetInt32(4);
                    var hinhthuc = reader.GetString(5);
                    var tg = reader.GetDateTime(6);
                    var yeucau = reader.IsDBNull(7) ? "No" : reader.GetString(7);
                    var dk = new DKTourDAL(madktour, matour, tenkh, sdt, songuoi, hinhthuc, tg, yeucau);
                    dkt.Add(dk);
                }
            }
            return dkt;
        }
        public static bool Insert(string matour, string tenkh, string sdt, int songuoi, string hinhthuc, DateTime tg, string yeucau)
        {
            string number = songuoi.ToString();
            DateTime date = Convert.ToDateTime(tg);
            String ngaybd = date.ToString("yyyy-MM-dd");

            string query= "INSERT INTO QLKS.DKTOUR VALUES ('','" + matour + "','" + tenkh +"','"+sdt+"',"+ number + ",'"+hinhthuc+"',TO_DATE('" + ngaybd + "','YYYY-MM-DD'),'"+yeucau+"')";
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
        public static bool Del(string madktour)
        {
            string query = string.Format("DELETE FROM QLKS.DKTOUR WHERE MADKTOUR='{0}'", madktour);
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
        public static DKTourDAL GetDKTourDV(string id)
        {
            string query = "SELECT * FROM QLKS.DKTOUR WHERE MADKTOUR='" + id + "'";

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                if (reader != null && reader.Read())
                {

                    var madktour = reader.GetString(0);
                    var matour = reader.GetString(1);
                    var tenkh = reader.GetString(2);
                    var sdt = reader.GetString(3);
                    var songuoi = reader.GetInt32(4);
                    var hinhthuc = reader.GetString(5);
                    var tg = reader.GetDateTime(6);
                    var yeucau = reader.IsDBNull(7) ? "No" : reader.GetString(7);
                    var dk = new DKTourDAL(madktour, matour, tenkh, sdt, songuoi, hinhthuc, tg, yeucau);
                    return dk;
                }
            }

            return null;
        }
        public static bool Update(string madktour, string matour, string tenkh, string sdt, int songuoi, string hinhthuc, DateTime tg, string yeucau)
        {
            string number = songuoi.ToString();
            DateTime date = Convert.ToDateTime(tg);
            String ngaybd = date.ToString("yyyy-MM-dd");

            string query = "UPDATE QLKS.DKTOUR SET MATOUR='" + matour + "',TENKH='" + tenkh + "',SDT='" + sdt + "',SONGUOITG=" + number + ",HINHTHUCDICHUYEN='" + hinhthuc + "',THOIGIANXUATPHAT=TO_DATE('" + ngaybd + "','YYYY-MM-DD'),NHUCAUDACBIET='" + yeucau + "' WHERE MADKTOUR='"+madktour+"'";
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
        public static string Execute_pr_CheckMaTour(string matour)
        {
            string query = "begin QLKS.pr_CheckMaTour('" + matour + "'); end;";
            string kq = Utility.ExecuteScalar(query).ToString();
            return kq;
        }
    }
}

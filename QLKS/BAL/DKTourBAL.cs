using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS.BAL;
using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLKS.BAL
{
    class DKTourBAL
    {
        public static void LoadDKTourInto(DataGridView dtg_DKTour)
        {
            List<DKTourDAL> dkt = DKTourDAL.GetDKTour();
            dtg_DKTour.DataSource = dkt;
        }
        public static bool SendRequestAddDKTour(string matour, string tenkh, string sdt, int songuoi, string hinhthuc, DateTime tg, string yeucau)
        {
            return DKTourDAL.Insert(matour,tenkh,sdt, songuoi,hinhthuc, tg, yeucau);
        }
        public static bool SendRequestDelDKTour(string madktour)
        {
            return DKTourDAL.Del(madktour);
        }
        public static DKTourDAL GetDKTourDV (string id)
        {
            return DKTourDAL.GetDKTourDV(id);
        }
        public static bool Update(string madktour, string matour, string tenkh, string sdt, int songuoi, string hinhthuc, DateTime tg, string yeucau)
        {
            return DKTourDAL.Update(madktour,matour,tenkh, sdt, songuoi, hinhthuc, tg, yeucau);
        }
        public static string CheckMaTour(string matour)
        {
            return DKTourDAL.Execute_pr_CheckMaTour(matour);
        }
    }
}

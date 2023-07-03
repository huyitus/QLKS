using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLKS.DAL
{
    class TourDAL
    {
        public string MaTour { get; set; }
        public string TenTour { get; set; }
        public string DiaDiem { get; set; }
        public int Gia { get; set; }
        public DateTime ThoiGian { get; set; }
        public TourDAL(string matour, string name, string place,int gia, DateTime tgian)
        {
            MaTour = matour;
            TenTour = name;
            DiaDiem = place;
            Gia = gia;
            ThoiGian = tgian;
        }
        public static List<TourDAL> GetTour()
        {
            string query = "SELECT * FROM QLKS.TOURDULICH";

            List<TourDAL> tours = new List<TourDAL>();

            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var mat = reader.GetString(0);
                    var name = reader.GetString(1);
                    var place = reader.GetString(2);
                    var gia = reader.GetInt32(3);
                    var tgian = reader.GetDateTime(4);

                    var tour = new TourDAL(mat, name, place,gia, tgian);
                    tours.Add(tour);
                }
            }

            return tours;
        }
    }
}

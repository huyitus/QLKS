using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;



namespace QLKS.DAL
{
    class RecepUpdateRoomDAL
    {
        public string MaPhong { get; set; }
        public RecepUpdateRoomDAL(string maPhong)
        {
            MaPhong = maPhong;
        }
        public static List<RecepUpdateRoomDAL> loadMaPhongConTrong()
        {
            List<RecepUpdateRoomDAL> maphong = new List<RecepUpdateRoomDAL>();
            string query = "SELECT MAPHONG FROM QLKS.PHONG WHERE TINHTRANG = 0";
            using (OracleDataReader reader = Utility.GetDataReader(query))
            {
                while (reader != null && reader.Read())
                {
                    var maPhong = reader.GetString(0);

                    RecepUpdateRoomDAL ttMaPhong = new RecepUpdateRoomDAL(maPhong);
                    maphong.Add(ttMaPhong);
                }
            }
            return maphong;
        }
        public static bool update(string maPhong, string TTDonDep)
        {
            string query = string.Format("UPDATE QLKS.PHONG SET TTDONDEP = '" + TTDonDep + "' WHERE MAPHONG = '" + maPhong + "' AND TINHTRANG = 0");
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

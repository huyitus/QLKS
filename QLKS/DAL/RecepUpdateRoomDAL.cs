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
        public static List<RecepUpdateRoomDAL> loadMaPhong()
        {
            List<RecepUpdateRoomDAL> maphong = new List<RecepUpdateRoomDAL>();
            string query = "SELECT MAPHONG FROM QLKS.PHONG";
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
    }
}

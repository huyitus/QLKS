using QLKS.BAL;

using Oracle.ManagedDataAccess.Client;


namespace QLKS.DAL
{
    class ReceptionistDividedRoomDAL
    {
        public string MaDatPhong { get; set; }
        public string MaPhong { get; set; }
        public ReceptionistDividedRoomDAL(string maDP ,string maPhong)
        {
            MaDatPhong = maDP;
            MaPhong = maPhong;
        }
        public static bool Thuchienphanphong(string maDP, string maPhong)
        {
            string query = "begin QLKS.PhanPhong('" + maDP + "','" + maPhong + "'); end;";
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

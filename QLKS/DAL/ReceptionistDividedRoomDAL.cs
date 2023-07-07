using QLKS.BAL;

using System;
using System.Collections.Generic;

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
            using (var command = new OracleCommand("QLKS.PhanPhong", SessionBAL.sConnection))
            {
                try
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("maDatPhong", OracleDbType.Varchar2).Value = maDP;
                    command.Parameters.Add("maPhng", OracleDbType.Varchar2).Value = maPhong;
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

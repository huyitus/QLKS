using QLKS.BAL;

using System;
using System.Collections.Generic;

using Oracle.ManagedDataAccess.Client;


namespace QLKS.DAL
{
    class ReceptionistDividedRoomDAL
    {
        public static bool Insert(string maDP, string maPhong)
        {
            string query = string.Format("INSERT INTO QLKS.DOITAC VALUES('{0}','{1}')", maDP,maPhong);
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

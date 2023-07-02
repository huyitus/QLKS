﻿using QLKS.BAL;

using System;

using Oracle.ManagedDataAccess.Client;

namespace QLKS.DAL
{
    class Utility
    {
        public static OracleDataReader GetDataReader(string query)
        {
            try
            {
                OracleCommand command = new OracleCommand(query, SessionBAL.sConnection);
                OracleDataReader reader = command.ExecuteReader();

                command.Dispose();

                return reader;
            }
            catch (Exception)
            {                
                return null;
            }
        }
    }
}

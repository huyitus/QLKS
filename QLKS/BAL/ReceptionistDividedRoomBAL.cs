using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class ReceptionistDividedRoomBAL
    {
        public static bool Insert(string maDP, string maPhong)
        {
            return ReceptionistDividedRoomDAL.Insert(maDP, maPhong);
        }
    }
}

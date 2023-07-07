using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class ReceptionistDividedRoomBAL
    {
        public static bool Thuchienphanphong(string maDP, string maPhong)
        {
            return ReceptionistDividedRoomDAL.Thuchienphanphong(maDP, maPhong);
        }
    }
}

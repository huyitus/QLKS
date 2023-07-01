using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class RoomAgencyBAL
    {
        public static void LoadInto(DataGridView dgvRooms, bool isEmpty, bool isClean)
        {
            List<RoomAgencyDAL> rooms = RoomAgencyDAL.Get(isEmpty, isClean);
            dgvRooms.DataSource = rooms;
        }
    }
}

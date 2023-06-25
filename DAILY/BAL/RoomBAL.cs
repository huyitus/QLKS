using System.Collections.Generic;
using System.Windows.Forms;
using QLKS.DAL;

namespace QLKS.BAL
{
    class RoomBAL
    {
        public static void LoadRooms(ref DataGridView dgvRooms, bool isEmpty, bool isClean)
        {
            List<RoomDAL> rooms = RoomDAL.GetRooms(isEmpty, isClean);
            dgvRooms.DataSource = rooms;
        }
    }
}

using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class RoomBAL
    {
        public static void LoadRoomsInto(DataGridView dgvRooms, bool isEmpty, bool isClean)
        {
            List<RoomDAL> rooms = RoomDAL.GetRooms(isEmpty, isClean);
            dgvRooms.DataSource = rooms;
        }

        public static void LoadEmptyInto(DataGridView dgvRooms, string typeName)
        {
            List<RoomDAL> rooms = RoomDAL.GetEmpty(typeName);
            dgvRooms.DataSource = rooms;
        }
    }
}

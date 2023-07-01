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

        public static bool IsEmptyRoom(string roomId)
        {
            return RoomDAL.IsEmptyRoom(roomId);
        }
    }
}

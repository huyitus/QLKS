using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class RoomBAL
    {
        public static void LoadToAgency(DataGridView dgvRooms, bool isEmpty, bool isClean)
        {
            List<RoomDAL.RoomAgencyDAL> rooms = RoomDAL.RoomAgencyDAL.GetForAgency(isEmpty, isClean);
            dgvRooms.DataSource = rooms;
        }
    }
}

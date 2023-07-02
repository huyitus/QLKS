using QLKS.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class ReceptionistRoomBAL
    {
        public static void LoadInfo(DataGridView dgvDSDatPhong)
        {
            List<ReceptionistRoomDAL.ThongTinDatPhongDAL> thongtindatphong = ReceptionistRoomDAL.ThongTinDatPhongDAL.LoadThongTinDatPhong();
            dgvDSDatPhong.DataSource = thongtindatphong;
        }
    }
}

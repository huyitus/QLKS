using QLKS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class ReceptionistManageRoomBAL
    {
        public static void LoadInfo(DataGridView dgv_phong)
        {
            List<ReceptionistManageRoomDAL> thongtinphong = ReceptionistManageRoomDAL.LoadThongTinPhong();
            dgv_phong.DataSource = thongtinphong;
        }
        public static void SearchInfo(DataGridView dgvThongTinPhong, string maphong)
        {
            List<ReceptionistManageRoomDAL> thongtinphong = ReceptionistManageRoomDAL.Search(maphong);
            dgvThongTinPhong.DataSource = thongtinphong;
        }
        public static void ReLoadInfo(DataGridView dgvThongTinPhong)
        {
            List<ReceptionistManageRoomDAL> thongtinphong = ReceptionistManageRoomDAL.LoadThongTinPhong();
            dgvThongTinPhong.DataSource = thongtinphong;
        }
    }
}

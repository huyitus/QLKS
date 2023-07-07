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
        public static void LoadInfo(DataGridView dgv_phong, DataGridView dgv_dvp)
        {
            List<ReceptionistManageRoomDAL.QuanLyPhongDAL> thongtinphong = ReceptionistManageRoomDAL.QuanLyPhongDAL.LoadThongTinPhong();
            dgv_phong.DataSource = thongtinphong;
            List<ReceptionistManageRoomDAL.DV_PhongDAL> dv_phong = ReceptionistManageRoomDAL.DV_PhongDAL.LoadDV_Phong();
            dgv_dvp.DataSource = dv_phong;
        }
        public static void SearchInfo(DataGridView dgvThongTinPhong, DataGridView dgv_DVP, string maphong)
        {
            List<ReceptionistManageRoomDAL.QuanLyPhongDAL> thongtinphong = ReceptionistManageRoomDAL.QuanLyPhongDAL.Search(maphong);
            dgvThongTinPhong.DataSource = thongtinphong;
            List<ReceptionistManageRoomDAL.DV_PhongDAL> dv_phong = ReceptionistManageRoomDAL.DV_PhongDAL.Search(maphong);
            dgv_DVP.DataSource = dv_phong;
        }
        public static bool SendRequestDelDV(string id)
        {
            return ReceptionistManageRoomDAL.DV_PhongDAL.Del(id);
        }
        public static bool AddServiceToRoom(string maphong, string madv, string sl)
        {
            return ReceptionistManageRoomDAL.DV_PhongDAL.Insert(maphong, madv, sl);
        }
    }
}

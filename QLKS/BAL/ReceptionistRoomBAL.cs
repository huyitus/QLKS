using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class ReceptionistRoomBAL
    {
        public static void LoadInfo(DataGridView dgvDSDatPhong, DataGridView dgvDSPhong, bool isEmpty, bool isClean)
        {
            List<ReceptionistRoomDAL.ThongTinDatPhongDAL> thongtindatphong = ReceptionistRoomDAL.ThongTinDatPhongDAL.LoadThongTinDatPhong();
            dgvDSDatPhong.DataSource = thongtindatphong;
            List<ReceptionistRoomDAL.ThongTinPhongDAL> thongtinphong = ReceptionistRoomDAL.ThongTinPhongDAL.Loadthongtinphong(isEmpty, isClean);
            dgvDSPhong.DataSource = thongtinphong;
        }
        public static void SearchInfo(DataGridView dgvDSDatPhong, string tenKH)
        {
            List<ReceptionistRoomDAL.ThongTinDatPhongDAL> thongtindatphong = ReceptionistRoomDAL.ThongTinDatPhongDAL.Search(tenKH);
            dgvDSDatPhong.DataSource = thongtindatphong;
        }
        public static void ReLoadInfo(DataGridView dgvDSDatPhong)
        {
            List<ReceptionistRoomDAL.ThongTinDatPhongDAL> thongtindatphong = ReceptionistRoomDAL.ThongTinDatPhongDAL.LoadThongTinDatPhong();
            dgvDSDatPhong.DataSource = thongtindatphong;
        }
    }
}

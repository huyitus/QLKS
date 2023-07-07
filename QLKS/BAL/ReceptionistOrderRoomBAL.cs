using QLKS.DAL;

using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKS.BAL
{
    class ReceptionistOrderRoomBAL
    {
        public static void LoadInfo(DataGridView dgvDSPhong, ComboBox cbLoaiPhong)
        {
            List<ReceptionistOrderRoomDAL.ThongTinPhongDAL> thongtinphong = ReceptionistOrderRoomDAL.ThongTinPhongDAL.Loadthongtinphong();
            dgvDSPhong.DataSource = thongtinphong;

            List<ReceptionistOrderRoomDAL.LoaiPhongDAL> loaiphong = ReceptionistOrderRoomDAL.LoaiPhongDAL.loadLoaiPhong();
            for (int i = 0; i < loaiphong.Count; ++i) 
            {
                cbLoaiPhong.Items.Add(loaiphong[i].LoaiPhong);
            }
        }

        public static void UpdateInfo(DataGridView dgvDSPhong, string loaiPhong)
        {
            List<ReceptionistOrderRoomDAL.ThongTinPhongDAL> thongtinphong = ReceptionistOrderRoomDAL.ThongTinPhongDAL.LoadthongtinphongTheoLoai(loaiPhong);
            dgvDSPhong.DataSource = thongtinphong;
        }
      
    }
}

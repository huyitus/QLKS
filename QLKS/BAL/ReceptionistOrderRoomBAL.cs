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

        public static bool DatPhongNhom(string ten, string sdt, string diachi, string email, string sofax, string tendoan, string soluongnguoi, string loaiphong, string maphong, string ngayden, string sodemluutru)
        {
            return ReceptionistOrderRoomDAL.DatPhongTheoNhom(ten, sdt, diachi, email, sofax, tendoan, soluongnguoi, loaiphong, maphong, ngayden, sodemluutru);
        }
        public static bool DatPhongCaNhan(string ten, string sdt, string diachi, string email, string sofax, string loaiphong, string maphong, string ngayden, string sodemluutru)
        {
            return ReceptionistOrderRoomDAL.DatPhong(ten, sdt, diachi, email, sofax, loaiphong, maphong, ngayden, sodemluutru);
        }
    }
}

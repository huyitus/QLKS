using QLKS.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.ManagedDataAccess.Client;


namespace QLKS.DAL
{
    class ReceptionistRoomDAL
    {
        public class ThongTinDatPhongDAL
        {
            public string ID_DatPhong { get; set; }
            public string TenKhachHang { get; set; }
            public string TenLoaiPhong { get; set; }
            public string NgayDen { get; set; }
            public int SoDemLuuTru { get; set; }

            public ThongTinDatPhongDAL(string ID_datPhong, string tenKhachHang, string tenLoaiPhong, string ngayDen, string soDemLuuTru)
            {
                ID_DatPhong = ID_datPhong;
                TenKhachHang = tenKhachHang;
                TenLoaiPhong = tenLoaiPhong;
                NgayDen = ngayDen;
                SoDemLuuTru = soDemLuuTru == null ? 0 : int.Parse(soDemLuuTru);
            }

            public static List<ThongTinDatPhongDAL> LoadThongTinDatPhong()
            {
                List<ThongTinDatPhongDAL> thongtindatphong = new List<ThongTinDatPhongDAL>();
                //string query = "SELECT DP.MADATPHG, KH.TENKH, DP.TENLOAIPHONG, DP.NGAYDEN, DP.SODEMLUUTRU FROM QLKS.KHACHHANG KH, QLKS.DATPHONG DP WHERE KH.MAKH=DP.MAKH;";
                string query = "SELECT * FROM QLKS.KHACHHANG;";

                using (OracleDataReader reader = Utility.GetDataReader(query))
                {
                    while (reader != null && reader.Read())
                    {
                        var ID_datPhong = reader.GetString(0);
                        var tenKhachHang = reader.GetString(1);
                        var tenLoaiPhong = reader.GetString(2);
                        var ngayDen = reader.GetString(3);
                        var soDemLuuTru = reader.GetString(4);

                        ThongTinDatPhongDAL ttdp = new ThongTinDatPhongDAL(ID_datPhong, tenKhachHang, tenLoaiPhong, ngayDen, soDemLuuTru);
                        thongtindatphong.Add(ttdp);
                    }
                }
                return thongtindatphong;
            }
        }
    }
}

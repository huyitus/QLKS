using QLKS.DAL;
using System.Collections.Generic;
using System.Windows.Forms;
using QLKS.BAL;
using System;
using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLKS.BAL
{
    class BillBAL
    {
        public static void LoadBillInto(DataGridView dgv_hd)
        {
            List<BillDAL> bills = BillDAL.GetBill();
            dgv_hd.DataSource = bills;
        }
        public static bool SendRequestAddBill(string manhanvien, string madatphong, DateTime tglaphd, int tongtien)
        {
            return BillDAL.Insert(manhanvien, madatphong, tglaphd, tongtien);
        }
        public static string TinhTienHoaDon(string maphong)
        {
            return BillDAL.Execute_pr_TinhTienHoaDon(maphong);
        }
        public static string CheckMaNhanVien(string manhanvien)
        {
            return BillDAL.Execute_pr_CheckNhanVien(manhanvien);
        }
        public static string CheckMaPhong(string maphong)
        {
            return BillDAL.Execute_pr_CheckMaPhong(maphong);
        }
        public static string TimMaDatPhong(string maphong)
        {
            return BillDAL.SelectMaDatPhong(maphong);
        }


    }
}
using QLKS.BAL;
using QLKS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormXuatHD : Form
    {
        private readonly Form parent;
        private readonly string HoaDonID;
        public FormXuatHD()
        {
            InitializeComponent();
        }
        public FormXuatHD(Form parent, string Id)
        {
            InitializeComponent();
            this.parent = parent;
            this.HoaDonID = Id;
        }

        private void FormXuatHD_Load(object sender, EventArgs e)
        {
            BillDAL hd = BillDAL.GetBillInf(HoaDonID);
            if (hd != null)
            {
                textBox1.Text = HoaDonID;
                textBox2.Text = hd.MaNV;
                textBox3.Text = hd.MaDatPhong;
                textBox5.Text = hd.TongTien.ToString();
                dateTimePicker1.Value = hd.NgayLap;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã kết nối tới máy in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}

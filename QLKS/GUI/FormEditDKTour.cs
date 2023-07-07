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
using System.Xml.Linq;

namespace QLKS.GUI
{
    public partial class FormEditDKTour : Form
    {
        private readonly Form parent;
        private readonly string DKTourID;
        public FormEditDKTour()
        {
            InitializeComponent();
        }
        public FormEditDKTour(Form parent, string Id)
        {
            InitializeComponent();
            this.parent = parent;
            this.DKTourID = Id;
        }

        private void FormAdminEditDV_Load(object sender, EventArgs e)
        {
            DKTourDAL dk = DKTourDAL.GetDKTourDV(DKTourID);
            if (dk != null)
            {
                textBox1.Text = DKTourID;
                textBox2.Text = dk.MaTour;
                textBox3.Text = dk.TenKH;
                textBox4.Text = dk.SDT;
                textBox5.Text = dk.SoNguoiTG.ToString();
                textBox6.Text = dk.HinhThucDiChuyen;
                textBox8.Text = dk.NhuCauDacBiet;
                dateTimePicker1.Value = dk.ThoiGianXuatPhat;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = textBox2.Text;
            string tenkh = textBox3.Text;
            string sdt = textBox4.Text;
            int songuoi = Int32.Parse(textBox5.Text);
            string hinhthuc = textBox6.Text;
            string yeucau = textBox8.Text;
            DateTime tg = Convert.ToDateTime(dateTimePicker1.Value);
            if (DKTourBAL.CheckMaTour(matour).ToString() == "0")
            {
                MessageBox.Show("Mã tour này không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DKTourBAL.Update(DKTourID, matour, tenkh, sdt, songuoi, hinhthuc, tg, yeucau))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                }
            }
            
        }
    }
}

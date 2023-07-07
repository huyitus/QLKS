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
    public partial class FormLT_editCus : Form
    {
        private readonly Form parent;
        private readonly string id;
        public FormLT_editCus(Form parent, string id)
        {
            InitializeComponent();
            this.parent = parent;
            this.id = id;
        }

        private void FormLT_editCus_Load(object sender, EventArgs e)
        {
            CusDAL cus = CusBAL.GetCus(id);
            if (cus != null)
            {
                txtmakh.Text = id;
                txttenkh.Text = cus.TenKH;
                txtsdt.Text = cus.SDT;
                txtemail.Text = cus.DiaChi;
                txtdc.Text = cus.Email;
                txtfax.Text = cus.Fax;
                txtgr.Text = cus.Doan;
                txtsl.Text = cus.SL;
            }
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            string name = txttenkh.Text;
            string sdt = txtsdt.Text;
            string dc = txtemail.Text;
            string email = txtdc.Text;
            string fax = txtfax.Text;
            string doan = txtgr.Text;
            string sl = txtsl.Text;

            if (CusBAL.Update(id, name, sdt, dc, email, fax, doan, sl))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

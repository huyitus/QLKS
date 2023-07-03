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
    public partial class FormAdminEditDT : Form
    {
        private readonly Form parent;
        private readonly string DTId;
        public FormAdminEditDT()
        {
            InitializeComponent();
        }
        public FormAdminEditDT(Form parent, string madt)
        {
            InitializeComponent();
            this.parent = parent;
            this.DTId = madt;
        }
        private void FormAdminEditDT_Load(object sender, EventArgs e)
        {
            PnDAL dt = PnBAL.GetDT(DTId);
            if (dt != null)
            {
                txtId.Text = dt.MaDT;
                txtTenDT.Text = dt.TenDT;
                txtMatour.Text = dt.MaTour;
                txtDc.Text = dt.DiaChi;
                txtSDT.Text = dt.SDT;
                txtMail.Text = dt.Email;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtTenDT.Text;
            string mt = txtMatour.Text;
            string dc = txtDc.Text;
            string sdt = txtSDT.Text;
            string mail = txtMail.Text;

            if (PnBAL.Update(DTId, name, mt, dc,sdt,mail))
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

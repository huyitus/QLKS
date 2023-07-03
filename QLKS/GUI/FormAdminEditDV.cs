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
    public partial class FormAdminEditDV : Form
    {
        private readonly Form parent;
        private readonly string DVId;

        public FormAdminEditDV()
        {
            InitializeComponent();
        }
        public FormAdminEditDV(Form parent, string Id)
        {
            InitializeComponent();
            this.parent= parent;
            this.DVId = Id;
        }

        private void FormAdminEditDV_Load(object sender, EventArgs e)
        {
            DvDAL dv = DvBAL.GetDV(DVId);
            if (dv != null)
            {
                txtId.Text = DVId;
                txtTenDV.Text = dv.TenDV;
                txtGiaDV.Text = dv.Gia.ToString();
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtTenDV.Text;
            string gia = txtGiaDV.Text;

            if (DvBAL.Update(DVId, name, gia))
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

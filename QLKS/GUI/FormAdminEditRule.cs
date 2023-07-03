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
    public partial class FormAdminEditRule : Form
    {
        private readonly Form parent;
        private readonly string QDId;
        public FormAdminEditRule()
        {
            InitializeComponent();
        }
        public FormAdminEditRule(Form parent, string id)
        {
            InitializeComponent();
            this.parent = parent;
            this.QDId = id;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nd = txtND.Text;

            if (RuleBAL.Update(QDId, nd))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdminEditRule_Load(object sender, EventArgs e)
        {
            RuleDAL qd = RuleBAL.GetRule(QDId);
            if (qd != null)
            {
                txtId.Text = QDId;
                txtND.Text = qd.NoiDung;
            }
        }
    }
}

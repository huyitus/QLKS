using QLKS.BAL;
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
    public partial class FormAdmin_NV : Form
    {
        public FormAdmin_NV()
        {
            InitializeComponent();
        }

        private void FormAdmin_NV_Load(object sender, EventArgs e)
        {
            NvBAL.LoadNVInto(dgv_NV);
        }

        private void FormAdmin_NV_FormClosing(object sender, FormClosingEventArgs e) 
        {

        }

        private void butt_Fix_Click(object sender, EventArgs e)
        {
            string id = dgv_NV.CurrentRow.Cells["MaNV"].Value.ToString();
            if (id != null)
            {
                Form form = new FormAdminEditEmployee(this, id);
                form.Show();
            }
        }
    }
}

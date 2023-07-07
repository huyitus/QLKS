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
    public partial class FormAdmin_HD : Form
    {
        public FormAdmin_HD()
        {
            InitializeComponent();
            if (SessionBAL.getUserRole == "QLKS")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private void FormAdmin_HD_Load(object sender, EventArgs e)
        {
            BillBAL.LoadBillInto(dgv_hd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dgv_hd.CurrentRow.Cells["MaHD"].Value.ToString();
            if (id != null)
            {
                Form form = new FormXuatHD(this, id);
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddBill ThemHD = new FormAddBill();
            this.Hide();
            ThemHD.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BillBAL.LoadBillInto(dgv_hd);
        }
    }
}

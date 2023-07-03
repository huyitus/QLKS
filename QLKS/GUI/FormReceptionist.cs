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
    public partial class FormReceptionist : Form
    {
        private readonly Form parent;
        public FormReceptionist(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnTracuuKH_Click(object sender, EventArgs e)
        {
            Form LT_Customer = new FormLT_Customer(this);
            this.Hide();
            LT_Customer.ShowDialog();
        }

        private void btnTracuuPhong_Click(object sender, EventArgs e)
        {
            Form ShowRoom = new FormRoom(this);
            this.Hide();
            ShowRoom.ShowDialog();
        }
        private void btnTracuuDV_Click(object sender, EventArgs e)
        {
            Form LT_Service = new FormLT_Service(this);
            this.Hide();
            LT_Service.ShowDialog();
        }
        private void FormReceptionist_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnYCDaiLy_Click(object sender, EventArgs e)
        {
            Form form = new FormReceptionistViewRequest();
            form.Show();
        }
    }
}

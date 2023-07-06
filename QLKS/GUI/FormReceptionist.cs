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
            Form ShowRoom = new FormReceptionistViewRoom(this);
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

        private void btnQuiDinh_Click(object sender, EventArgs e)
        {
            Form ShowQuiDinh = new FormAdmin_QD();
            this.Hide();
            ShowQuiDinh.ShowDialog();
            this.Show();
        }

        private void btnTracuuTourDL_Click(object sender, EventArgs e)
        {
            FormAdmin_Tour ShowTour = new FormAdmin_Tour();
            this.Hide();
            ShowTour.ShowDialog();
            this.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormAdmin_HD ShowHoadon = new FormAdmin_HD();
            this.Hide();
            ShowHoadon.ShowDialog();
            this.Show();
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            Form RecepManageRoom = new FormRecepManageRoom(this);
            this.Hide();
            RecepManageRoom.ShowDialog();
        }
    }
}

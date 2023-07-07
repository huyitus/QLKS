using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormReceptionistOrderPersionalRoom : Form
    {
        private readonly Form parent;

        public FormReceptionistOrderPersionalRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormReceptionistOrderPersionalRoom_Load(object sender, EventArgs e)
        {
            ReceptionistOrderRoomBAL.LoadInfo(dgvPhong, cbLoaiPhong);
        }

        private void FormReceptionistOrderPersionalRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiphong = cbLoaiPhong.SelectedItem.ToString();
            ReceptionistOrderRoomBAL.UpdateInfo(dgvPhong, loaiphong);
        }
    }
}

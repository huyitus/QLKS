using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormRecepOrderGroupRoom : Form
    {
        private readonly Form parent;
        public FormRecepOrderGroupRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormRecepOrderGroupRoom_Load(object sender, EventArgs e)
        {
            ReceptionistOrderRoomBAL.LoadInfo(dgvPhong,cbLoaiPhong);
                    }

        private void FormRecepOrderGroupRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiphong = cbLoaiPhong.SelectedItem.ToString();
            ReceptionistOrderRoomBAL.UpdateInfo(dgvPhong, loaiphong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phongdat = dgvPhong.CurrentRow.Cells[0].Value.ToString();

        }
    }
}

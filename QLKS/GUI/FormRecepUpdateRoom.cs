using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormRecepUpdateRoom : Form
    {
        private FormReceptionistViewRoom parent;

        public FormRecepUpdateRoom(FormReceptionistViewRoom parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormRecepUpdateRoom_Load(object sender, EventArgs e)
        {
            RecepUpdateRoomBAL.LoadMaPhong(cbMaPhong);
            cbTTDonDep.Items.Add("Chua don");
            cbTTDonDep.Items.Add("Da don");
            cbTTDonDep.Items.Add("Dang don");
        }

        private void FormRecepUpdateRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string TTDonDep = cbTTDonDep.SelectedItem.ToString();
            string maPhong = cbMaPhong.SelectedItem.ToString();
            if (RecepUpdateRoomBAL.Update(maPhong, TTDonDep))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parent.UpdateTinhTrangPhong();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

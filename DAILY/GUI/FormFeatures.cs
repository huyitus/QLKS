using System;
using System.Windows.Forms;
using QLKS.BAL;

namespace QLKS.GUI
{
    public partial class FormFeatures : Form
    {
        private readonly Form parent;

        public FormFeatures(FormLogin parent)
        {
            InitializeComponent();
            this.parent = parent;
            RoomBAL.LoadRooms(ref dgvRooms, false, false);
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            bool isEmpty = chkEmpty.Checked;
            bool isClean = chkClean.Checked;
            RoomBAL.LoadRooms(ref dgvRooms, isEmpty, isClean);
        }

        private void FormFeatures_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            string roomId = dgvRooms.CurrentRow.Cells["ID"].Value.ToString();

            DialogResult result = MessageBox.Show("Xác nhận đặt phòng " + roomId + "?", 
                "Xác nhận", 
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Tính năng đang được hoàn thiện.", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}

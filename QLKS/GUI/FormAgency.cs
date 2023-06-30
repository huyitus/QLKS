using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormAgency : Form
    {
        private const string CONFIRM_BOOKING_MESSAGE = "Xác nhận đặt phòng";
        private const string CONFIRM_CAPTION = "Xác nhận";

        private readonly FormLogin loginForm;

        public FormAgency(FormLogin parent)
        {
            InitializeComponent();
            this.loginForm = parent;
        }

        private void FormAgency_Load(object sender, EventArgs e)
        {
            loginForm.Hide();
            RoomBAL.LoadRoomsInto(dgvRooms, false, false);
        }

        private void FormAgency_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionBAL.Finish();
            loginForm.ClearInput();
            loginForm.Show();
        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            bool isEmpty = chkEmpty.Checked;
            bool isClean = chkClean.Checked;
            RoomBAL.LoadRoomsInto(dgvRooms, isEmpty, isClean);
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            string roomId = dgvRooms.CurrentRow.Cells["ID"].Value.ToString();
            string message = CONFIRM_BOOKING_MESSAGE + " " + roomId + "?";
            if (MessageBox.Show(message, CONFIRM_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }
    }
}

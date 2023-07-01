using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormAgency : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_NO_EMPTY = "Phòng này không còn trống!";

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

            if (RoomBAL.IsEmptyRoom(roomId))
            {
                Form bookingForm = new FormAgencyBooking(this, roomId);
                bookingForm.Show();
            }    
            else
            {
                MessageBox.Show(MESSAGE_NO_EMPTY, MESSAGE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

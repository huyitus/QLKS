using QLKS.BAL;

using System;
using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormAgency : Form
    {
        private const string MESSAGE_CAPTION = "Thông báo";
        private const string MESSAGE_NO_EMPTY = "Phòng này không còn trống!";

        private readonly Form parent;

        public FormAgency(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormAgency_Load(object sender, EventArgs e)
        {
            parent.Hide();
            RoomAgencyBAL.LoadInto(dgvRooms, false, false);
        }

        private void FormAgency_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionBAL.Finish();
            parent.Show();
        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            bool isEmpty = chkEmpty.Checked;
            bool isClean = chkClean.Checked;
            RoomAgencyBAL.LoadInto(dgvRooms, isEmpty, isClean);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            string typeName = dgvRooms.CurrentRow.Cells["TypeName"].Value.ToString();

            Form bookingForm = new FormAgencyBooking(this, typeName);
            bookingForm.Show();
        }
    }
}

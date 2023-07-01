using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormAgencyBooking : Form
    {
        private readonly FormAgency agencyFrom;
        private readonly string roomId;

        public FormAgencyBooking(FormAgency parent, string roomId)
        {
            InitializeComponent();
            this.agencyFrom = parent;
            this.roomId = roomId;
        }

        private void FormAgencyBooking_Load(object sender, System.EventArgs e)
        {
            agencyFrom.Hide();
            txtRoomID.Text = roomId;
        }

        private void FormAgencyBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            agencyFrom.Show();
        }
    }
}

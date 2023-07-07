using QLKS.BAL;

using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormReceptionistViewRequest : Form
    {
        public FormReceptionistViewRequest()
        {
            InitializeComponent();
        }

        private void FormReceptionistViewRequest_Load(object sender, System.EventArgs e)
        {
            RequestBookingBAL.LoadInto(dgvRequests);
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string typeName = dgvRequests.CurrentRow.Cells["TypeName"].Value.ToString();
            lblTitle.Text = "Danh sách phòng loại \"" + typeName + "\" còn trống:";
            RoomBAL.LoadEmptyInto(dgvRoomEmpty, typeName);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string idRequest = dgvRequests.CurrentRow.Cells["ID"].Value.ToString();
            if (RequestBookingBAL.Delete(idRequest))
            {
                RequestBookingBAL.LoadInto(dgvRequests);
                dgvRoomEmpty.DataSource = null;
                dgvRoomEmpty.Rows.Clear();
                dgvRoomEmpty.Refresh();
                lblTitle.Text = "Vui lòng chọn yêu cầu để xem";
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form form = new FormReceptionistOrderPersionalRoom(this);
            form.Show();
        }

        /*private void button1_Click(object sender, System.EventArgs e)
        {
            Form RecepSelectOrder = new FormRecepSelectedOrder(this);
            this.Hide();
            RecepSelectOrder.ShowDialog();
        }*/
    }
}

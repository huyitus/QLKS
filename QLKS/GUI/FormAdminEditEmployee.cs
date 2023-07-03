using QLKS.DAL;
using QLKS.BAL;

using System.Windows.Forms;

namespace QLKS.GUI
{
    public partial class FormAdminEditEmployee : Form
    {
        private readonly Form parent;
        private readonly string employeeId;

        public FormAdminEditEmployee(Form parent, string employeeId)
        {
            InitializeComponent();
            this.parent = parent;
            this.employeeId = employeeId;
        }

        private void BtnUpdate_Click(object sender, System.EventArgs e)
        {
            string name = txtName.Text;
            string addr = txtAddress.Text;
            string sdt = txtPhone.Text;
            string pos = txtPosition.Text;

            if (NvBAL.Update(employeeId, name, addr, sdt, pos))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdminEditEmployee_Load(object sender, System.EventArgs e)
        {
            NvDAL nv = NvBAL.GetNV(employeeId);
            if (nv != null)
            {
                txtId.Text = employeeId;
                txtName.Text = nv.TenNV;
                txtAddress.Text = nv.DiaChi;
                txtPhone.Text = nv.SDT;
                txtPosition.Text = nv.ChucVu;
            }
        }
    }
}

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLKS.GUI
{
    public partial class FormAddCustomer : Form
    {
        private readonly Form parent;
        public FormAddCustomer(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormAddCustomer_Form_Closed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}

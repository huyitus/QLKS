using QLKS.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLKS.GUI
{
    public partial class FormLT_Customer : Form
    {
        private readonly Form parent;
        public FormLT_Customer(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form LT_InsertCus = new FormAddCustomer(this);
            this.Hide();
            LT_InsertCus.ShowDialog();
        }

        private void FormLT_Customer_Form_Closed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void FormLT_Customer_Load(object sender, EventArgs e)
        {
            CusBAL.LoadCusInto(dataKH);
        }
    }
}

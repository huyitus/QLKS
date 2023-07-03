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
    public partial class FormLT_Service : Form
    {
        private readonly Form parent;
        public FormLT_Service(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void FormLT_Service_Load(object sender, EventArgs e)
        {
            DvBAL.LoadDVInto(dataDV);
        }
        private void FormLT_Service_FormClosed(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
    
}

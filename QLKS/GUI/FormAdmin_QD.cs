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

namespace QLKS.GUI
{
    public partial class FormAdmin_QD : Form
    {
        public FormAdmin_QD()
        {
            InitializeComponent();
        }

        private void dtg_QD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdmin_QD_Load(object sender, EventArgs e)
        {
            RuleBAL.LoadRuleInto(dtg_QD);
        }
    }
}

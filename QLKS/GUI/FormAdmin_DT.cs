﻿using QLKS.BAL;
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
    public partial class FormAdmin_DT : Form
    {
        public FormAdmin_DT()
        {
            InitializeComponent();
        }

        private void FormAdmin_DT_Load(object sender, EventArgs e)
        {
            PnBAL.LoadPartnerInto(dgv_DT);
        }
    }
}

﻿using System;
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
    public partial class FormDevideRoom : Form
    {
        private readonly Form parent;
        public FormDevideRoom(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormDevideRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
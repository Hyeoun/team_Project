﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_Project {
    public partial class Minimapdlg : Form {
        public Minimapdlg()
        {
            InitializeComponent();
        }

        private void Minimapdlg_Load(object sender, EventArgs e)
        {
            var parent = this.Owner as Form1;
        }
    }
}

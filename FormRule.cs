using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class FormRule : Form
    {
        public FormRule()
        {
            InitializeComponent();
            rbRule.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

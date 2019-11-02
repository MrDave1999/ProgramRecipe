using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    partial class FrmDeleteDrugs : Form
    {
        public FrmDeleteDrugs()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmOptionsDelete opDelete = new FrmOptionsDelete(ctuGridDrugs);
            opDelete.ShowDialog();
        }
    }
}

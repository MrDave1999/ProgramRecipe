using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    partial class FrmUpdateDrugs : Form
    {      
        public FrmUpdateDrugs()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateCampus updateCampus = new FrmUpdateCampus(ctuGridDrugs);
            updateCampus.ShowDialog();
        }
    }
}

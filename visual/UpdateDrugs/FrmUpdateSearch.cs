using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    public partial class FrmUpdateSearch : Form
    {
        public FrmUpdateSearch()
        {
            InitializeComponent();
        }

        private void btnShowRecipe_Click(object sender, EventArgs e)
        {
            FrmUpdateDrugs updateDrugs = new FrmUpdateDrugs();
            if (updateDrugs.CtuGridDrug.FillGridRecipe(ctuSearch.CtuGridPatientx))
                return;
            updateDrugs.ShowDialog();
        }

        private void FrmUpdateSearch_Activated(object sender, EventArgs e)
        {
            ctuSearch.TxtSearch.Focus();
        }

    }
}

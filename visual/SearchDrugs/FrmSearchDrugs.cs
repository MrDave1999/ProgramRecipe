using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    public partial class FrmSearchDrugs : Form
    {
        public FrmSearchDrugs()
        {
            InitializeComponent();
        }

        private void btnShowRecipe_Click(object sender, EventArgs e)
        {
            FrmDrugsPatient drugPatient = new FrmDrugsPatient();
            if (drugPatient.CtuGridDrug.FillGridRecipe(ctuSearch.CtuGridPatientx))
                return;
            drugPatient.ShowDialog();
            
        }

        private void FrmSearchDrugs_Activated(object sender, EventArgs e)
        {
            ctuSearch.TxtSearch.Focus();
        }
    }
}

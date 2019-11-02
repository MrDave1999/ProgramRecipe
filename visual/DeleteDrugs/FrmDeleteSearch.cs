using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    public partial class FrmDeleteSearch : Form
    {
        public FrmDeleteSearch()
        {
            InitializeComponent();
        }

        private void btnShowRecipe_Click(object sender, EventArgs e)
        {
            FrmDeleteDrugs deleteDrug = new FrmDeleteDrugs();
            if (deleteDrug.CtuGridDrug.FillGridRecipe(ctuSearch.CtuGridPatientx))
                return;
            deleteDrug.ShowDialog();
        }

        private void FrmDeleteSearch_Activated(object sender, EventArgs e)
        {
            ctuSearch.TxtSearch.Focus();
        }
    }
}

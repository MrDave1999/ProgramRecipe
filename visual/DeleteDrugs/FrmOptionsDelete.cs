using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    partial class FrmOptionsDelete : Form
    {
        private CtuGridDrugs ctuGridDrugs;
        public FrmOptionsDelete(CtuGridDrugs ctuGridDrugs)
        {
            InitializeComponent();
            this.ctuGridDrugs = ctuGridDrugs;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            int i;
            if(ctuGridDrugs.DgvDrugs.Rows.Count == 0)
            {
                MessageBox.Show("Error: La tabla está vacía.");
                return;
            }
            i = ctuGridDrugs.DgvDrugs.CurrentRow.Index;
            if (AdmRecipe.Delete(ctuGridDrugs.DgvDrugs.Rows[i].Cells[0].Value.ToString()))
                return;
            ctuGridDrugs.DgvDrugs.Rows.RemoveAt(i);
            ctuGridDrugs.LblDrugs.Text = "Total de Farmacos: " + ctuGridDrugs.DgvDrugs.RowCount;
            Close();
        }
    }
}

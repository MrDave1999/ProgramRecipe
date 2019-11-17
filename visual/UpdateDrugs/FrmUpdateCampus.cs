using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    partial class FrmUpdateCampus : Form
    {
        CtuGridDrugs ctuGridDrugs;
        public FrmUpdateCampus(CtuGridDrugs ctuGridDrugs)
        {
            InitializeComponent();
            this.ctuGridDrugs = ctuGridDrugs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = ctuGridDrugs.DgvDrugs.CurrentRow.Index;
            if (AdmRecipe.Update(ctuDrugs.TxtPrescription.Text,
                ctuDrugs.DtpDateDest.Value, 
                ctuGridDrugs.DgvDrugs.Rows[i].Cells[0].Value.ToString())
                )
                return;
            ctuGridDrugs.DgvDrugs.Rows[i].Cells[1].Value = ctuDrugs.TxtPrescription.Text;
            ctuGridDrugs.DgvDrugs.Rows[i].Cells[2].Value = ctuDrugs.DtpDateDest.Value.ToShortDateString();
            MessageBox.Show("Dato actualizado!");
            Close();
        }
    }
}

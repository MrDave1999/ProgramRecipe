using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    partial class FrmAddDrugs : Form
    {
        public FrmAddDrugs()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtDrug.Text.Length == 0 || ctuDrugs.TxtPrescription.Text.Length == 0)
            {
                MessageBox.Show("Debes llenar los campos vacíos.");
                return;
            }

            if(AdmPatient.IsRepeatData("tableRecipe", "Farmaco", txtDrug.Text))
            {
                MessageBox.Show("Ese farmaco ya lo tiene el paciente.");
                return;
            }

            if (AdmRecipe.Save(txtDrug.Text, ctuDrugs.TxtPrescription.Text, ctuDrugs.DtpDateDest.Value))
                return;
            ctuGridDrugs.DgvDrugs.Rows.Add(txtDrug.Text, ctuDrugs.TxtPrescription.Text, ctuDrugs.DtpDateDest.Value.ToShortDateString(), DateTime.Now.ToShortDateString());
            ctuGridDrugs.LblDrugs.Text = "Total de Farmacos: " + ctuGridDrugs.DgvDrugs.RowCount;
            txtDrug.Clear();
            ctuDrugs.TxtPrescription.Clear();
        }

        private void FrmAddDrugs_Activated(object sender, EventArgs e)
        {
            txtDrug.Focus();
        }

    }
}

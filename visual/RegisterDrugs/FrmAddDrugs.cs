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
            DateTime dateDest;
            DateTime dateBegin;

            string sdateDest;
            string sdateBegin;

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

            dateBegin = DateTime.Now;
            dateDest = Convert.ToDateTime(ctuDrugs.DtpDateDest.Text);
            sdateDest = dateDest.ToShortDateString();
            sdateBegin = dateBegin.ToShortDateString();

            if (AdmRecipe.Save(txtDrug.Text, ctuDrugs.TxtPrescription.Text, sdateDest, sdateBegin))
                return;
            ctuGridDrugs.DgvDrugs.Rows.Add(txtDrug.Text, ctuDrugs.TxtPrescription.Text, sdateDest, sdateBegin);
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

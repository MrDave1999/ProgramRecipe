using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    partial class CtuGridDrugs : UserControl
    {
        public CtuGridDrugs()
        {
            InitializeComponent();
        }

        public bool FillGridRecipe(CtuGridPatient ctuGridPatient)
        {
            if (ctuGridPatient.GetCountPatient() == 0)
            {
                MessageBox.Show("Error: No hay ningún paciente en la tabla.");
                return true;
            }
            dgvDrugs.Rows.Clear();
            AdmRecipe.CardPatient = ctuGridPatient.GetInfoPatientRow();
            if (AdmRecipe.Read())
                return true;
            foreach (Recipe rp in AdmRecipe.ListRecipe)
                dgvDrugs.Rows.Add(rp.Drugs, rp.Prescription, rp.DateDest.ToShortDateString(), rp.DateBegin.ToShortDateString());
            if (AdmRecipe.ListRecipe.Count == 0)
            {
                MessageBox.Show("Error: Ese paciente no tiene receta médica.");
                return true;
            }
            LblPatient.Text = "Paciente: " + ctuGridPatient.GetInfoPatientRow(0) + " " + ctuGridPatient.GetInfoPatientRow(1);
            LblDrugs.Text = "Total de Farmacos: " + dgvDrugs.RowCount;
            AdmRecipe.ListRecipe.Clear();
            return false;
        }
    }
}

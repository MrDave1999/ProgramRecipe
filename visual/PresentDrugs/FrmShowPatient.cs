using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    public partial class FrmShowPatient : Form
    {
        public FrmShowPatient()
        {
            InitializeComponent();
            if (AdmPatient.ReadAll())
                return;
            foreach (Patient pt in AdmPatient.ListPatient)
                ctuGridPatient.DgvPatient.Rows.Add(pt.Name, pt.Surname, pt.Idcard, pt.Age);

            if (ctuGridPatient.DgvPatient.Rows.Count == 0)
            {
                MessageBox.Show("No hay ningún registro almacenado en la base de datos.");
                return;
            }
            ctuGridPatient.SetCountPatient();
            this.ShowDialog();
            AdmPatient.ListPatient.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmShowDrug showDrug = new FrmShowDrug();
            if (showDrug.CtuGridDrug.FillGridRecipe(ctuGridPatient))
                return;
            showDrug.ShowDialog();
        }
    }
}

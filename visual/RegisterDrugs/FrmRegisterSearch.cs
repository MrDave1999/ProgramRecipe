using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    public partial class FrmRegisterSearch : Form
    {
        public FrmRegisterSearch()
        {
            InitializeComponent();
        }

		private void btnAdd_Click(object sender , EventArgs e)
		{
            FrmAddDrugs addDrug;
            if (ctuSearch.CtuGridPatientx.GetCountPatient() == 0)
            {
                MessageBox.Show("Error: La tabla está vacía.");
                return;
            }
			addDrug = new FrmAddDrugs();
            AdmRecipe.CardPatient = ctuSearch.CtuGridPatientx.GetInfoPatientRow();
            addDrug.ShowDialog();
        }
    }
}

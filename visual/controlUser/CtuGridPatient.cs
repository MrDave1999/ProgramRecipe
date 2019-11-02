using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    public partial class CtuGridPatient : UserControl
    {
        public CtuGridPatient()
        {
            InitializeComponent();
        }

        public void SetCountPatient()
        {
            lblPatient.Text = "Total de Registros: " + dgvPatient.RowCount;
        }

        public int GetCountPatient()
        {
            return dgvPatient.RowCount;
        }

        public string GetInfoPatientRow(int index = 2)
        {
            return dgvPatient.Rows[dgvPatient.CurrentRow.Index].Cells[index].Value.ToString();
        }
    }
}

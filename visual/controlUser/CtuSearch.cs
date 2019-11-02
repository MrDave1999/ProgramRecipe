using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ValidBox;

namespace ProgramRecipe
{
    partial class CtuSearch : UserControl
    {
        public CtuSearch()
        {
            InitializeComponent();
            lblEntry.Text = "Ingrese la cedula del paciente:";
            cbbSearch.SelectedIndex = 0;
        }

        private void cbbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                MessageBox.Show("Error: No se puede pegar nada en el cuadro de texto.");
        }

        private void cbbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                MessageBox.Show("Error: No se permite usar CTRL + V en el cuadro de texto.");
        }

        private void cbbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n;
            txtSearch.Clear();
            txtSearch.Focus();
            txtSearch.Type = (cbbSearch.Text == "Cedula") ? (TypeValid.Numeric) : (TypeValid.Letter);
            txtSearch.MaxLength = (cbbSearch.Text == "Cedula") ? (10) : (24);
            n = (cbbSearch.Text == "Cedula") ? ("la ") : ("el ");
            lblEntry.Text = "Ingrese " + n + cbbSearch.Text + " del paciente:";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ctuGridPatient.DgvPatient.Rows.Clear();
            if(AdmPatient.Read(cbbSearch.Text, txtSearch.Text))
                return;
            foreach (Patient pt in AdmPatient.ListPatient)
                ctuGridPatient.DgvPatient.Rows.Add(pt.Name, pt.Surname, pt.Idcard, pt.Age);
            if (AdmPatient.ListPatient.Count == 0)
            {
                MessageBox.Show("Error: No se pudo encontrar a ese paciente en la base de datos.");
                return;
            }
            ctuGridPatient.SetCountPatient();
            AdmPatient.ListPatient.Clear();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if(txtSearch.Type == TypeValid.Numeric && txtSearch.Text.Length != 10)
            {
                txtSearch.MsgError.SetError(txtSearch, "Debes ingresar 10 dígitos como máximo.");
                e.Cancel = true;
            }
        }
    }
}

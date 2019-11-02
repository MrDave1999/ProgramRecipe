using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValidBox;

namespace ProgramRecipe
{
    public partial class FrmRegisterPatient : Form
    {
        public FrmRegisterPatient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = -1;
            string[] txt = new string[4];
            ValidTextBox vtb;
            foreach(Control con in Controls)
            {
                vtb = con as ValidTextBox;
                if (vtb != null)
                {
                    if(vtb.Text.Length == 0)
                    {
                        MessageBox.Show("Debes llenar los campos vacíos!");
                        return;
                    }
                    txt[++i] = vtb.Text;
                }
            }

            if (AdmPatient.IsRepeatData("tablePatient", "Cedula", txtCard.Text))
            {
                MessageBox.Show("La cedula " + txtCard.Text + " ya lo tiene un paciente.");
                return;
            }

            if (AdmPatient.Save(txt))
                return;

            ctuGridPatient.DgvPatient.Rows.Add(txtName.Text, txtSurname.Text, txtCard.Text, txtAge.Text);
            ctuGridPatient.SetCountPatient();
            foreach (Control con in Controls)
            {
                vtb = con as ValidTextBox;
                if (vtb != null)
                    vtb.Clear();
            }
        }

        private void FrmRegisterPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtCard_Validating(object sender, CancelEventArgs e)
        {
            if(txtCard.Text.Length != 10)
            {
                txtCard.MsgError.SetError(txtCard, "Debes ingresar 10 dígitos como máximo.");
                e.Cancel = true;
            }
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            if(Valid.ValidAge(txtAge.Text))
            {
                txtAge.MsgError.SetError(txtAge, "La edad debe estar en el rango de 1 a 110 años.");
                e.Cancel = true;
            }
        }

        private void FrmRegisterPatient_Activated(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}

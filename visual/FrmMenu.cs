using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgramRecipe
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegisterPatient registerPatient = new FrmRegisterPatient();
            registerPatient.ShowDialog();
        }

        private void recetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegisterSearch registerSearch = new FrmRegisterSearch();
            registerSearch.ShowDialog();
        }
           
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchDrugs searchDrug = new FrmSearchDrugs();
            searchDrug.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateSearch updateSearch = new FrmUpdateSearch();
            updateSearch.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteSearch deleteSearch = new FrmDeleteSearch();
            deleteSearch.ShowDialog();
        }

        private void presentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowPatient showPatient = new FrmShowPatient();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

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
    public partial class CtuDrugs : UserControl
    {
        public CtuDrugs()
        {
            InitializeComponent();
            txtPrescrip.Type = (TypeValid)(-1);
            dtpDateDest.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
            dtpDateDest.MinDate = DateTime.Now;
        }

    }
}

namespace ProgramRecipe
{
    partial class FrmDrugsPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctuGridDrugs = new ProgramRecipe.CtuGridDrugs();
            this.SuspendLayout();
            // 
            // ctuGridDrugs
            // 
            this.ctuGridDrugs.Location = new System.Drawing.Point(12, 0);
            this.ctuGridDrugs.Name = "ctuGridDrugs";
            this.ctuGridDrugs.Size = new System.Drawing.Size(455, 282);
            this.ctuGridDrugs.TabIndex = 0;
            // 
            // FrmDrugsPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(470, 288);
            this.Controls.Add(this.ctuGridDrugs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDrugsPatient";
            this.Text = "Receta médica del Paciente";
            this.ResumeLayout(false);

        }

        #endregion

        private CtuGridDrugs ctuGridDrugs;

        internal CtuGridDrugs CtuGridDrug
        {
            get { return ctuGridDrugs; }
            set { ctuGridDrugs = value; }
        }
    }
}

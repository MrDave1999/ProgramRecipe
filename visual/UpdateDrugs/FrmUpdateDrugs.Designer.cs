namespace ProgramRecipe
{
    partial class FrmUpdateDrugs
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctuGridDrugs
            // 
            this.ctuGridDrugs.Location = new System.Drawing.Point(23, 12);
            this.ctuGridDrugs.Name = "ctuGridDrugs";
            this.ctuGridDrugs.Size = new System.Drawing.Size(453, 270);
            this.ctuGridDrugs.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(201, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmUpdateDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 323);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ctuGridDrugs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmUpdateDrugs";
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
        private System.Windows.Forms.Button btnUpdate;
    }
}

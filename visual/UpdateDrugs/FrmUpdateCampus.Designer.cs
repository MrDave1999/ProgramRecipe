namespace ProgramRecipe
{
    partial class FrmUpdateCampus
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
            this.ctuDrugs = new ProgramRecipe.CtuDrugs();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctuDrugs
            // 
            this.ctuDrugs.Location = new System.Drawing.Point(22, 22);
            this.ctuDrugs.Name = "ctuDrugs";
            this.ctuDrugs.Size = new System.Drawing.Size(210, 113);
            this.ctuDrugs.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmUpdateCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(264, 179);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctuDrugs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmUpdateCampus";
            this.Text = "Actualizar Campo";
            this.ResumeLayout(false);

        }

        #endregion

        private CtuDrugs ctuDrugs;
        private System.Windows.Forms.Button btnSave;
    }
}

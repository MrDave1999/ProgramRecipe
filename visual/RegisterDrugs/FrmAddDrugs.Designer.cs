namespace ProgramRecipe
{
    partial class FrmAddDrugs
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDrug = new ValidBox.ValidTextBox();
            this.ctuGridDrugs = new ProgramRecipe.CtuGridDrugs();
            this.ctuDrugs = new ProgramRecipe.CtuDrugs();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Farmaco:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(62, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDrug
            // 
            this.txtDrug.Location = new System.Drawing.Point(16, 29);
            this.txtDrug.MaxLength = 20;
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.Size = new System.Drawing.Size(100, 20);
            this.txtDrug.TabIndex = 6;
            this.txtDrug.Type = ValidBox.TypeValid.Letter;
            // 
            // ctuGridDrugs
            // 
            this.ctuGridDrugs.Location = new System.Drawing.Point(228, -29);
            this.ctuGridDrugs.Name = "ctuGridDrugs";
            this.ctuGridDrugs.Size = new System.Drawing.Size(457, 267);
            this.ctuGridDrugs.TabIndex = 3;
            // 
            // ctuDrugs
            // 
            this.ctuDrugs.Location = new System.Drawing.Point(12, 55);
            this.ctuDrugs.Name = "ctuDrugs";
            this.ctuDrugs.Size = new System.Drawing.Size(210, 113);
            this.ctuDrugs.TabIndex = 2;
            // 
            // FrmAddDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(688, 250);
            this.Controls.Add(this.txtDrug);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctuGridDrugs);
            this.Controls.Add(this.ctuDrugs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmAddDrugs";
            this.Text = "Establecer receta médica";
            this.Activated += new System.EventHandler(this.FrmAddDrugs_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CtuDrugs ctuDrugs;
        private CtuGridDrugs ctuGridDrugs;
        private System.Windows.Forms.Button btnSave;
        private ValidBox.ValidTextBox txtDrug;
    }
}

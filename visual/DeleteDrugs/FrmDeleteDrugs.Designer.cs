namespace ProgramRecipe
{
    partial class FrmDeleteDrugs
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctuGridDrugs
            // 
            this.ctuGridDrugs.Location = new System.Drawing.Point(22, 12);
            this.ctuGridDrugs.Name = "ctuGridDrugs";
            this.ctuGridDrugs.Size = new System.Drawing.Size(453, 266);
            this.ctuGridDrugs.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmDeleteDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(496, 323);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctuGridDrugs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDeleteDrugs";
            this.Text = "Eliminación de un Farmaco";
            this.ResumeLayout(false);

        }

        #endregion

        private CtuGridDrugs ctuGridDrugs;

        public CtuGridDrugs CtuGridDrug
        {
            get { return ctuGridDrugs; }
            set { ctuGridDrugs = value; }
        }
        private System.Windows.Forms.Button btnDelete;
    }
}

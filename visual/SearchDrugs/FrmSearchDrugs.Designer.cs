namespace ProgramRecipe
{
    partial class FrmSearchDrugs
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
            this.btnShowRecipe = new System.Windows.Forms.Button();
            this.ctuSearch = new ProgramRecipe.CtuSearch();
            this.SuspendLayout();
            // 
            // btnShowRecipe
            // 
            this.btnShowRecipe.Location = new System.Drawing.Point(167, 285);
            this.btnShowRecipe.Name = "btnShowRecipe";
            this.btnShowRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnShowRecipe.TabIndex = 1;
            this.btnShowRecipe.Text = "Ver Receta";
            this.btnShowRecipe.UseVisualStyleBackColor = true;
            this.btnShowRecipe.Click += new System.EventHandler(this.btnShowRecipe_Click);
            // 
            // ctuSearch
            // 
            this.ctuSearch.Location = new System.Drawing.Point(-9, -13);
            this.ctuSearch.Name = "ctuSearch";
            this.ctuSearch.Size = new System.Drawing.Size(419, 277);
            this.ctuSearch.TabIndex = 2;
            // 
            // FrmSearchDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(430, 320);
            this.Controls.Add(this.ctuSearch);
            this.Controls.Add(this.btnShowRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmSearchDrugs";
            this.Text = "Búsqueda del Paciente";
            this.Activated += new System.EventHandler(this.FrmSearchDrugs_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowRecipe;
        private CtuSearch ctuSearch;
    }
}

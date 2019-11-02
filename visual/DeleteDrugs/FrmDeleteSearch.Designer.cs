namespace ProgramRecipe
{
    partial class FrmDeleteSearch
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
            this.ctuSearch = new ProgramRecipe.CtuSearch();
            this.btnShowRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctuSearch
            // 
            this.ctuSearch.Location = new System.Drawing.Point(-2, -19);
            this.ctuSearch.Name = "ctuSearch";
            this.ctuSearch.Size = new System.Drawing.Size(478, 279);
            this.ctuSearch.TabIndex = 0;
            // 
            // btnShowRecipe
            // 
            this.btnShowRecipe.Location = new System.Drawing.Point(163, 281);
            this.btnShowRecipe.Name = "btnShowRecipe";
            this.btnShowRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnShowRecipe.TabIndex = 1;
            this.btnShowRecipe.Text = "Ver Receta";
            this.btnShowRecipe.UseVisualStyleBackColor = true;
            this.btnShowRecipe.Click += new System.EventHandler(this.btnShowRecipe_Click);
            // 
            // FrmDeleteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(426, 316);
            this.Controls.Add(this.btnShowRecipe);
            this.Controls.Add(this.ctuSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDeleteSearch";
            this.Text = "Búsqueda del Paciente";
            this.Activated += new System.EventHandler(this.FrmDeleteSearch_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private CtuSearch ctuSearch;
        private System.Windows.Forms.Button btnShowRecipe;
    }
}

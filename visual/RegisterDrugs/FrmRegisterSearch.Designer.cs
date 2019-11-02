namespace ProgramRecipe
{
    partial class FrmRegisterSearch
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctuSearch
            // 
            this.ctuSearch.Location = new System.Drawing.Point(-6, -12);
            this.ctuSearch.Name = "ctuSearch";
            this.ctuSearch.Size = new System.Drawing.Size(478, 280);
            this.ctuSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmRegisterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 320);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ctuSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmRegisterSearch";
            this.Text = "Agregar Receta";
            this.ResumeLayout(false);

        }

        #endregion

        private CtuSearch ctuSearch;
        private System.Windows.Forms.Button btnAdd;
    }
}

namespace ProgramRecipe
{
    partial class CtuSearch
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEntry = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtSearch = new ValidBox.ValidTextBox();
            this.ctuGridPatient = new ProgramRecipe.CtuGridPatient();
            this.SuspendLayout();
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Location = new System.Drawing.Point(23, 31);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(0, 13);
            this.lblEntry.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(141, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Cedula",
            "Nombre",
            "Apellido"});
            this.cbbSearch.Location = new System.Drawing.Point(273, 51);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbbSearch.TabIndex = 3;
            this.cbbSearch.SelectedIndexChanged += new System.EventHandler(this.cbbSearch_SelectedIndexChanged);
            this.cbbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbSearch_KeyDown);
            this.cbbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbSearch_KeyPress);
            this.cbbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbbSearch_MouseDown);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(270, 31);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(96, 13);
            this.lblSelect.TabIndex = 4;
            this.lblSelect.Text = "Tipo de búsqueda:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(23, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Type = ValidBox.TypeValid.Numeric;
            this.txtSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearch_Validating);
            // 
            // ctuGridPatient
            // 
            this.ctuGridPatient.Location = new System.Drawing.Point(23, 77);
            this.ctuGridPatient.Name = "ctuGridPatient";
            this.ctuGridPatient.Size = new System.Drawing.Size(444, 204);
            this.ctuGridPatient.TabIndex = 7;
            // 
            // CtuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ctuGridPatient);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEntry);
            this.Name = "CtuSearch";
            this.Size = new System.Drawing.Size(419, 277);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Label lblSelect;
        private ProgramRecipe.CtuGridPatient ctuGridPatient;
        private ValidBox.ValidTextBox txtSearch;

        public ValidBox.ValidTextBox TxtSearch
        {
            get { return txtSearch; }
            set { txtSearch = value; }
        }

        public ProgramRecipe.CtuGridPatient CtuGridPatientx
        {
            get { return ctuGridPatient; }
            set { ctuGridPatient = value; }
        }
    }
}

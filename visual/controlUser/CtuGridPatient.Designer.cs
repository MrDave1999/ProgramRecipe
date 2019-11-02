namespace ProgramRecipe
{
    partial class CtuGridPatient
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
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantDrugs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPatient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AllowUserToResizeColumns = false;
            this.dgvPatient.AllowUserToResizeRows = false;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvSurname,
            this.dgvID,
            this.dgvCantDrugs});
            this.dgvPatient.Location = new System.Drawing.Point(3, 47);
            this.dgvPatient.MultiSelect = false;
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(390, 150);
            this.dgvPatient.TabIndex = 0;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Nombre";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvSurname
            // 
            this.dgvSurname.HeaderText = "Apellido";
            this.dgvSurname.Name = "dgvSurname";
            this.dgvSurname.ReadOnly = true;
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "Cedula";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            // 
            // dgvCantDrugs
            // 
            this.dgvCantDrugs.HeaderText = "Edad";
            this.dgvCantDrugs.Name = "dgvCantDrugs";
            this.dgvCantDrugs.ReadOnly = true;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(3, 21);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(96, 13);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Total de Registros:";
            // 
            // CtuGridPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.dgvPatient);
            this.Name = "CtuGridPatient";
            this.Size = new System.Drawing.Size(396, 200);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantDrugs;
        private System.Windows.Forms.Label lblPatient;

        public System.Windows.Forms.DataGridView DgvPatient
        {
            get { return dgvPatient; }
            set { dgvPatient = value; }
        }
    }
}

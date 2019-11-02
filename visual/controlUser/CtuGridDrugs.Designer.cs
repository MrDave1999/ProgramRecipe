namespace ProgramRecipe
{
    partial class CtuGridDrugs
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
            this.dgvDrugs = new System.Windows.Forms.DataGridView();
            this.dgvDrug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDrugs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDrugs
            // 
            this.dgvDrugs.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvDrugs.AllowUserToAddRows = false;
            this.dgvDrugs.AllowUserToDeleteRows = false;
            this.dgvDrugs.AllowUserToResizeRows = false;
            this.dgvDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDrug,
            this.dgvPrescription,
            this.dgvLength,
            this.dgvDateBegin});
            this.dgvDrugs.Location = new System.Drawing.Point(13, 66);
            this.dgvDrugs.MultiSelect = false;
            this.dgvDrugs.Name = "dgvDrugs";
            this.dgvDrugs.ReadOnly = true;
            this.dgvDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugs.Size = new System.Drawing.Size(440, 198);
            this.dgvDrugs.TabIndex = 0;
            // 
            // dgvDrug
            // 
            this.dgvDrug.HeaderText = "Nombre del Farmaco";
            this.dgvDrug.Name = "dgvDrug";
            this.dgvDrug.ReadOnly = true;
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.HeaderText = "Prescripción";
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.ReadOnly = true;
            // 
            // dgvLength
            // 
            this.dgvLength.HeaderText = "Fecha de Duración";
            this.dgvLength.Name = "dgvLength";
            this.dgvLength.ReadOnly = true;
            // 
            // dgvDateBegin
            // 
            this.dgvDateBegin.HeaderText = "Fecha de envio";
            this.dgvDateBegin.Name = "dgvDateBegin";
            this.dgvDateBegin.ReadOnly = true;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(10, 17);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(52, 13);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Paciente:";
            // 
            // lblDrugs
            // 
            this.lblDrugs.AutoSize = true;
            this.lblDrugs.Location = new System.Drawing.Point(10, 40);
            this.lblDrugs.Name = "lblDrugs";
            this.lblDrugs.Size = new System.Drawing.Size(101, 13);
            this.lblDrugs.TabIndex = 2;
            this.lblDrugs.Text = "Total de Farmacos: ";
            // 
            // CtuGridDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDrugs);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.dgvDrugs);
            this.Name = "CtuGridDrugs";
            this.Size = new System.Drawing.Size(455, 266);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dgvDrugs;

        public System.Windows.Forms.DataGridView DgvDrugs
        {
            get { return dgvDrugs; }
            set { dgvDrugs = value; }
        }
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDrug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateBegin;
        private System.Windows.Forms.Label lblPatient;

        public System.Windows.Forms.Label LblPatient
        {
            get { return lblPatient; }
            set { lblPatient = value; }
        }
        private System.Windows.Forms.Label lblDrugs;

        public System.Windows.Forms.Label LblDrugs
        {
            get { return lblDrugs; }
            set { lblDrugs = value; }
        }
    }
}

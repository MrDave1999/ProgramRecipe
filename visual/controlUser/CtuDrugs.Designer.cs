namespace ProgramRecipe
{
    partial class CtuDrugs
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
            this.lblPrescription = new System.Windows.Forms.Label();
            this.lblDateSend = new System.Windows.Forms.Label();
            this.dtpDateDest = new System.Windows.Forms.DateTimePicker();
            this.txtPrescrip = new ValidBox.ValidTextBox();
            this.SuspendLayout();
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Location = new System.Drawing.Point(3, 0);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(68, 13);
            this.lblPrescription.TabIndex = 0;
            this.lblPrescription.Text = "Prescripción:";
            // 
            // lblDateSend
            // 
            this.lblDateSend.AutoSize = true;
            this.lblDateSend.Location = new System.Drawing.Point(3, 67);
            this.lblDateSend.Name = "lblDateSend";
            this.lblDateSend.Size = new System.Drawing.Size(101, 13);
            this.lblDateSend.TabIndex = 1;
            this.lblDateSend.Text = "Fecha de Duración:";
            // 
            // dtpDateDest
            // 
            this.dtpDateDest.Location = new System.Drawing.Point(6, 83);
            this.dtpDateDest.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpDateDest.MinDate = new System.DateTime(2018, 6, 15, 0, 0, 0, 0);
            this.dtpDateDest.Name = "dtpDateDest";
            this.dtpDateDest.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDest.TabIndex = 3;
            this.dtpDateDest.Value = new System.DateTime(2019, 8, 19, 16, 14, 55, 0);
            // 
            // txtPrescrip
            // 
            this.txtPrescrip.Location = new System.Drawing.Point(6, 17);
            this.txtPrescrip.MaxLength = 50;
            this.txtPrescrip.Multiline = true;
            this.txtPrescrip.Name = "txtPrescrip";
            this.txtPrescrip.Size = new System.Drawing.Size(168, 47);
            this.txtPrescrip.TabIndex = 4;
            this.txtPrescrip.Type = ValidBox.TypeValid.Decimal;
            // 
            // CtuDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPrescrip);
            this.Controls.Add(this.dtpDateDest);
            this.Controls.Add(this.lblDateSend);
            this.Controls.Add(this.lblPrescription);
            this.Name = "CtuDrugs";
            this.Size = new System.Drawing.Size(210, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.Label lblDateSend;
        private System.Windows.Forms.DateTimePicker dtpDateDest;
        private ValidBox.ValidTextBox txtPrescrip;

        public ValidBox.ValidTextBox TxtPrescription
        {
            get { return txtPrescrip; }
            set { txtPrescrip = value; }
        }

        public System.Windows.Forms.DateTimePicker DtpDateDest
        {
            get { return dtpDateDest; }
            set { dtpDateDest = value; }
        }
    }
}

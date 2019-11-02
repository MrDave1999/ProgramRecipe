namespace ProgramRecipe
{
    partial class FrmRegisterPatient
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new ValidBox.ValidTextBox();
            this.txtSurname = new ValidBox.ValidTextBox();
            this.txtCard = new ValidBox.ValidTextBox();
            this.txtAge = new ValidBox.ValidTextBox();
            this.ctuGridPatient = new ProgramRecipe.CtuGridPatient();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 69);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(47, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Apellido:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 127);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Cedula:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(286, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 26);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 178);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 13);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Edad:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 26);
            this.txtName.MaxLength = 24;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 13;
            this.txtName.Type = ValidBox.TypeValid.Letter;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(15, 86);
            this.txtSurname.MaxLength = 24;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 14;
            this.txtSurname.Type = ValidBox.TypeValid.Letter;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(15, 141);
            this.txtCard.MaxLength = 10;
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(100, 20);
            this.txtCard.TabIndex = 15;
            this.txtCard.Type = ValidBox.TypeValid.Numeric;
            this.txtCard.Validating += new System.ComponentModel.CancelEventHandler(this.txtCard_Validating);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(15, 195);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 16;
            this.txtAge.Type = ValidBox.TypeValid.Numeric;
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtAge_Validating);
            // 
            // ctuGridPatient
            // 
            this.ctuGridPatient.Location = new System.Drawing.Point(130, -9);
            this.ctuGridPatient.Name = "ctuGridPatient";
            this.ctuGridPatient.Size = new System.Drawing.Size(396, 200);
            this.ctuGridPatient.TabIndex = 17;
            // 
            // FrmRegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 239);
            this.Controls.Add(this.ctuGridPatient);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmRegisterPatient";
            this.Text = "Registro del Paciente";
            this.Activated += new System.EventHandler(this.FrmRegisterPatient_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegisterPatient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAge;
        private ValidBox.ValidTextBox txtName;
        private ValidBox.ValidTextBox txtSurname;
        private ValidBox.ValidTextBox txtCard;
        private ValidBox.ValidTextBox txtAge;
        private CtuGridPatient ctuGridPatient;
    }
}

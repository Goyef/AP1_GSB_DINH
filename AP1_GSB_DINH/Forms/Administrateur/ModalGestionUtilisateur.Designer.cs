namespace AP1_GSB_DINH.Forms.Administrateur
{
    partial class ModalGestionUtilisateur
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModAJout = new System.Windows.Forms.Label();
            this.ExitBt = new System.Windows.Forms.Button();
            this.RoleSelectLabel = new System.Windows.Forms.Label();
            this.RoleSelect = new System.Windows.Forms.ComboBox();
            this.mdpLabel = new System.Windows.Forms.Label();
            this.mdpInput = new System.Windows.Forms.TextBox();
            this.ValidateBt = new System.Windows.Forms.Button();
            this.identifiantLabel = new System.Windows.Forms.Label();
            this.NomLabel = new System.Windows.Forms.Label();
            this.IdentifiantInput = new System.Windows.Forms.TextBox();
            this.UserSelect = new System.Windows.Forms.ComboBox();
            this.NomInput = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(-7, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 15);
            this.panel2.TabIndex = 26;
            // 
            // ModAJout
            // 
            this.ModAJout.AutoSize = true;
            this.ModAJout.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModAJout.Location = new System.Drawing.Point(328, 30);
            this.ModAJout.Name = "ModAJout";
            this.ModAJout.Size = new System.Drawing.Size(210, 51);
            this.ModAJout.TabIndex = 25;
            this.ModAJout.Text = "Titre Page";
            // 
            // ExitBt
            // 
            this.ExitBt.BackColor = System.Drawing.Color.Crimson;
            this.ExitBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBt.Location = new System.Drawing.Point(790, 11);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(155, 83);
            this.ExitBt.TabIndex = 24;
            this.ExitBt.Text = "Retour";
            this.ExitBt.UseVisualStyleBackColor = false;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // RoleSelectLabel
            // 
            this.RoleSelectLabel.AutoSize = true;
            this.RoleSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleSelectLabel.Location = new System.Drawing.Point(146, 398);
            this.RoleSelectLabel.Name = "RoleSelectLabel";
            this.RoleSelectLabel.Size = new System.Drawing.Size(51, 25);
            this.RoleSelectLabel.TabIndex = 38;
            this.RoleSelectLabel.Text = "Role";
            // 
            // RoleSelect
            // 
            this.RoleSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleSelect.FormattingEnabled = true;
            this.RoleSelect.Location = new System.Drawing.Point(522, 398);
            this.RoleSelect.Name = "RoleSelect";
            this.RoleSelect.Size = new System.Drawing.Size(295, 37);
            this.RoleSelect.TabIndex = 37;
            // 
            // mdpLabel
            // 
            this.mdpLabel.AutoSize = true;
            this.mdpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpLabel.Location = new System.Drawing.Point(146, 362);
            this.mdpLabel.Name = "mdpLabel";
            this.mdpLabel.Size = new System.Drawing.Size(130, 25);
            this.mdpLabel.TabIndex = 36;
            this.mdpLabel.Text = "Mot de passe";
            // 
            // mdpInput
            // 
            this.mdpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpInput.Location = new System.Drawing.Point(522, 359);
            this.mdpInput.MaxLength = 30;
            this.mdpInput.Name = "mdpInput";
            this.mdpInput.Size = new System.Drawing.Size(295, 30);
            this.mdpInput.TabIndex = 35;
            // 
            // ValidateBt
            // 
            this.ValidateBt.BackColor = System.Drawing.Color.LimeGreen;
            this.ValidateBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBt.Location = new System.Drawing.Point(402, 490);
            this.ValidateBt.Name = "ValidateBt";
            this.ValidateBt.Size = new System.Drawing.Size(155, 83);
            this.ValidateBt.TabIndex = 34;
            this.ValidateBt.Text = "Valider";
            this.ValidateBt.UseVisualStyleBackColor = false;
            this.ValidateBt.Click += new System.EventHandler(this.Validate_Click);
            // 
            // identifiantLabel
            // 
            this.identifiantLabel.AutoSize = true;
            this.identifiantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiantLabel.Location = new System.Drawing.Point(146, 322);
            this.identifiantLabel.Name = "identifiantLabel";
            this.identifiantLabel.Size = new System.Drawing.Size(95, 25);
            this.identifiantLabel.TabIndex = 33;
            this.identifiantLabel.Text = "Identifiant";
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLabel.Location = new System.Drawing.Point(146, 233);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(212, 29);
            this.NomLabel.TabIndex = 31;
            this.NomLabel.Text = "Nom de l\'utilsateur";
            // 
            // IdentifiantInput
            // 
            this.IdentifiantInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentifiantInput.Location = new System.Drawing.Point(522, 317);
            this.IdentifiantInput.MaxLength = 30;
            this.IdentifiantInput.Name = "IdentifiantInput";
            this.IdentifiantInput.Size = new System.Drawing.Size(295, 30);
            this.IdentifiantInput.TabIndex = 30;
            // 
            // UserSelect
            // 
            this.UserSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSelect.FormattingEnabled = true;
            this.UserSelect.Location = new System.Drawing.Point(522, 163);
            this.UserSelect.Name = "UserSelect";
            this.UserSelect.Size = new System.Drawing.Size(148, 37);
            this.UserSelect.TabIndex = 29;
            this.UserSelect.Visible = false;
            this.UserSelect.TextChanged += new System.EventHandler(this.UserSelect_TextChanged);
            // 
            // NomInput
            // 
            this.NomInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomInput.Location = new System.Drawing.Point(522, 230);
            this.NomInput.MaxLength = 30;
            this.NomInput.Name = "NomInput";
            this.NomInput.Size = new System.Drawing.Size(295, 35);
            this.NomInput.TabIndex = 28;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(146, 163);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(33, 29);
            this.IdLabel.TabIndex = 40;
            this.IdLabel.Text = "Id";
            this.IdLabel.Visible = false;
            // 
            // ModalGestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 586);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.RoleSelectLabel);
            this.Controls.Add(this.RoleSelect);
            this.Controls.Add(this.mdpLabel);
            this.Controls.Add(this.mdpInput);
            this.Controls.Add(this.ValidateBt);
            this.Controls.Add(this.identifiantLabel);
            this.Controls.Add(this.NomLabel);
            this.Controls.Add(this.IdentifiantInput);
            this.Controls.Add(this.UserSelect);
            this.Controls.Add(this.NomInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ModAJout);
            this.Controls.Add(this.ExitBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalGestionUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalGestionUtilisateur";
            this.Load += new System.EventHandler(this.ModalGestionUtilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ModAJout;
        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.Label RoleSelectLabel;
        private System.Windows.Forms.ComboBox RoleSelect;
        private System.Windows.Forms.Label mdpLabel;
        private System.Windows.Forms.TextBox mdpInput;
        private System.Windows.Forms.Button ValidateBt;
        private System.Windows.Forms.Label identifiantLabel;
        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.TextBox IdentifiantInput;
        private System.Windows.Forms.ComboBox UserSelect;
        private System.Windows.Forms.TextBox NomInput;
        private System.Windows.Forms.Label IdLabel;
    }
}
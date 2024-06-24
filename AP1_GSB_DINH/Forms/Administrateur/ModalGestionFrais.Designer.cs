namespace AP1_GSB_DINH.Forms.Administrateur
{
    partial class ModalGestionFrais
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
            this.ExitBt = new System.Windows.Forms.Button();
            this.ModAjout = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ValidateBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.SumInput = new System.Windows.Forms.TextBox();
            this.UserSelect = new System.Windows.Forms.ComboBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitBt
            // 
            this.ExitBt.BackColor = System.Drawing.Color.Crimson;
            this.ExitBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBt.Location = new System.Drawing.Point(800, 12);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(155, 83);
            this.ExitBt.TabIndex = 7;
            this.ExitBt.Text = "Retour";
            this.ExitBt.UseVisualStyleBackColor = false;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // ModAjout
            // 
            this.ModAjout.AutoSize = true;
            this.ModAjout.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModAjout.Location = new System.Drawing.Point(338, 31);
            this.ModAjout.Name = "ModAjout";
            this.ModAjout.Size = new System.Drawing.Size(210, 51);
            this.ModAjout.TabIndex = 8;
            this.ModAjout.Text = "Titre Page";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 15);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "€";
            // 
            // ValidateBt
            // 
            this.ValidateBt.BackColor = System.Drawing.Color.LimeGreen;
            this.ValidateBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBt.Location = new System.Drawing.Point(369, 469);
            this.ValidateBt.Name = "ValidateBt";
            this.ValidateBt.Size = new System.Drawing.Size(155, 83);
            this.ValidateBt.TabIndex = 34;
            this.ValidateBt.Text = "Valider";
            this.ValidateBt.UseVisualStyleBackColor = false;
            this.ValidateBt.Click += new System.EventHandler(this.ValidateBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Montant";
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLabel.Location = new System.Drawing.Point(279, 230);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(153, 29);
            this.SelectLabel.TabIndex = 32;
            this.SelectLabel.Text = "Type de frais";
            this.SelectLabel.Visible = false;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(279, 176);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(149, 29);
            this.InputLabel.TabIndex = 31;
            this.InputLabel.Text = "Nom du frais";
            this.InputLabel.Visible = false;
            // 
            // SumInput
            // 
            this.SumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumInput.Location = new System.Drawing.Point(510, 354);
            this.SumInput.Name = "SumInput";
            this.SumInput.Size = new System.Drawing.Size(150, 35);
            this.SumInput.TabIndex = 30;
            this.SumInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SommeInput_KeyPress);
            // 
            // UserSelect
            // 
            this.UserSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSelect.FormattingEnabled = true;
            this.UserSelect.Location = new System.Drawing.Point(510, 227);
            this.UserSelect.Name = "UserSelect";
            this.UserSelect.Size = new System.Drawing.Size(334, 37);
            this.UserSelect.TabIndex = 29;
            this.UserSelect.Visible = false;
            this.UserSelect.TextChanged += new System.EventHandler(this.UserSelect_TextChanged);
            // 
            // UserInput
            // 
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(510, 170);
            this.UserInput.MaxLength = 50;
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(334, 35);
            this.UserInput.TabIndex = 28;
            this.UserInput.Visible = false;
            // 
            // ModalGestionFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValidateBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.SumInput);
            this.Controls.Add(this.UserSelect);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ModAjout);
            this.Controls.Add(this.ExitBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalGestionFrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ModalGestionFrais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.Label ModAjout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ValidateBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox SumInput;
        private System.Windows.Forms.ComboBox UserSelect;
        private System.Windows.Forms.TextBox UserInput;
    }
}
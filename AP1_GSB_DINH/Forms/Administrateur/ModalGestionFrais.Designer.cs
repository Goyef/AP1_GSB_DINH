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
            this.ExitBt.Location = new System.Drawing.Point(533, 8);
            this.ExitBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(103, 54);
            this.ExitBt.TabIndex = 7;
            this.ExitBt.Text = "Retour";
            this.ExitBt.UseVisualStyleBackColor = false;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // ModAjout
            // 
            this.ModAjout.AutoSize = true;
            this.ModAjout.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModAjout.Location = new System.Drawing.Point(254, 23);
            this.ModAjout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModAjout.Name = "ModAjout";
            this.ModAjout.Size = new System.Drawing.Size(95, 23);
            this.ModAjout.TabIndex = 8;
            this.ModAjout.Text = "Titre Page";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(2, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 10);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "€";
            // 
            // ValidateBt
            // 
            this.ValidateBt.BackColor = System.Drawing.Color.LimeGreen;
            this.ValidateBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBt.Location = new System.Drawing.Point(246, 305);
            this.ValidateBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValidateBt.Name = "ValidateBt";
            this.ValidateBt.Size = new System.Drawing.Size(103, 54);
            this.ValidateBt.TabIndex = 34;
            this.ValidateBt.Text = "Valider";
            this.ValidateBt.UseVisualStyleBackColor = false;
            this.ValidateBt.Click += new System.EventHandler(this.ValidateBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Montant";
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLabel.Location = new System.Drawing.Point(186, 150);
            this.SelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(99, 20);
            this.SelectLabel.TabIndex = 32;
            this.SelectLabel.Text = "Type de frais";
            this.SelectLabel.Visible = false;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(186, 114);
            this.InputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(98, 20);
            this.InputLabel.TabIndex = 31;
            this.InputLabel.Text = "Nom du frais";
            this.InputLabel.Visible = false;
            // 
            // SumInput
            // 
            this.SumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumInput.Location = new System.Drawing.Point(340, 230);
            this.SumInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SumInput.Name = "SumInput";
            this.SumInput.Size = new System.Drawing.Size(101, 26);
            this.SumInput.TabIndex = 30;
            this.SumInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SommeInput_KeyPress);
            // 
            // UserSelect
            // 
            this.UserSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSelect.FormattingEnabled = true;
            this.UserSelect.Location = new System.Drawing.Point(340, 148);
            this.UserSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserSelect.Name = "UserSelect";
            this.UserSelect.Size = new System.Drawing.Size(224, 28);
            this.UserSelect.TabIndex = 29;
            this.UserSelect.Visible = false;
            this.UserSelect.TextChanged += new System.EventHandler(this.UserSelect_TextChanged);
            // 
            // UserInput
            // 
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(340, 110);
            this.UserInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserInput.MaxLength = 50;
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(224, 26);
            this.UserInput.TabIndex = 28;
            this.UserInput.Visible = false;
            // 
            // ModalGestionFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 384);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
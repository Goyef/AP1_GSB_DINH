namespace AP1_GSB_DINH
{
    partial class AjoutHorsForfait
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitreAjouterForm = new System.Windows.Forms.Label();
            this.returnBt = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.SumInput = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.Calendar = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AjoutBt = new System.Windows.Forms.Button();
            this.DescInput = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(1, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 10);
            this.panel2.TabIndex = 14;
            // 
            // TitreAjouterForm
            // 
            this.TitreAjouterForm.AutoSize = true;
            this.TitreAjouterForm.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAjouterForm.Location = new System.Drawing.Point(183, 16);
            this.TitreAjouterForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitreAjouterForm.Name = "TitreAjouterForm";
            this.TitreAjouterForm.Size = new System.Drawing.Size(273, 23);
            this.TitreAjouterForm.TabIndex = 0;
            this.TitreAjouterForm.Text = "AJOUTER NOTE HORS-FORFAIT";
            // 
            // returnBt
            // 
            this.returnBt.BackColor = System.Drawing.Color.Crimson;
            this.returnBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBt.ForeColor = System.Drawing.Color.Black;
            this.returnBt.Location = new System.Drawing.Point(524, 5);
            this.returnBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnBt.Name = "returnBt";
            this.returnBt.Size = new System.Drawing.Size(110, 46);
            this.returnBt.TabIndex = 12;
            this.returnBt.Text = "Retour";
            this.returnBt.UseVisualStyleBackColor = false;
            this.returnBt.Click += new System.EventHandler(this.ReturnBt_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(168, 119);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(68, 19);
            this.DescriptionLabel.TabIndex = 16;
            this.DescriptionLabel.Text = "Description";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumLabel.Location = new System.Drawing.Point(168, 159);
            this.SumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(53, 19);
            this.SumLabel.TabIndex = 17;
            this.SumLabel.Text = "Montant";
            // 
            // SumInput
            // 
            this.SumInput.Location = new System.Drawing.Point(363, 159);
            this.SumInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SumInput.MaxLength = 20;
            this.SumInput.Multiline = true;
            this.SumInput.Name = "SumInput";
            this.SumInput.Size = new System.Drawing.Size(135, 18);
            this.SumInput.TabIndex = 18;
            this.SumInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumInput_KeyPress);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(363, 210);
            this.Calendar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(135, 20);
            this.Calendar.TabIndex = 19;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(168, 210);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 19);
            this.DateLabel.TabIndex = 20;
            this.DateLabel.Text = "Date";
            // 
            // AjoutBt
            // 
            this.AjoutBt.BackColor = System.Drawing.Color.LimeGreen;
            this.AjoutBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutBt.Location = new System.Drawing.Point(265, 310);
            this.AjoutBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AjoutBt.Name = "AjoutBt";
            this.AjoutBt.Size = new System.Drawing.Size(110, 46);
            this.AjoutBt.TabIndex = 21;
            this.AjoutBt.Text = "VALIDER";
            this.AjoutBt.UseVisualStyleBackColor = false;
            this.AjoutBt.Click += new System.EventHandler(this.AjoutBt_Click);
            // 
            // DescInput
            // 
            this.DescInput.Location = new System.Drawing.Point(363, 119);
            this.DescInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescInput.MaxLength = 50;
            this.DescInput.Multiline = true;
            this.DescInput.Name = "DescInput";
            this.DescInput.Size = new System.Drawing.Size(135, 18);
            this.DescInput.TabIndex = 22;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AjoutHorsForfait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 394);
            this.Controls.Add(this.TitreAjouterForm);
            this.Controls.Add(this.DescInput);
            this.Controls.Add(this.AjoutBt);
            this.Controls.Add(this.returnBt);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.SumInput);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AjoutHorsForfait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AjoutHorsForfait_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TitreAjouterForm;
        private System.Windows.Forms.Button returnBt;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.TextBox SumInput;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DateTimePicker Calendar;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button AjoutBt;
        private System.Windows.Forms.TextBox DescInput;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
namespace AP1_GSB_DINH.Forms
{
    partial class ComptableForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deconnexion = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchUser = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Deconnexion);
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.TypeLabel);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 43);
            this.panel1.TabIndex = 5;
            // 
            // Deconnexion
            // 
            this.Deconnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deconnexion.BackColor = System.Drawing.Color.Red;
            this.Deconnexion.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconnexion.Location = new System.Drawing.Point(634, 5);
            this.Deconnexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(107, 36);
            this.Deconnexion.TabIndex = 5;
            this.Deconnexion.Text = "Deconnextion";
            this.Deconnexion.UseVisualStyleBackColor = false;
            this.Deconnexion.Click += new System.EventHandler(this.Exit);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(8, 12);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(68, 17);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "NomUser";
            // 
            // TypeLabel
            // 
            this.TypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TypeLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(251, 7);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(118, 23);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "COMPTABLE";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(373, 9);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(43, 19);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.SearchUser);
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 397);
            this.panel2.TabIndex = 6;
            // 
            // SearchUser
            // 
            this.SearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchUser.Location = new System.Drawing.Point(-2, 65);
            this.SearchUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(104, 40);
            this.SearchUser.TabIndex = 1;
            this.SearchUser.Text = "Afficher Fiches";
            this.SearchUser.UseVisualStyleBackColor = true;
            this.SearchUser.Click += new System.EventHandler(this.ShowFiches);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(105, 49);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(649, 390);
            this.mainPanel.TabIndex = 7;
            // 
            // ComptableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 440);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ComptableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ComptableForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Deconnexion;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchUser;
        private System.Windows.Forms.Panel mainPanel;
    }
}
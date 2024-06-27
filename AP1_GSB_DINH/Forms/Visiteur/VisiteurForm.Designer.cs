namespace AP1_GSB_DINH
{
    partial class VisiteurForm
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.HistoriqueBt = new System.Windows.Forms.Button();
            this.ConsulterBt = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deconnexion = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AjouterBt = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // HistoriqueBt
            // 
            this.HistoriqueBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoriqueBt.Location = new System.Drawing.Point(2, 86);
            this.HistoriqueBt.Margin = new System.Windows.Forms.Padding(2);
            this.HistoriqueBt.Name = "HistoriqueBt";
            this.HistoriqueBt.Size = new System.Drawing.Size(97, 40);
            this.HistoriqueBt.TabIndex = 1;
            this.HistoriqueBt.Text = "Consulter historique";
            this.HistoriqueBt.UseVisualStyleBackColor = true;
            this.HistoriqueBt.Click += new System.EventHandler(this.Historique_click);
            // 
            // ConsulterBt
            // 
            this.ConsulterBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsulterBt.Location = new System.Drawing.Point(4, 254);
            this.ConsulterBt.Margin = new System.Windows.Forms.Padding(2);
            this.ConsulterBt.Name = "ConsulterBt";
            this.ConsulterBt.Size = new System.Drawing.Size(95, 40);
            this.ConsulterBt.TabIndex = 2;
            this.ConsulterBt.Text = "Consulter page actuelle";
            this.ConsulterBt.UseVisualStyleBackColor = true;
            this.ConsulterBt.Click += new System.EventHandler(this.Consulter_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.Deconnexion);
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.TypeLabel);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 43);
            this.panel1.TabIndex = 4;
            // 
            // Deconnexion
            // 
            this.Deconnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deconnexion.BackColor = System.Drawing.Color.Red;
            this.Deconnexion.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconnexion.Location = new System.Drawing.Point(646, 9);
            this.Deconnexion.Margin = new System.Windows.Forms.Padding(2);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(98, 27);
            this.Deconnexion.TabIndex = 5;
            this.Deconnexion.Text = "Deconnextion";
            this.Deconnexion.UseVisualStyleBackColor = false;
            this.Deconnexion.Click += new System.EventHandler(this.Exit);
            // 
            // TypeLabel
            // 
            this.TypeLabel.BackColor = System.Drawing.Color.White;
            this.TypeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(299, 9);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(70, 23);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "VISITEUR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.AjouterBt);
            this.panel2.Controls.Add(this.ConsulterBt);
            this.panel2.Controls.Add(this.HistoriqueBt);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 403);
            this.panel2.TabIndex = 5;
            // 
            // AjouterBt
            // 
            this.AjouterBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AjouterBt.Location = new System.Drawing.Point(4, 170);
            this.AjouterBt.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterBt.Name = "AjouterBt";
            this.AjouterBt.Size = new System.Drawing.Size(95, 40);
            this.AjouterBt.TabIndex = 3;
            this.AjouterBt.Text = "Ajouter frais";
            this.AjouterBt.UseVisualStyleBackColor = true;
            this.AjouterBt.Click += new System.EventHandler(this.Ajout_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(103, 46);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(649, 395);
            this.mainPanel.TabIndex = 6;
            // 
            // VisiteurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 440);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisiteurForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "window";
            this.Load += new System.EventHandler(this.Visiteur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button HistoriqueBt;
        private System.Windows.Forms.Button ConsulterBt;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button Deconnexion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AjouterBt;
        private System.Windows.Forms.Panel mainPanel;
    }
}
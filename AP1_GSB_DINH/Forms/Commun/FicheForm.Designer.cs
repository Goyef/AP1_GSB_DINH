namespace AP1_GSB_DINH
{
    partial class FicheForm
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
            this.TitreLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MoisLabel = new System.Windows.Forms.Label();
            this.ForfaitLabel = new System.Windows.Forms.Label();
            this.HorsForfaitLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SumLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.AnneeLabel = new System.Windows.Forms.Label();
            this.ExitBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreLabel
            // 
            this.TitreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitreLabel.AutoSize = true;
            this.TitreLabel.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLabel.Location = new System.Drawing.Point(324, 8);
            this.TitreLabel.Name = "TitreLabel";
            this.TitreLabel.Size = new System.Drawing.Size(229, 34);
            this.TitreLabel.TabIndex = 1;
            this.TitreLabel.Text = "Fiche du mois de";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 15);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(441, 241);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // MoisLabel
            // 
            this.MoisLabel.AutoSize = true;
            this.MoisLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoisLabel.Location = new System.Drawing.Point(324, 43);
            this.MoisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoisLabel.Name = "MoisLabel";
            this.MoisLabel.Size = new System.Drawing.Size(49, 29);
            this.MoisLabel.TabIndex = 0;
            this.MoisLabel.Text = "Mois";
            // 
            // ForfaitLabel
            // 
            this.ForfaitLabel.AutoSize = true;
            this.ForfaitLabel.Location = new System.Drawing.Point(9, 110);
            this.ForfaitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForfaitLabel.Name = "ForfaitLabel";
            this.ForfaitLabel.Size = new System.Drawing.Size(89, 20);
            this.ForfaitLabel.TabIndex = 16;
            this.ForfaitLabel.Text = "Frais forfait";
            // 
            // HorsForfaitLabel
            // 
            this.HorsForfaitLabel.AutoSize = true;
            this.HorsForfaitLabel.Location = new System.Drawing.Point(831, 110);
            this.HorsForfaitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HorsForfaitLabel.Name = "HorsForfaitLabel";
            this.HorsForfaitLabel.Size = new System.Drawing.Size(124, 20);
            this.HorsForfaitLabel.TabIndex = 17;
            this.HorsForfaitLabel.Text = "Frais hors forfait";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(558, 135);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(397, 241);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(451, 408);
            this.SumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(64, 20);
            this.SumLabel.TabIndex = 19;
            this.SumLabel.Text = "Somme";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(329, 445);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.Size = new System.Drawing.Size(303, 83);
            this.dataGridView3.TabIndex = 20;
            this.dataGridView3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView3_CellFormatting);
            // 
            // AnneeLabel
            // 
            this.AnneeLabel.AutoSize = true;
            this.AnneeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeLabel.Location = new System.Drawing.Point(504, 43);
            this.AnneeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnneeLabel.Name = "AnneeLabel";
            this.AnneeLabel.Size = new System.Drawing.Size(72, 29);
            this.AnneeLabel.TabIndex = 21;
            this.AnneeLabel.Text = "Annnee";
            // 
            // ExitBt
            // 
            this.ExitBt.BackColor = System.Drawing.Color.Red;
            this.ExitBt.Enabled = false;
            this.ExitBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitBt.Location = new System.Drawing.Point(801, 14);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(143, 55);
            this.ExitBt.TabIndex = 22;
            this.ExitBt.Text = "EXIT";
            this.ExitBt.UseVisualStyleBackColor = false;
            this.ExitBt.Visible = false;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // FicheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 606);
            this.Controls.Add(this.ExitBt);
            this.Controls.Add(this.AnneeLabel);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.HorsForfaitLabel);
            this.Controls.Add(this.ForfaitLabel);
            this.Controls.Add(this.MoisLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FicheForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FicheForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitreLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label MoisLabel;
        private System.Windows.Forms.Label ForfaitLabel;
        private System.Windows.Forms.Label HorsForfaitLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label AnneeLabel;
        private System.Windows.Forms.Button ExitBt;
    }
}
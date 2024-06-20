namespace AP1_GSB_DINH.Forms
{
    partial class AfficherVisiteur
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
            this.TitreListUtilisateur = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserSelect = new System.Windows.Forms.ComboBox();
            this.DetailBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(3, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 14);
            this.panel2.TabIndex = 14;
            // 
            // TitreListUtilisateur
            // 
            this.TitreListUtilisateur.AutoSize = true;
            this.TitreListUtilisateur.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreListUtilisateur.Location = new System.Drawing.Point(289, 34);
            this.TitreListUtilisateur.Name = "TitreListUtilisateur";
            this.TitreListUtilisateur.Size = new System.Drawing.Size(341, 34);
            this.TitreListUtilisateur.TabIndex = 15;
            this.TitreListUtilisateur.Text = "Veuillez choisir le visiteur";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(933, 400);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateEtat);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CurrencyFormatting);
            // 
            // UserSelect
            // 
            this.UserSelect.FormattingEnabled = true;
            this.UserSelect.Location = new System.Drawing.Point(128, 136);
            this.UserSelect.Name = "UserSelect";
            this.UserSelect.Size = new System.Drawing.Size(226, 28);
            this.UserSelect.TabIndex = 17;
            this.UserSelect.TextChanged += new System.EventHandler(this.UserSelect_TextChanged);
            // 
            // DetailBt
            // 
            this.DetailBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetailBt.Location = new System.Drawing.Point(647, 118);
            this.DetailBt.Name = "DetailBt";
            this.DetailBt.Size = new System.Drawing.Size(142, 62);
            this.DetailBt.TabIndex = 18;
            this.DetailBt.Text = "Detail";
            this.DetailBt.UseVisualStyleBackColor = true;
            this.DetailBt.Click += new System.EventHandler(this.DeatilClick);
            // 
            // AfficherVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 605);
            this.Controls.Add(this.DetailBt);
            this.Controls.Add(this.UserSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TitreListUtilisateur);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficherVisiteur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AfficherVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TitreListUtilisateur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox UserSelect;
        private System.Windows.Forms.Button DetailBt;
    }
}
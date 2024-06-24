namespace AP1_GSB_DINH.Forms.Administrateur
{
    partial class GestionUtilisateur
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
            this.TitreGestion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ModifierBt = new System.Windows.Forms.Button();
            this.AjouterBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreGestion
            // 
            this.TitreGestion.AutoSize = true;
            this.TitreGestion.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreGestion.Location = new System.Drawing.Point(287, 22);
            this.TitreGestion.Name = "TitreGestion";
            this.TitreGestion.Size = new System.Drawing.Size(308, 34);
            this.TitreGestion.TabIndex = 18;
            this.TitreGestion.Text = "Gestion des utilsateurs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(1, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 21);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(555, 338);
            this.dataGridView1.TabIndex = 22;
            // 
            // ModifierBt
            // 
            this.ModifierBt.Location = new System.Drawing.Point(145, 322);
            this.ModifierBt.Name = "ModifierBt";
            this.ModifierBt.Size = new System.Drawing.Size(134, 48);
            this.ModifierBt.TabIndex = 21;
            this.ModifierBt.Text = "Modifier";
            this.ModifierBt.UseVisualStyleBackColor = true;
            this.ModifierBt.Click += new System.EventHandler(this.ModifierBt_Click);
            // 
            // AjouterBt
            // 
            this.AjouterBt.Location = new System.Drawing.Point(145, 150);
            this.AjouterBt.Name = "AjouterBt";
            this.AjouterBt.Size = new System.Drawing.Size(134, 48);
            this.AjouterBt.TabIndex = 20;
            this.AjouterBt.Text = "Ajouter";
            this.AjouterBt.UseVisualStyleBackColor = true;
            this.AjouterBt.Click += new System.EventHandler(this.AjouterBt_Click);
            // 
            // GestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ModifierBt);
            this.Controls.Add(this.AjouterBt);
            this.Controls.Add(this.TitreGestion);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionUtilisateur";
            this.Load += new System.EventHandler(this.GestionUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreGestion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ModifierBt;
        private System.Windows.Forms.Button AjouterBt;
    }
}
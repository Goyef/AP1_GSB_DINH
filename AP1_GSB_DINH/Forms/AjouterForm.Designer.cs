namespace AP1_GSB_DINH
{
    partial class AjouterForm
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
            this.TitreAjouterForm = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ForfaitBt = new System.Windows.Forms.Button();
            this.HorsForfaitBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 14);
            this.panel2.TabIndex = 13;
            // 
            // TitreAjouterForm
            // 
            this.TitreAjouterForm.AutoSize = true;
            this.TitreAjouterForm.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAjouterForm.Location = new System.Drawing.Point(213, 14);
            this.TitreAjouterForm.Name = "TitreAjouterForm";
            this.TitreAjouterForm.Size = new System.Drawing.Size(520, 35);
            this.TitreAjouterForm.TabIndex = 0;
            this.TitreAjouterForm.Text = "CHOSIR LE TYPE DE FRAIS A AJOUTER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(678, 151);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(273, 395);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(678, 151);
            this.dataGridView2.TabIndex = 15;
            // 
            // ForfaitBt
            // 
            this.ForfaitBt.Location = new System.Drawing.Point(76, 116);
            this.ForfaitBt.Name = "ForfaitBt";
            this.ForfaitBt.Size = new System.Drawing.Size(144, 78);
            this.ForfaitBt.TabIndex = 16;
            this.ForfaitBt.Text = "Ajouter une note forfait";
            this.ForfaitBt.UseVisualStyleBackColor = true;
            this.ForfaitBt.Click += new System.EventHandler(this.RedirectionF);
            // 
            // HorsForfaitBt
            // 
            this.HorsForfaitBt.Location = new System.Drawing.Point(76, 395);
            this.HorsForfaitBt.Name = "HorsForfaitBt";
            this.HorsForfaitBt.Size = new System.Drawing.Size(144, 78);
            this.HorsForfaitBt.TabIndex = 17;
            this.HorsForfaitBt.Text = "Ajouter une note hors forfait";
            this.HorsForfaitBt.UseVisualStyleBackColor = true;
            this.HorsForfaitBt.Click += new System.EventHandler(this.RedirectionHorsF);
            // 
            // AjouterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 606);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TitreAjouterForm);
            this.Controls.Add(this.HorsForfaitBt);
            this.Controls.Add(this.ForfaitBt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AjouterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TitreAjouterForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ForfaitBt;
        private System.Windows.Forms.Button HorsForfaitBt;
    }
}
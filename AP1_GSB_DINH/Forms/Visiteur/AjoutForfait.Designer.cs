namespace AP1_GSB_DINH
{
    partial class AjouterForfait
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
            this.SelectLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitreAjouterForm = new System.Windows.Forms.Label();
            this.returnBt = new System.Windows.Forms.Button();
            this.TypeSelect = new System.Windows.Forms.ComboBox();
            this.Calendar = new System.Windows.Forms.DateTimePicker();
            this.AjoutBt = new System.Windows.Forms.Button();
            this.QuantiteInput = new System.Windows.Forms.NumericUpDown();
            this.QuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteInput)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectLabel
            // 
            this.SelectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLabel.Location = new System.Drawing.Point(163, 120);
            this.SelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(75, 19);
            this.SelectLabel.TabIndex = 1;
            this.SelectLabel.Text = "Type de frais";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(163, 205);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 19);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 7);
            this.panel2.TabIndex = 14;
            // 
            // TitreAjouterForm
            // 
            this.TitreAjouterForm.AutoSize = true;
            this.TitreAjouterForm.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAjouterForm.Location = new System.Drawing.Point(207, 16);
            this.TitreAjouterForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitreAjouterForm.Name = "TitreAjouterForm";
            this.TitreAjouterForm.Size = new System.Drawing.Size(215, 23);
            this.TitreAjouterForm.TabIndex = 0;
            this.TitreAjouterForm.Text = "AJOUTER NOTE FORFAIT";
            // 
            // returnBt
            // 
            this.returnBt.BackColor = System.Drawing.Color.Crimson;
            this.returnBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBt.ForeColor = System.Drawing.Color.Black;
            this.returnBt.Location = new System.Drawing.Point(524, 3);
            this.returnBt.Margin = new System.Windows.Forms.Padding(2);
            this.returnBt.Name = "returnBt";
            this.returnBt.Size = new System.Drawing.Size(110, 45);
            this.returnBt.TabIndex = 12;
            this.returnBt.Text = "Retour";
            this.returnBt.UseVisualStyleBackColor = false;
            this.returnBt.Click += new System.EventHandler(this.ReturnBt_Click);
            // 
            // TypeSelect
            // 
            this.TypeSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSelect.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeSelect.FormattingEnabled = true;
            this.TypeSelect.Location = new System.Drawing.Point(342, 114);
            this.TypeSelect.Margin = new System.Windows.Forms.Padding(2);
            this.TypeSelect.Name = "TypeSelect";
            this.TypeSelect.Size = new System.Drawing.Size(135, 27);
            this.TypeSelect.TabIndex = 15;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(342, 205);
            this.Calendar.Margin = new System.Windows.Forms.Padding(2);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(135, 20);
            this.Calendar.TabIndex = 16;
            // 
            // AjoutBt
            // 
            this.AjoutBt.BackColor = System.Drawing.Color.LimeGreen;
            this.AjoutBt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutBt.Location = new System.Drawing.Point(255, 304);
            this.AjoutBt.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutBt.Name = "AjoutBt";
            this.AjoutBt.Size = new System.Drawing.Size(110, 46);
            this.AjoutBt.TabIndex = 22;
            this.AjoutBt.Text = "VALIDER";
            this.AjoutBt.UseVisualStyleBackColor = false;
            this.AjoutBt.Click += new System.EventHandler(this.AjoutBt_Click);
            // 
            // QuantiteInput
            // 
            this.QuantiteInput.Location = new System.Drawing.Point(342, 161);
            this.QuantiteInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantiteInput.Name = "QuantiteInput";
            this.QuantiteInput.Size = new System.Drawing.Size(135, 20);
            this.QuantiteInput.TabIndex = 23;
            this.QuantiteInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantiteInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantite_KeyPress);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(163, 162);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(54, 19);
            this.QuantityLabel.TabIndex = 24;
            this.QuantityLabel.Text = "Quantité";
            // 
            // AjouterForfait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 394);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantiteInput);
            this.Controls.Add(this.AjoutBt);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.TypeSelect);
            this.Controls.Add(this.returnBt);
            this.Controls.Add(this.TitreAjouterForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SelectLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AjouterForfait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutFrais";
            this.Load += new System.EventHandler(this.AjouterForfait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TitreAjouterForm;
        private System.Windows.Forms.Button returnBt;
        private System.Windows.Forms.ComboBox TypeSelect;
        private System.Windows.Forms.DateTimePicker Calendar;
        private System.Windows.Forms.Button AjoutBt;
        private System.Windows.Forms.NumericUpDown QuantiteInput;
        private System.Windows.Forms.Label QuantityLabel;
    }
}
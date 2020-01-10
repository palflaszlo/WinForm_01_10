namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.marka = new System.Windows.Forms.Label();
            this.tipus = new System.Windows.Forms.Label();
            this.ar = new System.Windows.Forms.Label();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.tb_marka = new System.Windows.Forms.TextBox();
            this.telefon_felvetel = new System.Windows.Forms.Button();
            this.nud_ar = new System.Windows.Forms.NumericUpDown();
            this.adatmodositas = new System.Windows.Forms.Button();
            this.telefon_torlese = new System.Windows.Forms.Button();
            this.dataGridView_Telefonok = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Telefonok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefon_torlese);
            this.groupBox1.Controls.Add(this.adatmodositas);
            this.groupBox1.Controls.Add(this.nud_ar);
            this.groupBox1.Controls.Add(this.telefon_felvetel);
            this.groupBox1.Controls.Add(this.tb_marka);
            this.groupBox1.Controls.Add(this.tb_tipus);
            this.groupBox1.Controls.Add(this.ar);
            this.groupBox1.Controls.Add(this.tipus);
            this.groupBox1.Controls.Add(this.marka);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott telefon adatai";
            // 
            // marka
            // 
            this.marka.AutoSize = true;
            this.marka.Location = new System.Drawing.Point(19, 20);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(37, 13);
            this.marka.TabIndex = 0;
            this.marka.Text = "Márka";
            // 
            // tipus
            // 
            this.tipus.AutoSize = true;
            this.tipus.Location = new System.Drawing.Point(155, 20);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(35, 13);
            this.tipus.TabIndex = 1;
            this.tipus.Text = "Típus";
            // 
            // ar
            // 
            this.ar.AutoSize = true;
            this.ar.Location = new System.Drawing.Point(282, 20);
            this.ar.Name = "ar";
            this.ar.Size = new System.Drawing.Size(17, 13);
            this.ar.TabIndex = 2;
            this.ar.Text = "Ár";
            this.ar.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(144, 36);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(100, 20);
            this.tb_tipus.TabIndex = 4;
            // 
            // tb_marka
            // 
            this.tb_marka.Location = new System.Drawing.Point(22, 36);
            this.tb_marka.Name = "tb_marka";
            this.tb_marka.Size = new System.Drawing.Size(100, 20);
            this.tb_marka.TabIndex = 5;
            // 
            // telefon_felvetel
            // 
            this.telefon_felvetel.Location = new System.Drawing.Point(22, 85);
            this.telefon_felvetel.Name = "telefon_felvetel";
            this.telefon_felvetel.Size = new System.Drawing.Size(100, 23);
            this.telefon_felvetel.TabIndex = 6;
            this.telefon_felvetel.Text = "Új telefon";
            this.telefon_felvetel.UseVisualStyleBackColor = true;
            // 
            // nud_ar
            // 
            this.nud_ar.Location = new System.Drawing.Point(268, 36);
            this.nud_ar.Name = "nud_ar";
            this.nud_ar.Size = new System.Drawing.Size(120, 20);
            this.nud_ar.TabIndex = 7;
            // 
            // adatmodositas
            // 
            this.adatmodositas.Location = new System.Drawing.Point(144, 85);
            this.adatmodositas.Name = "adatmodositas";
            this.adatmodositas.Size = new System.Drawing.Size(100, 23);
            this.adatmodositas.TabIndex = 8;
            this.adatmodositas.Text = "Adatmódosítás";
            this.adatmodositas.UseVisualStyleBackColor = true;
            // 
            // telefon_torlese
            // 
            this.telefon_torlese.Location = new System.Drawing.Point(268, 85);
            this.telefon_torlese.Name = "telefon_torlese";
            this.telefon_torlese.Size = new System.Drawing.Size(120, 23);
            this.telefon_torlese.TabIndex = 9;
            this.telefon_torlese.Text = "telefon törlése";
            this.telefon_torlese.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Telefonok
            // 
            this.dataGridView_Telefonok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Telefonok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Telefonok.Location = new System.Drawing.Point(0, 171);
            this.dataGridView_Telefonok.Name = "dataGridView_Telefonok";
            this.dataGridView_Telefonok.Size = new System.Drawing.Size(462, 150);
            this.dataGridView_Telefonok.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 321);
            this.Controls.Add(this.dataGridView_Telefonok);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Telefonok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button telefon_torlese;
        private System.Windows.Forms.Button adatmodositas;
        private System.Windows.Forms.NumericUpDown nud_ar;
        private System.Windows.Forms.Button telefon_felvetel;
        private System.Windows.Forms.TextBox tb_marka;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.Label ar;
        private System.Windows.Forms.Label tipus;
        private System.Windows.Forms.Label marka;
        private System.Windows.Forms.DataGridView dataGridView_Telefonok;
    }
}


namespace GamesRoomApp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dptOd = new System.Windows.Forms.DateTimePicker();
            this.dptDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtTrida = new System.Windows.Forms.TextBox();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.btn_vytvorit = new System.Windows.Forms.Button();
            this.btn_smazat = new System.Windows.Forms.Button();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.lblTrida = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dptOd
            // 
            this.dptOd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dptOd.Location = new System.Drawing.Point(12, 101);
            this.dptOd.Name = "dptOd";
            this.dptOd.Size = new System.Drawing.Size(98, 20);
            this.dptOd.TabIndex = 1;
            this.dptOd.ValueChanged += new System.EventHandler(this.dptOd_ValueChanged);
            // 
            // dptDo
            // 
            this.dptDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dptDo.Location = new System.Drawing.Point(116, 101);
            this.dptDo.Name = "dptDo";
            this.dptDo.Size = new System.Drawing.Size(96, 20);
            this.dptDo.TabIndex = 2;
            this.dptDo.ValueChanged += new System.EventHandler(this.dptDo_ValueChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(12, 61);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 3;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // txtTrida
            // 
            this.txtTrida.Location = new System.Drawing.Point(163, 22);
            this.txtTrida.Name = "txtTrida";
            this.txtTrida.Size = new System.Drawing.Size(49, 20);
            this.txtTrida.TabIndex = 5;
            this.txtTrida.TextChanged += new System.EventHandler(this.txtTrida_TextChanged);
            // 
            // txtJmeno
            // 
            this.txtJmeno.Location = new System.Drawing.Point(12, 22);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(145, 20);
            this.txtJmeno.TabIndex = 6;
            this.txtJmeno.TextChanged += new System.EventHandler(this.txtJmeno_TextChanged);
            // 
            // btn_vytvorit
            // 
            this.btn_vytvorit.Location = new System.Drawing.Point(116, 127);
            this.btn_vytvorit.Name = "btn_vytvorit";
            this.btn_vytvorit.Size = new System.Drawing.Size(98, 23);
            this.btn_vytvorit.TabIndex = 7;
            this.btn_vytvorit.Text = "Vytvořit";
            this.btn_vytvorit.UseVisualStyleBackColor = true;
            this.btn_vytvorit.Click += new System.EventHandler(this.btn_vytvorit_Click);
            // 
            // btn_smazat
            // 
            this.btn_smazat.Location = new System.Drawing.Point(12, 127);
            this.btn_smazat.Name = "btn_smazat";
            this.btn_smazat.Size = new System.Drawing.Size(98, 23);
            this.btn_smazat.TabIndex = 8;
            this.btn_smazat.Text = "Smazat";
            this.btn_smazat.UseVisualStyleBackColor = true;
            this.btn_smazat.Click += new System.EventHandler(this.btn_smazat_Click);
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(9, 6);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(81, 13);
            this.lblJmeno.TabIndex = 9;
            this.lblJmeno.Text = "Jméno příjmení";
            // 
            // lblTrida
            // 
            this.lblTrida.AutoSize = true;
            this.lblTrida.Location = new System.Drawing.Point(160, 6);
            this.lblTrida.Name = "lblTrida";
            this.lblTrida.Size = new System.Drawing.Size(34, 13);
            this.lblTrida.TabIndex = 10;
            this.lblTrida.Text = "Třída";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(9, 84);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(24, 13);
            this.lblOd.TabIndex = 11;
            this.lblOd.Text = "Od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(113, 84);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(24, 13);
            this.lblDo.TabIndex = 12;
            this.lblDo.Text = "Do:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(9, 45);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "Datum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.lblTrida);
            this.Controls.Add(this.lblJmeno);
            this.Controls.Add(this.btn_smazat);
            this.Controls.Add(this.btn_vytvorit);
            this.Controls.Add(this.txtJmeno);
            this.Controls.Add(this.txtTrida);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.dptDo);
            this.Controls.Add(this.dptOd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dptOd;
        private System.Windows.Forms.DateTimePicker dptDo;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtTrida;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.Button btn_vytvorit;
        private System.Windows.Forms.Button btn_smazat;
        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.Label lblTrida;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblDatum;
    }
}


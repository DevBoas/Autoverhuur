namespace Autoverhuur
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
            this.Kilometers = new System.Windows.Forms.TextBox();
            this.Km = new System.Windows.Forms.Label();
            this.TotDatum = new System.Windows.Forms.DateTimePicker();
            this.VanDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioAuto = new System.Windows.Forms.RadioButton();
            this.radioBus = new System.Windows.Forms.RadioButton();
            this.Bereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kilometers
            // 
            this.Kilometers.Location = new System.Drawing.Point(98, 63);
            this.Kilometers.Name = "Kilometers";
            this.Kilometers.Size = new System.Drawing.Size(100, 20);
            this.Kilometers.TabIndex = 0;
            // 
            // Km
            // 
            this.Km.AutoSize = true;
            this.Km.Location = new System.Drawing.Point(30, 66);
            this.Km.Name = "Km";
            this.Km.Size = new System.Drawing.Size(68, 13);
            this.Km.TabIndex = 1;
            this.Km.Text = "Gereden km:";
            this.Km.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotDatum
            // 
            this.TotDatum.Location = new System.Drawing.Point(98, 36);
            this.TotDatum.Name = "TotDatum";
            this.TotDatum.Size = new System.Drawing.Size(200, 20);
            this.TotDatum.TabIndex = 2;
            // 
            // VanDatum
            // 
            this.VanDatum.Location = new System.Drawing.Point(98, 12);
            this.VanDatum.Name = "VanDatum";
            this.VanDatum.Size = new System.Drawing.Size(200, 20);
            this.VanDatum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Begin Datum:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eind Datum:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioAuto
            // 
            this.radioAuto.AutoSize = true;
            this.radioAuto.Checked = true;
            this.radioAuto.Location = new System.Drawing.Point(98, 89);
            this.radioAuto.Name = "radioAuto";
            this.radioAuto.Size = new System.Drawing.Size(95, 17);
            this.radioAuto.TabIndex = 7;
            this.radioAuto.TabStop = true;
            this.radioAuto.Text = "Personen Auto";
            this.radioAuto.UseVisualStyleBackColor = true;
            // 
            // radioBus
            // 
            this.radioBus.AutoSize = true;
            this.radioBus.Location = new System.Drawing.Point(98, 112);
            this.radioBus.Name = "radioBus";
            this.radioBus.Size = new System.Drawing.Size(99, 17);
            this.radioBus.TabIndex = 8;
            this.radioBus.Text = "Personen Busje";
            this.radioBus.UseVisualStyleBackColor = true;
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(98, 135);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(75, 23);
            this.Bereken.TabIndex = 9;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 292);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.radioBus);
            this.Controls.Add(this.radioAuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VanDatum);
            this.Controls.Add(this.TotDatum);
            this.Controls.Add(this.Km);
            this.Controls.Add(this.Kilometers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Kilometers;
        private System.Windows.Forms.Label Km;
        private System.Windows.Forms.DateTimePicker TotDatum;
        private System.Windows.Forms.DateTimePicker VanDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAuto;
        private System.Windows.Forms.RadioButton radioBus;
        private System.Windows.Forms.Button Bereken;
    }
}


namespace Buchung
{
    partial class Eingabe
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
            this.l_grund = new System.Windows.Forms.Label();
            this.l_datum = new System.Windows.Forms.Label();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.l_wert = new System.Windows.Forms.Label();
            this.tb_wert = new System.Windows.Forms.TextBox();
            this.tb_grund = new System.Windows.Forms.TextBox();
            this.rb_einnahmen = new System.Windows.Forms.RadioButton();
            this.rb_ausgaben = new System.Windows.Forms.RadioButton();
            this.b_zurück = new System.Windows.Forms.Button();
            this.b_speichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_grund
            // 
            this.l_grund.AutoSize = true;
            this.l_grund.Location = new System.Drawing.Point(12, 9);
            this.l_grund.Name = "l_grund";
            this.l_grund.Size = new System.Drawing.Size(100, 13);
            this.l_grund.TabIndex = 0;
            this.l_grund.Text = "Grund der Buchung";
            // 
            // l_datum
            // 
            this.l_datum.AutoSize = true;
            this.l_datum.Location = new System.Drawing.Point(12, 48);
            this.l_datum.Name = "l_datum";
            this.l_datum.Size = new System.Drawing.Size(102, 13);
            this.l_datum.TabIndex = 2;
            this.l_datum.Text = "Datum der Buchung";
            // 
            // dtp_datum
            // 
            this.dtp_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datum.Location = new System.Drawing.Point(15, 64);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(200, 20);
            this.dtp_datum.TabIndex = 3;
            // 
            // l_wert
            // 
            this.l_wert.AutoSize = true;
            this.l_wert.Location = new System.Drawing.Point(12, 87);
            this.l_wert.Name = "l_wert";
            this.l_wert.Size = new System.Drawing.Size(94, 13);
            this.l_wert.TabIndex = 4;
            this.l_wert.Text = "Wert der Buchung";
            // 
            // tb_wert
            // 
            this.tb_wert.Location = new System.Drawing.Point(15, 103);
            this.tb_wert.Name = "tb_wert";
            this.tb_wert.Size = new System.Drawing.Size(200, 20);
            this.tb_wert.TabIndex = 5;
            // 
            // tb_grund
            // 
            this.tb_grund.Location = new System.Drawing.Point(15, 25);
            this.tb_grund.Name = "tb_grund";
            this.tb_grund.Size = new System.Drawing.Size(200, 20);
            this.tb_grund.TabIndex = 6;
            // 
            // rb_einnahmen
            // 
            this.rb_einnahmen.AutoSize = true;
            this.rb_einnahmen.Location = new System.Drawing.Point(28, 129);
            this.rb_einnahmen.Name = "rb_einnahmen";
            this.rb_einnahmen.Size = new System.Drawing.Size(78, 17);
            this.rb_einnahmen.TabIndex = 7;
            this.rb_einnahmen.Text = "Einnahmen";
            this.rb_einnahmen.UseVisualStyleBackColor = true;
            // 
            // rb_ausgaben
            // 
            this.rb_ausgaben.AutoSize = true;
            this.rb_ausgaben.Location = new System.Drawing.Point(112, 129);
            this.rb_ausgaben.Name = "rb_ausgaben";
            this.rb_ausgaben.Size = new System.Drawing.Size(73, 17);
            this.rb_ausgaben.TabIndex = 8;
            this.rb_ausgaben.Text = "Ausgaben";
            this.rb_ausgaben.UseVisualStyleBackColor = true;
            // 
            // b_zurück
            // 
            this.b_zurück.Location = new System.Drawing.Point(140, 155);
            this.b_zurück.Name = "b_zurück";
            this.b_zurück.Size = new System.Drawing.Size(75, 23);
            this.b_zurück.TabIndex = 9;
            this.b_zurück.Text = "zurück";
            this.b_zurück.UseVisualStyleBackColor = true;
            this.b_zurück.Click += new System.EventHandler(this.b_zurück_Click);
            // 
            // b_speichern
            // 
            this.b_speichern.Location = new System.Drawing.Point(12, 155);
            this.b_speichern.Name = "b_speichern";
            this.b_speichern.Size = new System.Drawing.Size(75, 23);
            this.b_speichern.TabIndex = 10;
            this.b_speichern.Text = "Speichern";
            this.b_speichern.UseVisualStyleBackColor = true;
            this.b_speichern.Click += new System.EventHandler(this.b_speichern_Click);
            // 
            // Eingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 190);
            this.Controls.Add(this.b_speichern);
            this.Controls.Add(this.b_zurück);
            this.Controls.Add(this.rb_ausgaben);
            this.Controls.Add(this.rb_einnahmen);
            this.Controls.Add(this.tb_grund);
            this.Controls.Add(this.tb_wert);
            this.Controls.Add(this.l_wert);
            this.Controls.Add(this.dtp_datum);
            this.Controls.Add(this.l_datum);
            this.Controls.Add(this.l_grund);
            this.Name = "Eingabe";
            this.Text = "Eingabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_grund;
        private System.Windows.Forms.Label l_datum;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.Label l_wert;
        private System.Windows.Forms.TextBox tb_wert;
        private System.Windows.Forms.RadioButton rb_ausgaben;
        private System.Windows.Forms.Button b_zurück;
        private System.Windows.Forms.Button b_speichern;
        private System.Windows.Forms.TextBox tb_grund;
        private System.Windows.Forms.RadioButton rb_einnahmen;
    }
}
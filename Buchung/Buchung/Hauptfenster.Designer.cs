namespace Buchung
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_Start = new System.Windows.Forms.Label();
            this.b_eingabe = new System.Windows.Forms.Button();
            this.b_ausgabe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Start
            // 
            this.l_Start.AutoSize = true;
            this.l_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Start.Location = new System.Drawing.Point(44, 25);
            this.l_Start.Name = "l_Start";
            this.l_Start.Size = new System.Drawing.Size(127, 20);
            this.l_Start.TabIndex = 0;
            this.l_Start.Text = "Bitte wählen Sie:";
            // 
            // b_eingabe
            // 
            this.b_eingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eingabe.Location = new System.Drawing.Point(48, 57);
            this.b_eingabe.Name = "b_eingabe";
            this.b_eingabe.Size = new System.Drawing.Size(123, 31);
            this.b_eingabe.TabIndex = 1;
            this.b_eingabe.Text = "Werte eingeben";
            this.b_eingabe.UseVisualStyleBackColor = true;
            this.b_eingabe.Click += new System.EventHandler(this.b_eingabe_Click);
            // 
            // b_ausgabe
            // 
            this.b_ausgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ausgabe.Location = new System.Drawing.Point(48, 104);
            this.b_ausgabe.Name = "b_ausgabe";
            this.b_ausgabe.Size = new System.Drawing.Size(123, 31);
            this.b_ausgabe.TabIndex = 2;
            this.b_ausgabe.Text = "Werte ausgeben";
            this.b_ausgabe.UseVisualStyleBackColor = true;
            this.b_ausgabe.Click += new System.EventHandler(this.b_ausgabe_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 181);
            this.Controls.Add(this.b_ausgabe);
            this.Controls.Add(this.b_eingabe);
            this.Controls.Add(this.l_Start);
            this.Name = "Hauptfenster";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Start;
        private System.Windows.Forms.Button b_eingabe;
        private System.Windows.Forms.Button b_ausgabe;
    }
}


namespace Buchung
{
    partial class Ausgabe
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
            this.tc_ausgabe = new System.Windows.Forms.TabControl();
            this.tp_einnahmen_ausgaben = new System.Windows.Forms.TabPage();
            this.tb_saldo = new System.Windows.Forms.TextBox();
            this.l_saldo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.l_einnahmen = new System.Windows.Forms.Label();
            this.l_ausgaben = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.l_summe_einnahmen = new System.Windows.Forms.Label();
            this.l_summe_ausgaben = new System.Windows.Forms.Label();
            this.tp_salden = new System.Windows.Forms.TabPage();
            this.rt_salden = new System.Windows.Forms.RichTextBox();
            this.l_salden = new System.Windows.Forms.Label();
            this.tp_jahresvergleich = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.l_monatssaldo_rechts = new System.Windows.Forms.Label();
            this.l_monatssaldo_links = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.l_jahressaldo_links = new System.Windows.Forms.Label();
            this.l_jahressaldo_rechts = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.l_jahr_links = new System.Windows.Forms.Label();
            this.cb_Jahr_links = new System.Windows.Forms.ComboBox();
            this.cb_jahr_rechts = new System.Windows.Forms.ComboBox();
            this.l_jahr_rechts = new System.Windows.Forms.Label();
            this.cb_monat = new System.Windows.Forms.ComboBox();
            this.l_monat = new System.Windows.Forms.Label();
            this.b_zurück = new System.Windows.Forms.Button();
            this.b_abfragen = new System.Windows.Forms.Button();
            this.tc_ausgabe.SuspendLayout();
            this.tp_einnahmen_ausgaben.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tp_salden.SuspendLayout();
            this.tp_jahresvergleich.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_ausgabe
            // 
            this.tc_ausgabe.Controls.Add(this.tp_einnahmen_ausgaben);
            this.tc_ausgabe.Controls.Add(this.tp_salden);
            this.tc_ausgabe.Controls.Add(this.tp_jahresvergleich);
            this.tc_ausgabe.Location = new System.Drawing.Point(12, 12);
            this.tc_ausgabe.Name = "tc_ausgabe";
            this.tc_ausgabe.SelectedIndex = 0;
            this.tc_ausgabe.Size = new System.Drawing.Size(764, 384);
            this.tc_ausgabe.TabIndex = 0;
            // 
            // tp_einnahmen_ausgaben
            // 
            this.tp_einnahmen_ausgaben.Controls.Add(this.tb_saldo);
            this.tp_einnahmen_ausgaben.Controls.Add(this.l_saldo);
            this.tp_einnahmen_ausgaben.Controls.Add(this.tableLayoutPanel1);
            this.tp_einnahmen_ausgaben.Location = new System.Drawing.Point(4, 22);
            this.tp_einnahmen_ausgaben.Name = "tp_einnahmen_ausgaben";
            this.tp_einnahmen_ausgaben.Padding = new System.Windows.Forms.Padding(3);
            this.tp_einnahmen_ausgaben.Size = new System.Drawing.Size(756, 358);
            this.tp_einnahmen_ausgaben.TabIndex = 0;
            this.tp_einnahmen_ausgaben.Text = "Einnahmen und Ausgaben";
            this.tp_einnahmen_ausgaben.UseVisualStyleBackColor = true;
            // 
            // tb_saldo
            // 
            this.tb_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_saldo.Location = new System.Drawing.Point(222, 322);
            this.tb_saldo.Name = "tb_saldo";
            this.tb_saldo.Size = new System.Drawing.Size(367, 26);
            this.tb_saldo.TabIndex = 8;
            // 
            // l_saldo
            // 
            this.l_saldo.AutoSize = true;
            this.l_saldo.Location = new System.Drawing.Point(362, 306);
            this.l_saldo.Name = "l_saldo";
            this.l_saldo.Size = new System.Drawing.Size(34, 13);
            this.l_saldo.TabIndex = 1;
            this.l_saldo.Text = "Saldo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.l_einnahmen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_ausgaben, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.l_summe_einnahmen, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.l_summe_ausgaben, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 297);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(376, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 26);
            this.textBox2.TabIndex = 7;
            // 
            // l_einnahmen
            // 
            this.l_einnahmen.AutoSize = true;
            this.l_einnahmen.Location = new System.Drawing.Point(3, 0);
            this.l_einnahmen.Name = "l_einnahmen";
            this.l_einnahmen.Size = new System.Drawing.Size(60, 13);
            this.l_einnahmen.TabIndex = 0;
            this.l_einnahmen.Text = "Einnahmen";
            // 
            // l_ausgaben
            // 
            this.l_ausgaben.AutoSize = true;
            this.l_ausgaben.Location = new System.Drawing.Point(376, 0);
            this.l_ausgaben.Name = "l_ausgaben";
            this.l_ausgaben.Size = new System.Drawing.Size(55, 13);
            this.l_ausgaben.TabIndex = 1;
            this.l_ausgaben.Text = "Ausgaben";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(376, 16);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(367, 221);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(367, 221);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // l_summe_einnahmen
            // 
            this.l_summe_einnahmen.AutoSize = true;
            this.l_summe_einnahmen.Location = new System.Drawing.Point(3, 240);
            this.l_summe_einnahmen.Name = "l_summe_einnahmen";
            this.l_summe_einnahmen.Size = new System.Drawing.Size(116, 13);
            this.l_summe_einnahmen.TabIndex = 4;
            this.l_summe_einnahmen.Text = "Summe der Einnahmen";
            // 
            // l_summe_ausgaben
            // 
            this.l_summe_ausgaben.AutoSize = true;
            this.l_summe_ausgaben.Location = new System.Drawing.Point(376, 240);
            this.l_summe_ausgaben.Name = "l_summe_ausgaben";
            this.l_summe_ausgaben.Size = new System.Drawing.Size(111, 13);
            this.l_summe_ausgaben.TabIndex = 5;
            this.l_summe_ausgaben.Text = "Summe der Ausgaben";
            // 
            // tp_salden
            // 
            this.tp_salden.Controls.Add(this.rt_salden);
            this.tp_salden.Controls.Add(this.l_salden);
            this.tp_salden.Location = new System.Drawing.Point(4, 22);
            this.tp_salden.Name = "tp_salden";
            this.tp_salden.Size = new System.Drawing.Size(756, 358);
            this.tp_salden.TabIndex = 1;
            this.tp_salden.Text = "Salden";
            this.tp_salden.UseVisualStyleBackColor = true;
            // 
            // rt_salden
            // 
            this.rt_salden.Location = new System.Drawing.Point(6, 16);
            this.rt_salden.Name = "rt_salden";
            this.rt_salden.Size = new System.Drawing.Size(747, 339);
            this.rt_salden.TabIndex = 1;
            this.rt_salden.Text = "";
            // 
            // l_salden
            // 
            this.l_salden.AutoSize = true;
            this.l_salden.Location = new System.Drawing.Point(3, 0);
            this.l_salden.Name = "l_salden";
            this.l_salden.Size = new System.Drawing.Size(59, 13);
            this.l_salden.TabIndex = 0;
            this.l_salden.Text = "alle Salden";
            // 
            // tp_jahresvergleich
            // 
            this.tp_jahresvergleich.Controls.Add(this.tableLayoutPanel2);
            this.tp_jahresvergleich.Location = new System.Drawing.Point(4, 22);
            this.tp_jahresvergleich.Name = "tp_jahresvergleich";
            this.tp_jahresvergleich.Size = new System.Drawing.Size(756, 358);
            this.tp_jahresvergleich.TabIndex = 2;
            this.tp_jahresvergleich.Text = "Jahresvergleich";
            this.tp_jahresvergleich.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.l_monatssaldo_rechts, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.l_monatssaldo_links, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.l_jahressaldo_links, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.l_jahressaldo_rechts, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox4, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.829597F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.1704F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(753, 352);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // l_monatssaldo_rechts
            // 
            this.l_monatssaldo_rechts.AutoSize = true;
            this.l_monatssaldo_rechts.Location = new System.Drawing.Point(379, 0);
            this.l_monatssaldo_rechts.Name = "l_monatssaldo_rechts";
            this.l_monatssaldo_rechts.Size = new System.Drawing.Size(62, 13);
            this.l_monatssaldo_rechts.TabIndex = 1;
            this.l_monatssaldo_rechts.Text = "Monatsaldo";
            // 
            // l_monatssaldo_links
            // 
            this.l_monatssaldo_links.AutoSize = true;
            this.l_monatssaldo_links.Location = new System.Drawing.Point(3, 0);
            this.l_monatssaldo_links.Name = "l_monatssaldo_links";
            this.l_monatssaldo_links.Size = new System.Drawing.Size(62, 13);
            this.l_monatssaldo_links.TabIndex = 0;
            this.l_monatssaldo_links.Text = "Monatsaldo";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(379, 326);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(367, 26);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 326);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(370, 26);
            this.textBox3.TabIndex = 9;
            // 
            // l_jahressaldo_links
            // 
            this.l_jahressaldo_links.AutoSize = true;
            this.l_jahressaldo_links.Location = new System.Drawing.Point(3, 309);
            this.l_jahressaldo_links.Name = "l_jahressaldo_links";
            this.l_jahressaldo_links.Size = new System.Drawing.Size(63, 13);
            this.l_jahressaldo_links.TabIndex = 11;
            this.l_jahressaldo_links.Text = "Jahressaldo";
            // 
            // l_jahressaldo_rechts
            // 
            this.l_jahressaldo_rechts.AutoSize = true;
            this.l_jahressaldo_rechts.Location = new System.Drawing.Point(379, 309);
            this.l_jahressaldo_rechts.Name = "l_jahressaldo_rechts";
            this.l_jahressaldo_rechts.Size = new System.Drawing.Size(63, 13);
            this.l_jahressaldo_rechts.TabIndex = 12;
            this.l_jahressaldo_rechts.Text = "Jahressaldo";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(3, 21);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(370, 285);
            this.richTextBox3.TabIndex = 13;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(379, 21);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(367, 285);
            this.richTextBox4.TabIndex = 14;
            this.richTextBox4.Text = "";
            // 
            // l_jahr_links
            // 
            this.l_jahr_links.AutoSize = true;
            this.l_jahr_links.Location = new System.Drawing.Point(19, 399);
            this.l_jahr_links.Name = "l_jahr_links";
            this.l_jahr_links.Size = new System.Drawing.Size(27, 13);
            this.l_jahr_links.TabIndex = 1;
            this.l_jahr_links.Text = "Jahr";
            // 
            // cb_Jahr_links
            // 
            this.cb_Jahr_links.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Jahr_links.FormattingEnabled = true;
            this.cb_Jahr_links.Location = new System.Drawing.Point(22, 415);
            this.cb_Jahr_links.MaxLength = 4;
            this.cb_Jahr_links.Name = "cb_Jahr_links";
            this.cb_Jahr_links.Size = new System.Drawing.Size(59, 24);
            this.cb_Jahr_links.Sorted = true;
            this.cb_Jahr_links.TabIndex = 2;
            // 
            // cb_jahr_rechts
            // 
            this.cb_jahr_rechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_jahr_rechts.FormattingEnabled = true;
            this.cb_jahr_rechts.Location = new System.Drawing.Point(87, 415);
            this.cb_jahr_rechts.MaxLength = 4;
            this.cb_jahr_rechts.Name = "cb_jahr_rechts";
            this.cb_jahr_rechts.Size = new System.Drawing.Size(59, 24);
            this.cb_jahr_rechts.Sorted = true;
            this.cb_jahr_rechts.TabIndex = 4;
            // 
            // l_jahr_rechts
            // 
            this.l_jahr_rechts.AutoSize = true;
            this.l_jahr_rechts.Location = new System.Drawing.Point(84, 399);
            this.l_jahr_rechts.Name = "l_jahr_rechts";
            this.l_jahr_rechts.Size = new System.Drawing.Size(27, 13);
            this.l_jahr_rechts.TabIndex = 3;
            this.l_jahr_rechts.Text = "Jahr";
            // 
            // cb_monat
            // 
            this.cb_monat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_monat.FormattingEnabled = true;
            this.cb_monat.Location = new System.Drawing.Point(152, 415);
            this.cb_monat.MaxLength = 4;
            this.cb_monat.Name = "cb_monat";
            this.cb_monat.Size = new System.Drawing.Size(59, 24);
            this.cb_monat.Sorted = true;
            this.cb_monat.TabIndex = 6;
            // 
            // l_monat
            // 
            this.l_monat.AutoSize = true;
            this.l_monat.Location = new System.Drawing.Point(149, 399);
            this.l_monat.Name = "l_monat";
            this.l_monat.Size = new System.Drawing.Size(37, 13);
            this.l_monat.TabIndex = 5;
            this.l_monat.Text = "Monat";
            // 
            // b_zurück
            // 
            this.b_zurück.Location = new System.Drawing.Point(693, 415);
            this.b_zurück.Name = "b_zurück";
            this.b_zurück.Size = new System.Drawing.Size(75, 23);
            this.b_zurück.TabIndex = 10;
            this.b_zurück.Text = "zurück";
            this.b_zurück.UseVisualStyleBackColor = true;
            this.b_zurück.Click += new System.EventHandler(this.b_zurück_Click);
            // 
            // b_abfragen
            // 
            this.b_abfragen.Location = new System.Drawing.Point(612, 415);
            this.b_abfragen.Name = "b_abfragen";
            this.b_abfragen.Size = new System.Drawing.Size(75, 23);
            this.b_abfragen.TabIndex = 11;
            this.b_abfragen.Text = "Abfragen";
            this.b_abfragen.UseVisualStyleBackColor = true;
            this.b_abfragen.Click += new System.EventHandler(this.b_abfragen_Click);
            // 
            // Ausgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.b_abfragen);
            this.Controls.Add(this.b_zurück);
            this.Controls.Add(this.cb_monat);
            this.Controls.Add(this.l_monat);
            this.Controls.Add(this.cb_jahr_rechts);
            this.Controls.Add(this.l_jahr_rechts);
            this.Controls.Add(this.cb_Jahr_links);
            this.Controls.Add(this.l_jahr_links);
            this.Controls.Add(this.tc_ausgabe);
            this.Name = "Ausgabe";
            this.Text = "Ausgabe";
            this.tc_ausgabe.ResumeLayout(false);
            this.tp_einnahmen_ausgaben.ResumeLayout(false);
            this.tp_einnahmen_ausgaben.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tp_salden.ResumeLayout(false);
            this.tp_salden.PerformLayout();
            this.tp_jahresvergleich.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_ausgabe;
        private System.Windows.Forms.TabPage tp_einnahmen_ausgaben;
        private System.Windows.Forms.TabPage tp_salden;
        private System.Windows.Forms.TabPage tp_jahresvergleich;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label l_einnahmen;
        private System.Windows.Forms.Label l_ausgaben;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label l_summe_einnahmen;
        private System.Windows.Forms.Label l_summe_ausgaben;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tb_saldo;
        private System.Windows.Forms.Label l_saldo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rt_salden;
        private System.Windows.Forms.Label l_salden;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label l_monatssaldo_rechts;
        private System.Windows.Forms.Label l_monatssaldo_links;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label l_jahressaldo_links;
        private System.Windows.Forms.Label l_jahressaldo_rechts;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label l_jahr_links;
        private System.Windows.Forms.ComboBox cb_Jahr_links;
        private System.Windows.Forms.ComboBox cb_jahr_rechts;
        private System.Windows.Forms.Label l_jahr_rechts;
        private System.Windows.Forms.ComboBox cb_monat;
        private System.Windows.Forms.Label l_monat;
        private System.Windows.Forms.Button b_zurück;
        private System.Windows.Forms.Button b_abfragen;
    }
}
namespace test_cvic6
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
            this.textBox_cislo = new System.Windows.Forms.TextBox();
            this.TextBox_jmeno = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_prijmeni = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_dtm_naroz = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_adresa = new System.Windows.Forms.MaskedTextBox();
            this.label_cislo = new System.Windows.Forms.Label();
            this.label_jmeno = new System.Windows.Forms.Label();
            this.label_prijmeni = new System.Windows.Forms.Label();
            this.label_dtm_naroz = new System.Windows.Forms.Label();
            this.label_adresa = new System.Windows.Forms.Label();
            this.button_uloz = new System.Windows.Forms.Button();
            this.button_narozen = new System.Windows.Forms.Button();
            this.textBox_veta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_cislo
            // 
            this.textBox_cislo.Location = new System.Drawing.Point(307, 4);
            this.textBox_cislo.Name = "textBox_cislo";
            this.textBox_cislo.Size = new System.Drawing.Size(100, 20);
            this.textBox_cislo.TabIndex = 0;
            // 
            // TextBox_jmeno
            // 
            this.TextBox_jmeno.Location = new System.Drawing.Point(306, 30);
            this.TextBox_jmeno.Name = "TextBox_jmeno";
            this.TextBox_jmeno.Size = new System.Drawing.Size(100, 20);
            this.TextBox_jmeno.TabIndex = 1;
            // 
            // TextBox_prijmeni
            // 
            this.TextBox_prijmeni.Location = new System.Drawing.Point(307, 56);
            this.TextBox_prijmeni.Name = "TextBox_prijmeni";
            this.TextBox_prijmeni.Size = new System.Drawing.Size(100, 20);
            this.TextBox_prijmeni.TabIndex = 2;
            // 
            // TextBox_dtm_naroz
            // 
            this.TextBox_dtm_naroz.Location = new System.Drawing.Point(306, 86);
            this.TextBox_dtm_naroz.Name = "TextBox_dtm_naroz";
            this.TextBox_dtm_naroz.Size = new System.Drawing.Size(100, 20);
            this.TextBox_dtm_naroz.TabIndex = 3;
            // 
            // TextBox_adresa
            // 
            this.TextBox_adresa.Location = new System.Drawing.Point(307, 108);
            this.TextBox_adresa.Name = "TextBox_adresa";
            this.TextBox_adresa.Size = new System.Drawing.Size(100, 20);
            this.TextBox_adresa.TabIndex = 4;
            // 
            // label_cislo
            // 
            this.label_cislo.AutoSize = true;
            this.label_cislo.Location = new System.Drawing.Point(12, 4);
            this.label_cislo.Name = "label_cislo";
            this.label_cislo.Size = new System.Drawing.Size(41, 13);
            this.label_cislo.TabIndex = 5;
            this.label_cislo.Text = "CISLO:";
            // 
            // label_jmeno
            // 
            this.label_jmeno.AutoSize = true;
            this.label_jmeno.Location = new System.Drawing.Point(12, 30);
            this.label_jmeno.Name = "label_jmeno";
            this.label_jmeno.Size = new System.Drawing.Size(47, 13);
            this.label_jmeno.TabIndex = 6;
            this.label_jmeno.Text = "JMENO:";
            // 
            // label_prijmeni
            // 
            this.label_prijmeni.AutoSize = true;
            this.label_prijmeni.Location = new System.Drawing.Point(12, 56);
            this.label_prijmeni.Name = "label_prijmeni";
            this.label_prijmeni.Size = new System.Drawing.Size(60, 13);
            this.label_prijmeni.TabIndex = 7;
            this.label_prijmeni.Text = "PRIJMENI:";
            // 
            // label_dtm_naroz
            // 
            this.label_dtm_naroz.AutoSize = true;
            this.label_dtm_naroz.Location = new System.Drawing.Point(9, 86);
            this.label_dtm_naroz.Name = "label_dtm_naroz";
            this.label_dtm_naroz.Size = new System.Drawing.Size(108, 13);
            this.label_dtm_naroz.TabIndex = 8;
            this.label_dtm_naroz.Text = "DATUM NAROZENI:";
            // 
            // label_adresa
            // 
            this.label_adresa.AutoSize = true;
            this.label_adresa.Location = new System.Drawing.Point(12, 108);
            this.label_adresa.Name = "label_adresa";
            this.label_adresa.Size = new System.Drawing.Size(54, 13);
            this.label_adresa.TabIndex = 9;
            this.label_adresa.Text = "ADRESA:";
            // 
            // button_uloz
            // 
            this.button_uloz.Location = new System.Drawing.Point(15, 130);
            this.button_uloz.Name = "button_uloz";
            this.button_uloz.Size = new System.Drawing.Size(75, 23);
            this.button_uloz.TabIndex = 10;
            this.button_uloz.Text = "ULOŽ";
            this.button_uloz.UseVisualStyleBackColor = true;
            this.button_uloz.Click += new System.EventHandler(this.button_uloz_Click);
            // 
            // button_narozen
            // 
            this.button_narozen.Location = new System.Drawing.Point(331, 130);
            this.button_narozen.Name = "button_narozen";
            this.button_narozen.Size = new System.Drawing.Size(75, 23);
            this.button_narozen.TabIndex = 11;
            this.button_narozen.Text = "NAROZEN";
            this.button_narozen.UseVisualStyleBackColor = true;
            this.button_narozen.Click += new System.EventHandler(this.button_narozen_Click);
            // 
            // textBox_veta
            // 
            this.textBox_veta.Location = new System.Drawing.Point(12, 159);
            this.textBox_veta.Name = "textBox_veta";
            this.textBox_veta.Size = new System.Drawing.Size(395, 20);
            this.textBox_veta.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 185);
            this.Controls.Add(this.textBox_veta);
            this.Controls.Add(this.button_narozen);
            this.Controls.Add(this.button_uloz);
            this.Controls.Add(this.label_adresa);
            this.Controls.Add(this.label_dtm_naroz);
            this.Controls.Add(this.label_prijmeni);
            this.Controls.Add(this.label_jmeno);
            this.Controls.Add(this.label_cislo);
            this.Controls.Add(this.TextBox_adresa);
            this.Controls.Add(this.TextBox_dtm_naroz);
            this.Controls.Add(this.TextBox_prijmeni);
            this.Controls.Add(this.TextBox_jmeno);
            this.Controls.Add(this.textBox_cislo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cislo;
        private System.Windows.Forms.MaskedTextBox TextBox_jmeno;
        private System.Windows.Forms.MaskedTextBox TextBox_prijmeni;
        private System.Windows.Forms.MaskedTextBox TextBox_dtm_naroz;
        private System.Windows.Forms.MaskedTextBox TextBox_adresa;
        private System.Windows.Forms.Label label_cislo;
        private System.Windows.Forms.Label label_jmeno;
        private System.Windows.Forms.Label label_prijmeni;
        private System.Windows.Forms.Label label_dtm_naroz;
        private System.Windows.Forms.Label label_adresa;
        private System.Windows.Forms.Button button_uloz;
        private System.Windows.Forms.Button button_narozen;
        private System.Windows.Forms.TextBox textBox_veta;
    }
}


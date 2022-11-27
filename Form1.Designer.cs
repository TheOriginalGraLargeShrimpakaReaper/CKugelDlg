namespace CKugelDlg
{
    partial class CKugelDlg
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtUmfang = new System.Windows.Forms.TextBox();
            this.txtSchnittflaeche = new System.Windows.Forms.TextBox();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.txtAnzahl = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblUmfang = new System.Windows.Forms.Label();
            this.lblSchnittflaeche = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.m_intAnzahlBerechnungen = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.m_intAnzahlBerechnungen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(85, 10);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 0;
            // 
            // txtUmfang
            // 
            this.txtUmfang.Location = new System.Drawing.Point(85, 40);
            this.txtUmfang.Name = "txtUmfang";
            this.txtUmfang.ReadOnly = true;
            this.txtUmfang.Size = new System.Drawing.Size(100, 20);
            this.txtUmfang.TabIndex = 1;
            // 
            // txtSchnittflaeche
            // 
            this.txtSchnittflaeche.Location = new System.Drawing.Point(85, 70);
            this.txtSchnittflaeche.Name = "txtSchnittflaeche";
            this.txtSchnittflaeche.ReadOnly = true;
            this.txtSchnittflaeche.Size = new System.Drawing.Size(100, 20);
            this.txtSchnittflaeche.TabIndex = 2;
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(85, 100);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.ReadOnly = true;
            this.txtVolumen.Size = new System.Drawing.Size(100, 20);
            this.txtVolumen.TabIndex = 3;
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Location = new System.Drawing.Point(240, 70);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.ReadOnly = true;
            this.txtAnzahl.Size = new System.Drawing.Size(50, 20);
            this.txtAnzahl.TabIndex = 4;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(195, 10);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(95, 20);
            this.btnBerechnen.TabIndex = 5;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(195, 100);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(95, 20);
            this.btnSchliessen.TabIndex = 6;
            this.btnSchliessen.Text = "Schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // lblRadius
            // 
            this.lblRadius.Location = new System.Drawing.Point(10, 10);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(50, 20);
            this.lblRadius.TabIndex = 7;
            this.lblRadius.Text = "Radius";
            // 
            // lblUmfang
            // 
            this.lblUmfang.Location = new System.Drawing.Point(10, 40);
            this.lblUmfang.Name = "lblUmfang";
            this.lblUmfang.Size = new System.Drawing.Size(50, 20);
            this.lblUmfang.TabIndex = 8;
            this.lblUmfang.Text = "Umfang";
            // 
            // lblSchnittflaeche
            // 
            this.lblSchnittflaeche.Location = new System.Drawing.Point(10, 70);
            this.lblSchnittflaeche.Name = "lblSchnittflaeche";
            this.lblSchnittflaeche.Size = new System.Drawing.Size(75, 20);
            this.lblSchnittflaeche.TabIndex = 9;
            this.lblSchnittflaeche.Text = "Schnittfläche";
            // 
            // lblVolumen
            // 
            this.lblVolumen.Location = new System.Drawing.Point(10, 100);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(75, 20);
            this.lblVolumen.TabIndex = 10;
            this.lblVolumen.Text = "Volumen";
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.Location = new System.Drawing.Point(195, 70);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(45, 20);
            this.lblAnzahl.TabIndex = 11;
            this.lblAnzahl.Text = "Anzahl";
            // 
            // m_intAnzahlBerechnungen
            // 
            this.m_intAnzahlBerechnungen.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.m_intAnzahlBerechnungen.Location = new System.Drawing.Point(198, 37);
            this.m_intAnzahlBerechnungen.Name = "m_intAnzahlBerechnungen";
            this.m_intAnzahlBerechnungen.ReadOnly = true;
            this.m_intAnzahlBerechnungen.Size = new System.Drawing.Size(84, 20);
            this.m_intAnzahlBerechnungen.TabIndex = 12;
            this.m_intAnzahlBerechnungen.Visible = false;
            // 
            // CKugelDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 126);
            this.Controls.Add(this.m_intAnzahlBerechnungen);
            this.Controls.Add(this.lblAnzahl);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.lblSchnittflaeche);
            this.Controls.Add(this.lblUmfang);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAnzahl);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.txtSchnittflaeche);
            this.Controls.Add(this.txtUmfang);
            this.Controls.Add(this.txtRadius);
            this.Name = "CKugelDlg";
            this.Text = "Kugel";
            ((System.ComponentModel.ISupportInitialize)(this.m_intAnzahlBerechnungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtUmfang;
        private System.Windows.Forms.TextBox txtSchnittflaeche;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.TextBox txtAnzahl;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblUmfang;
        private System.Windows.Forms.Label lblSchnittflaeche;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.NumericUpDown m_intAnzahlBerechnungen;
    }
}


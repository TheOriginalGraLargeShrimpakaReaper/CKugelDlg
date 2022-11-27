using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKugelDlg
{
    /// <summary>
    /// Klasse CKugelDlg
    /// Erbt von Klasse Form
    /// </summary>
    public partial class CKugelDlg : Form
    {
        /// <summary>
        /// Konstruktor der Klasse CKugelDlg
        /// </summary>
        public CKugelDlg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Schliesst das Fenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie die Applikation wirklich schliessen?", "Schliessen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Applikation wird geschlossen");
                System.Windows.Forms.Application.Exit();
            }
        }

        /// <summary>
        /// Führt die Berechnung folgender Werte aus
        /// 1.  Umfang
        /// 2.  Schnittfläche
        /// 3.  Volumen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            /*
             *  Overflow Exceptions und allgemeine Exceptions abfangen 
            */
            try
            {
                //  Prüfen ob Usereingabe valid ist
                (bool bValid, double dRadius) = CheckRadiusEingabe(txtRadius);

                /*
                 * Nur weitermachen, wenn die Usereingabe sauber ist.
                 * Wenn valide, folgende Funktionen aufrufen:
                 * 1.   Umfang berechnen        =   UmfangBerechnen
                 * 2.   Schnittfläche berechnen =   SchnittflaecheBerechnen
                 * 3.   Kugelvolumen berechnen  =   KugelVolumenBerechnen
                 * 4.   Zähler erhöhen          =   AddCounter
                */
                if (bValid)
                {
                    double dPI = Math.PI;
                    UmfangBerechnen(dRadius, dPI);
                    SchnittflaecheBerechnen(dRadius, dPI);
                    KugelVolumenBerechnen(dRadius, dPI);
                    AddCounter(m_intAnzahlBerechnungen, txtAnzahl);
                }
            }
            //  Overflows explizit Abfangen
            catch(OverflowException ex)
            {
                string strMessage = "OverflowException: " + ex.ToString();
                MessageBox.Show(strMessage, "Benutzereingabe", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            //  Alle anderen Exceptions abfangen
            catch(Exception ex)
            {
                string strMessage = "Exception: " + ex.ToString();
                MessageBox.Show(strMessage, "Benutzereingabe", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Liest zuerst den Wert der Übergebeben TextBox aus.
        /// Prüft dann ob es sich nicht um einen Alphanummerischen Wert oder einen NULL Wert handelt.
        /// Gibt dann die validität sowie den Radius als Tupel zurück
        /// </summary>
        /// <param name="oTextBox"></param>
        /// <returns></returns>
        private (bool, double) CheckRadiusEingabe(TextBox oTextBox)
        {
            //  Variablen deklarieren und teils definieren
            string strRadius = oTextBox.Text;                                       //  Radius aus Textfeld holen
            double dRadius;
            bool bRadius_Is_NULL = string.IsNullOrEmpty(strRadius);                 //  Prüfen ob Eingabe NULL ist
            bool bRadius_Is_Parsable = double.TryParse(strRadius, out dRadius);     //  Prüfen ob Eingabe geparsed werden kann und wenn ja => Parsen

            //  Validität Standardmässig false
            bool bValid = false;

            /*
             * Prüfen ob Radius NULL ist oder nicht geparsed werden konnte
             * Fehler werfen wenn beides nicht zutrifft
            */
            if(!bRadius_Is_NULL && bRadius_Is_Parsable)     //  Normalfall
            {
                bValid = true;
            }
            else                                            //  Ausnahme
            {
                string strMessage = $"Die Eingabe des Radius ist nicht korrekt: '{strRadius}'";
                ThrowUserExecption(strMessage, oTextBox);
                bValid = false;
            }

            //  Zurückgeben der validität und des Radius als Double
            return (bValid, dRadius);
        }

        /// <summary>
        /// Berechnet den Umfang und übergibt den Wert ins Umfangsfeld
        /// </summary>
        /// <param name="dRadius"></param>
        /// <param name="dPI"></param>
        private void UmfangBerechnen(double dRadius, double dPI)
        {
            double dUmfang_U = 2 * dRadius * dPI;
            AddValue(dUmfang_U, txtUmfang);
        }

        /// <summary>
        /// Berechnet die Schnittfläche der Kugel (wie Kreis) und übergibt diesem dem Schnittflächenfeld
        /// </summary>
        /// <param name="dRadius"></param>
        /// <param name="dPI"></param>
        private void SchnittflaecheBerechnen(double dRadius, double dPI)
        {
            double dSchnittflaeche_F = Math.Pow(dRadius, 2.0) * dPI;
            AddValue(dSchnittflaeche_F, txtSchnittflaeche);
        }

        /// <summary>
        /// Berechnet das Volumen der Kugel und übergibt den Wert ans Kugelvolumenfeld
        /// </summary>
        /// <param name="dRadius"></param>
        /// <param name="dPI"></param>
        private void KugelVolumenBerechnen(double dRadius, double dPI)
        {
            double dKugelvolumen_V = 4.0 / 3.0 * Math.Pow(dRadius, 3.0) * dPI;
            AddValue(dKugelvolumen_V, txtVolumen);
        }

        /// <summary>
        /// Gibt den Übergebenen Fehlertext einer MessageBox,
        /// selektiert den ganzen Text der übergebenen TextBox und legt den Fokus auf die übergebene TextBox
        /// </summary>
        /// <param name="strMessage"></param>
        /// <param name="oTextBox"></param>
        private void ThrowUserExecption(string strMessage, TextBox oTextBox)
        {
            MessageBox.Show(strMessage, "Benutzereingabe", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            oTextBox.SelectAll();
            oTextBox.Focus();
        }

        /// <summary>
        /// Setzt den übergebenen Wert an die übergebene TextBox
        /// </summary>
        /// <param name="dWert"></param>
        /// <param name="oTextBox"></param>
        private void AddValue(double dWert, TextBox oTextBox)
        {
            oTextBox.Text = dWert.ToString();
        }

        /// <summary>
        /// Imkrementiert die Anzahl berechnungen
        /// </summary>
        /// <param name="oNumDown"></param>
        /// <param name="oTextBox"></param>
        private void AddCounter(NumericUpDown oNumDown, TextBox oTextBox)
        {
            /*
             *  Integer (NummericDown) Feld
            */
            //  Auslesen des Wertes
            int nAnzahlElemente = Convert.ToInt32(oNumDown.Value);

            //  Inkrementieren
            nAnzahlElemente++;

            // Zurückschreiben
            oNumDown.Value = nAnzahlElemente;

            /*
             * Textfeld
            */
            oTextBox.Text = nAnzahlElemente.ToString();
        }

    }
}

namespace MT_WinForms_Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zahl1_Click(object sender, EventArgs e) // Eingabe von Zahlen mit Buttons von 1-9
        {
            EingabeFeld.Text += 1;
        }

        private void Zahl2_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 2;
        }

        private void Zahl3_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 3;
        }

        private void Zahl4_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 4;
        }

        private void Zahl5_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 5;
        }

        private void Zahl6_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 6;
        }

        private void Zahl7_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 7;
        }

        private void Zahl8_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 8;
        }

        private void Zahl9_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 9;
        }

        private void Zahl0_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += 0;
        }


        

        private void Addiere (string KompletteEingabe) //Methode zum Addieren von Zahlen
        {

            string[] zahlen = KompletteEingabe.Split('+'); // Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double zahl_1 = Convert.ToDouble(zahlen[0]);// Extrahiert die Zahlen aus dem Array
            double zahl_2 = Convert.ToDouble(zahlen[1]);
            double Ergebniss = zahl_1 + zahl_2; // führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses

        }

        private void Subtrahiere(string KompletteEingabe)
        {

            string[] zahlen = KompletteEingabe.Split('-');// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double zahl_1 = Convert.ToDouble(zahlen[0]);// Extrahiert die Zahlen aus dem Array
            double zahl_2 = Convert.ToDouble(zahlen[1]);
            double Ergebniss = zahl_1 - zahl_2;// führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses

        }

        private void Mal (string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split('*');// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double zahl_1 = Convert.ToDouble(zahlen[0]);// Extrahiert die Zahlen aus dem Array
            double zahl_2 = Convert.ToDouble(zahlen[1]);
            double Ergebniss = zahl_1 * zahl_2;// führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }
        private void Dividiere (string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split('/');// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double zahl_1 = Convert.ToDouble(zahlen[0]);// Extrahiert die Zahlen aus dem Array
            double zahl_2 = Convert.ToDouble(zahlen[1]);
            double Ergebniss = zahl_1 / zahl_2;// führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }

        private void Power(string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split('^');// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double Basis = Convert.ToDouble(zahlen[0]);// Extrahiert die Zahlen aus dem Array
            double Exponent = Convert.ToDouble(zahlen[1]);
            double Ergebniss = Math.Pow(Basis, Exponent);// führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }

        private void Radizieren(string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split('√');// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double Radikant = Convert.ToDouble(zahlen[1]);// Extrahiert die Zahlen aus dem Array
            double Ergebniss = Math.Sqrt(Radikant);// führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }

        private void Logarithmieren(string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split("log");// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double Numerus = Convert.ToDouble(zahlen[1]);// Extrahiert die Zahlen aus dem Array
            double Ergebniss = Math.Log(Numerus);// führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }

        private void Faktoriel(string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split("!");// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double Funktionsargument = Convert.ToDouble(zahlen[0]);// Extrahiert die Zahlen aus dem Array
            double temp = 1; // temp für Berechnung von Fakultät
            for (int i = 1; i <= Funktionsargument; i++) // Loop fürs multiplizieren aller Zahlen der Fakultät
            {
                temp *= i;
            }
            double Ergebniss = temp;

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }

        private void Sin(string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split("sin");// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double Winkel = Convert.ToDouble(zahlen[1]);// Extrahiert die Zahlen aus dem Array
            Winkel = Winkel * Math.PI / 180; // Umrechnen von GRAD in RADIANTEN
            double Ergebniss = Math.Sin(Winkel);// führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }

        private void Cos(string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split("tan");// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double Winkel = Convert.ToDouble(zahlen[1]);// Extrahiert die Zahlen aus dem Array
            Winkel = Winkel * Math.PI / 180;// Umrechnen von GRAD in RADIANTEN
            double Ergebniss = Math.Tan(Winkel);// führt die Entsprechende Operation aus und speichert das Ergebniss

            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }

        private void Tan(string KompletteEingabe)
        {
            string[] zahlen = KompletteEingabe.Split("cos");// Splitet die Eingabe und gib sie in ein Arrray basierend auf dem Opeator
            double Winkel = Convert.ToDouble(zahlen[1]);// Extrahiert die Zahlen aus dem Array
            Winkel = Winkel * Math.PI / 180;// Umrechnen von GRAD in RADIANTEN
            double Ergebniss = Math.Cos(Winkel);// führt die Entsprechende Operation aus und speichert das Ergebniss
            EingabeFeld.Text = Convert.ToString(Ergebniss);// Ausgabe des Ergebnisses
        }


        private void istgleich_Click(object sender, EventArgs e) // Methhode fürs Clicken des Istgleich Buttons
        {
            
            string KompletteEingabe = EingabeFeld.Text; // speichert die Eingabe
            if (KompletteEingabe.Contains('+') == true) // if Abfragen ob ein bestimmtes Zeichen vorhanden ist und Ausführen der jewiligen Methode
            {

                Addiere(KompletteEingabe);

            }
            if (KompletteEingabe.Contains('-') == true)
            {

                Subtrahiere(KompletteEingabe);
                
            }
            if (KompletteEingabe.Contains('*') == true)
            {

                Mal(KompletteEingabe);
                
            }
            if (KompletteEingabe.Contains('/') == true)
            {

                Dividiere(KompletteEingabe);
                
            }
            if (KompletteEingabe.Contains('^') == true)
            {

                Power(KompletteEingabe);
                
            }
            if (KompletteEingabe.Contains('√') == true)
            {

                Radizieren(KompletteEingabe);
                
            }
            if (KompletteEingabe.Contains("log") == true)
            {

                Logarithmieren(KompletteEingabe);

            }
            if (KompletteEingabe.Contains("!") == true)
            {

                Faktoriel(KompletteEingabe);
                
            }
            if (KompletteEingabe.Contains("sin") == true)
            {

                Sin(KompletteEingabe);
                
            }
            if (KompletteEingabe.Contains("tan") == true)
            {

                Tan(KompletteEingabe);

            }
            if (KompletteEingabe.Contains("cos") == true)
            {

                Cos(KompletteEingabe);
                
            }
        }

        private void Potenz_Click(object sender, EventArgs e) // Eingabe von den Opeatoren durch Buttons +-*/^√log!sincostan
        {
            EingabeFeld.Text += "^";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "-";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "/";
        }

        private void Multipliziere_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "*";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "+";
        }

        private void Wurzel_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "√";
        }

        private void logarithmus_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "log";
        }

        private void Fakultät_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "!";
        }

        private void Sinus_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "sin";
        }

        private void Cosinus_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "cos";
        }

        private void Tangens_Click(object sender, EventArgs e)
        {
            EingabeFeld.Text += "tan";
        }

        private void Clear_Click(object sender, EventArgs e) // Funktioniert wie ein Backspace löscht nur einen char bei clicken
        {
            if (EingabeFeld.TextLength  >= 1) {
                EingabeFeld.Text = EingabeFeld.Text.Remove(EingabeFeld.TextLength - 1);
            }
            
        }

        private void ClearE_Click(object sender, EventArgs e) // Clear die ganze Eingabe
        {
            EingabeFeld.Clear();
        }

    }
}

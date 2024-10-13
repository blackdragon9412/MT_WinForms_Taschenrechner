namespace MT_WinForms_Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            EingabeFeld = new TextBox();
            Zahl1 = new Button();
            Zahl2 = new Button();
            Zahl3 = new Button();
            Zahl4 = new Button();
            Zahl5 = new Button();
            Zahl6 = new Button();
            Zahl7 = new Button();
            Zahl8 = new Button();
            Zahl9 = new Button();
            Zahl0 = new Button();
            colorDialog1 = new ColorDialog();
            Plus = new Button();
            Minus = new Button();
            Division = new Button();
            Multipliziere = new Button();
            istgleich = new Button();
            Potenz = new Button();
            ClearE = new Button();
            Wurzel = new Button();
            logarithmus = new Button();
            Fakultät = new Button();
            Sinus = new Button();
            Cosinus = new Button();
            Tangens = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Clear = new Button();
            SuspendLayout();
            // 
            // EingabeFeld
            // 
            EingabeFeld.AccessibleDescription = "sad";
            EingabeFeld.Location = new Point(44, 52);
            EingabeFeld.Name = "EingabeFeld";
            EingabeFeld.Size = new Size(172, 23);
            EingabeFeld.TabIndex = 0;
            // 
            // Zahl1
            // 
            Zahl1.Location = new Point(48, 108);
            Zahl1.Name = "Zahl1";
            Zahl1.Size = new Size(75, 23);
            Zahl1.TabIndex = 1;
            Zahl1.Text = "1";
            Zahl1.UseVisualStyleBackColor = true;
            Zahl1.Click += Zahl1_Click;
            // 
            // Zahl2
            // 
            Zahl2.Location = new Point(141, 108);
            Zahl2.Name = "Zahl2";
            Zahl2.Size = new Size(75, 23);
            Zahl2.TabIndex = 2;
            Zahl2.Text = "2";
            Zahl2.UseVisualStyleBackColor = true;
            Zahl2.Click += Zahl2_Click;
            // 
            // Zahl3
            // 
            Zahl3.Location = new Point(48, 137);
            Zahl3.Name = "Zahl3";
            Zahl3.Size = new Size(75, 23);
            Zahl3.TabIndex = 3;
            Zahl3.Text = "3";
            Zahl3.UseVisualStyleBackColor = true;
            Zahl3.Click += Zahl3_Click;
            // 
            // Zahl4
            // 
            Zahl4.Location = new Point(141, 137);
            Zahl4.Name = "Zahl4";
            Zahl4.Size = new Size(75, 23);
            Zahl4.TabIndex = 4;
            Zahl4.Text = "4";
            Zahl4.UseVisualStyleBackColor = true;
            Zahl4.Click += Zahl4_Click;
            // 
            // Zahl5
            // 
            Zahl5.Location = new Point(48, 166);
            Zahl5.Name = "Zahl5";
            Zahl5.Size = new Size(75, 23);
            Zahl5.TabIndex = 5;
            Zahl5.Text = "5";
            Zahl5.UseVisualStyleBackColor = true;
            Zahl5.Click += Zahl5_Click;
            // 
            // Zahl6
            // 
            Zahl6.Location = new Point(141, 166);
            Zahl6.Name = "Zahl6";
            Zahl6.Size = new Size(75, 23);
            Zahl6.TabIndex = 6;
            Zahl6.Text = "6";
            Zahl6.UseVisualStyleBackColor = true;
            Zahl6.Click += Zahl6_Click;
            // 
            // Zahl7
            // 
            Zahl7.Location = new Point(48, 195);
            Zahl7.Name = "Zahl7";
            Zahl7.Size = new Size(75, 23);
            Zahl7.TabIndex = 7;
            Zahl7.Text = "7";
            Zahl7.UseVisualStyleBackColor = true;
            Zahl7.Click += Zahl7_Click;
            // 
            // Zahl8
            // 
            Zahl8.Location = new Point(141, 195);
            Zahl8.Name = "Zahl8";
            Zahl8.Size = new Size(75, 23);
            Zahl8.TabIndex = 8;
            Zahl8.Text = "8";
            Zahl8.UseVisualStyleBackColor = true;
            Zahl8.Click += Zahl8_Click;
            // 
            // Zahl9
            // 
            Zahl9.Location = new Point(48, 224);
            Zahl9.Name = "Zahl9";
            Zahl9.Size = new Size(75, 23);
            Zahl9.TabIndex = 9;
            Zahl9.Text = "9";
            Zahl9.UseVisualStyleBackColor = true;
            Zahl9.Click += Zahl9_Click;
            // 
            // Zahl0
            // 
            Zahl0.Location = new Point(141, 224);
            Zahl0.Name = "Zahl0";
            Zahl0.Size = new Size(75, 23);
            Zahl0.TabIndex = 10;
            Zahl0.Text = "0";
            Zahl0.UseVisualStyleBackColor = true;
            Zahl0.Click += Zahl0_Click;
            // 
            // Plus
            // 
            Plus.Location = new Point(271, 114);
            Plus.Name = "Plus";
            Plus.Size = new Size(75, 23);
            Plus.TabIndex = 11;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(271, 143);
            Minus.Name = "Minus";
            Minus.Size = new Size(75, 23);
            Minus.TabIndex = 12;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Division
            // 
            Division.Location = new Point(271, 172);
            Division.Name = "Division";
            Division.Size = new Size(75, 23);
            Division.TabIndex = 13;
            Division.Text = "/";
            Division.UseVisualStyleBackColor = true;
            Division.Click += Division_Click;
            // 
            // Multipliziere
            // 
            Multipliziere.Location = new Point(271, 201);
            Multipliziere.Name = "Mal";
            Multipliziere.Size = new Size(75, 23);
            Multipliziere.TabIndex = 14;
            Multipliziere.Text = "*";
            Multipliziere.UseVisualStyleBackColor = true;
            Multipliziere.Click += Multipliziere_Click;
            // 
            // istgleich
            // 
            istgleich.Location = new Point(271, 230);
            istgleich.Name = "istgleich";
            istgleich.Size = new Size(75, 23);
            istgleich.TabIndex = 15;
            istgleich.Text = "=";
            istgleich.UseVisualStyleBackColor = true;
            istgleich.Click += istgleich_Click;
            // 
            // Potenz
            // 
            Potenz.Location = new Point(380, 114);
            Potenz.Name = "Potenz";
            Potenz.Size = new Size(75, 23);
            Potenz.TabIndex = 16;
            Potenz.Text = "^";
            Potenz.UseVisualStyleBackColor = true;
            Potenz.Click += Potenz_Click;
            // 
            // ClearE
            // 
            ClearE.Location = new Point(66, 300);
            ClearE.Name = "ClearE";
            ClearE.Size = new Size(119, 58);
            ClearE.TabIndex = 17;
            ClearE.Text = "ClearE";
            ClearE.UseVisualStyleBackColor = true;
            ClearE.Click += ClearE_Click;
            // 
            // Wurzel
            // 
            Wurzel.Location = new Point(380, 143);
            Wurzel.Name = "Wurzel";
            Wurzel.Size = new Size(75, 23);
            Wurzel.TabIndex = 18;
            Wurzel.Text = "√ ";
            Wurzel.UseVisualStyleBackColor = true;
            Wurzel.Click += Wurzel_Click;
            // 
            // logarithmus
            // 
            logarithmus.Location = new Point(380, 172);
            logarithmus.Name = "logarithmus";
            logarithmus.Size = new Size(75, 23);
            logarithmus.TabIndex = 19;
            logarithmus.Text = "log";
            logarithmus.UseVisualStyleBackColor = true;
            logarithmus.Click += logarithmus_Click;
            // 
            // Fakultät
            // 
            Fakultät.Location = new Point(380, 201);
            Fakultät.Name = "Fakultät";
            Fakultät.Size = new Size(75, 23);
            Fakultät.TabIndex = 20;
            Fakultät.Text = "!";
            Fakultät.UseVisualStyleBackColor = true;
            Fakultät.Click += Fakultät_Click;
            // 
            // Sinus
            // 
            Sinus.Location = new Point(380, 230);
            Sinus.Name = "Sinus";
            Sinus.Size = new Size(75, 23);
            Sinus.TabIndex = 21;
            Sinus.Text = "sin";
            Sinus.UseVisualStyleBackColor = true;
            Sinus.Click += Sinus_Click;
            // 
            // Cosinus
            // 
            Cosinus.Location = new Point(479, 114);
            Cosinus.Name = "Cosinus";
            Cosinus.Size = new Size(75, 23);
            Cosinus.TabIndex = 22;
            Cosinus.Text = "cos";
            Cosinus.UseVisualStyleBackColor = true;
            Cosinus.Click += Cosinus_Click;
            // 
            // Tangens
            // 
            Tangens.Location = new Point(479, 143);
            Tangens.Name = "Tangens";
            Tangens.Size = new Size(75, 23);
            Tangens.TabIndex = 23;
            Tangens.Text = "tan";
            Tangens.UseVisualStyleBackColor = true;
            Tangens.Click += Tangens_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Clear
            // 
            Clear.Location = new Point(207, 300);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 24;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Clear);
            Controls.Add(Tangens);
            Controls.Add(Cosinus);
            Controls.Add(Sinus);
            Controls.Add(Fakultät);
            Controls.Add(logarithmus);
            Controls.Add(Wurzel);
            Controls.Add(ClearE);
            Controls.Add(Potenz);
            Controls.Add(istgleich);
            Controls.Add(Multipliziere);
            Controls.Add(Division);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(Zahl0);
            Controls.Add(Zahl9);
            Controls.Add(Zahl8);
            Controls.Add(Zahl7);
            Controls.Add(Zahl6);
            Controls.Add(Zahl5);
            Controls.Add(Zahl4);
            Controls.Add(Zahl3);
            Controls.Add(Zahl2);
            Controls.Add(Zahl1);
            Controls.Add(EingabeFeld);
            Name = "Form1";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EingabeFeld;
        private Button Zahl1;
        private Button Zahl2;
        private Button Zahl3;
        private Button Zahl4;
        private Button Zahl5;
        private Button Zahl6;
        private Button Zahl7;
        private Button Zahl8;
        private Button Zahl9;
        private Button Zahl0;
        private ColorDialog colorDialog1;
        private Button Plus;
        private Button Minus;
        private Button Division;
        private Button Multipliziere;
        private Button istgleich;
        private Button Potenz;
        private Button ClearE;
        private Button Wurzel;
        private Button logarithmus;
        private Button Fakultät;
        private Button Sinus;
        private Button Cosinus;
        private Button Tangens;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Clear;
    }
}

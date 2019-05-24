namespace CalkiNumeryczne
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.EqualsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EPSnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ThreePowernumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TwonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PowernumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPSnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreePowernumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowernumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AnumericUpDown
            // 
            this.AnumericUpDown.Location = new System.Drawing.Point(12, 24);
            this.AnumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.AnumericUpDown.Name = "AnumericUpDown";
            this.AnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.AnumericUpDown.TabIndex = 0;
            // 
            // BnumericUpDown
            // 
            this.BnumericUpDown.DecimalPlaces = 2;
            this.BnumericUpDown.Location = new System.Drawing.Point(179, 24);
            this.BnumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.BnumericUpDown.Name = "BnumericUpDown";
            this.BnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.BnumericUpDown.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 117);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Oblicz";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EqualsTextBox
            // 
            this.EqualsTextBox.Location = new System.Drawing.Point(334, 117);
            this.EqualsTextBox.Name = "EqualsTextBox";
            this.EqualsTextBox.Size = new System.Drawing.Size(165, 22);
            this.EqualsTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // EPSnumericUpDown
            // 
            this.EPSnumericUpDown.Location = new System.Drawing.Point(360, 24);
            this.EPSnumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.EPSnumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.EPSnumericUpDown.Name = "EPSnumericUpDown";
            this.EPSnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.EPSnumericUpDown.TabIndex = 6;
            this.EPSnumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Liczba przedziałów";
            // 
            // ThreePowernumericUpDown
            // 
            this.ThreePowernumericUpDown.DecimalPlaces = 2;
            this.ThreePowernumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ThreePowernumericUpDown.Location = new System.Drawing.Point(15, 69);
            this.ThreePowernumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThreePowernumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.ThreePowernumericUpDown.Name = "ThreePowernumericUpDown";
            this.ThreePowernumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.ThreePowernumericUpDown.TabIndex = 9;
            // 
            // TwonumericUpDown
            // 
            this.TwonumericUpDown.DecimalPlaces = 2;
            this.TwonumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TwonumericUpDown.Location = new System.Drawing.Point(126, 71);
            this.TwonumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TwonumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.TwonumericUpDown.Name = "TwonumericUpDown";
            this.TwonumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.TwonumericUpDown.TabIndex = 10;
            // 
            // PowernumericUpDown
            // 
            this.PowernumericUpDown.DecimalPlaces = 2;
            this.PowernumericUpDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PowernumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PowernumericUpDown.Location = new System.Drawing.Point(241, 71);
            this.PowernumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PowernumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.PowernumericUpDown.Name = "PowernumericUpDown";
            this.PowernumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.PowernumericUpDown.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "x^3+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "x^2+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "x*sinx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "=Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Wynik";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(614, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 356);
            this.listBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PowernumericUpDown);
            this.Controls.Add(this.TwonumericUpDown);
            this.Controls.Add(this.ThreePowernumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EPSnumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EqualsTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BnumericUpDown);
            this.Controls.Add(this.AnumericUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPSnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreePowernumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowernumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AnumericUpDown;
        private System.Windows.Forms.NumericUpDown BnumericUpDown;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox EqualsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EPSnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ThreePowernumericUpDown;
        private System.Windows.Forms.NumericUpDown TwonumericUpDown;
        private System.Windows.Forms.NumericUpDown PowernumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
    }
}


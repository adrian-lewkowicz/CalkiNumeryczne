using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalkiNumeryczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double threePower;
        double twoPower;
        double onePower;
        double A;
        double B;
        int lp;
        double[] x = new double[100];
        private void StartButton_Click(object sender, EventArgs e)
        {
            initializeValues();
            double[,] tab = new double[lp + 1, lp + 1];
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                tab[0, i] = A + ((double)i / (double)lp);
                listBox1.Items.Add(tab[0, i]);
                tab[1, i] = oblicz(tab[0, i]);
                listBox1.Items.Add(tab[1, i]);
            }
            double h = ((B-A) / lp)/3;
            double suma = tab[1,0]+tab[1,tab.GetLength(1)-1];
            suma =suma+ 2*(tab[1, 1] + tab[1, tab.GetLength(1) - 2]);
            for (int i = 2; i < tab.GetLength(0)-2; i++)
            {
                 suma += 4 * tab[1, i]; 
            }
            double wynik = suma * h;
            EqualsTextBox.Text = wynik.ToString();
        }
        void initializeValues()
        {
            A = (double)AnumericUpDown.Value;
            B = (double)BnumericUpDown.Value;
            threePower = (double)ThreePowernumericUpDown.Value;
            twoPower = (double)TwonumericUpDown.Value;
            onePower = (double)PowernumericUpDown.Value;
            lp = (int)EPSnumericUpDown.Value;
        }
        double oblicz(double x)
        {
            return threePower* Math.Pow(x, 3) +twoPower* Math.Pow(x, 2) + onePower*Math.Pow(x, 1)*Math.Sin(x) ;
        }

    }
}

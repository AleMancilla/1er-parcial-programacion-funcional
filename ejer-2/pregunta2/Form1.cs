using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta2
{
    public partial class Form1 : Form
    {
        int pantalla;
        int primervalor;
        int segundovalor;
        String operador;
        public Form1()
        {
            InitializeComponent();
            pantalla = 0;
        }

        Clases.ClassSuma obj1 = new Clases.ClassSuma();
        Clases.ClassResta obj2 = new Clases.ClassResta();
        Clases.ClassMultiplicacion obj3 = new Clases.ClassMultiplicacion();
        Clases.ClassDivision obj4 = new Clases.ClassDivision();

        private void Clickeo(object sender, EventArgs e)
        {
            pantalla = pantalla * 10 + Convert.ToInt32(((Button)sender).Text);
            textBox1.Text = pantalla.ToString();
        }
        private void limpiar(object sender, EventArgs e)
        {
            pantalla = 0;
            textBox1.Clear();
        }
        private void suma(object sender, EventArgs e)
        {
            operador = "suma";
            primervalor = pantalla;
            pantalla = 0;
            textBox1.Clear();
        }
        private void resta(object sender, EventArgs e)
        {
            operador = "resta";
            primervalor = pantalla;
            pantalla = 0;
            textBox1.Clear();
        }
        private void multiplicacion(object sender, EventArgs e)
        {
            operador = "multiplicacion";
            primervalor = pantalla;
            pantalla = 0;
            textBox1.Clear();
        }
        private void division(object sender, EventArgs e)
        {
            operador = "division";
            primervalor = pantalla;
            pantalla = 0;
            textBox1.Clear();
        }
        private void resultado(object sender, EventArgs e)
        {
            int sum;
            int res;
            int mul;
            int div;
            segundovalor = pantalla;
            textBox1.Clear();
            switch (operador)
            {
                case "suma":
                    sum = obj1.Sumar(primervalor, segundovalor);
                    textBox1.Text = sum.ToString();
                    break;
                case "resta":
                    res = obj2.Restar(primervalor, segundovalor);
                    textBox1.Text = res.ToString();
                    break;
                case "multiplicacion":
                    mul = obj3.Multiplicar(primervalor, segundovalor);
                    textBox1.Text = mul.ToString();
                    break;
                case "division":
                    div = obj4.Dividir(primervalor, segundovalor);
                    textBox1.Text = div.ToString();
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "";
                pantalla = 0;
            }
            else
            {
                String cadena = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.Text = cadena;
                pantalla = Convert.ToInt32(cadena);
            }
        }
    }
}

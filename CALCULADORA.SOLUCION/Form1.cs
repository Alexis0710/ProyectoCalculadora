using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA.SOLUCION
{
    public partial class Form1 : Form
    {
        double Uno;
        double Dos;
        double Resultado;
        String Operaciones;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtExpresion.Text  = txtExpresion.Text  + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = txtExpresion.Text + ".";
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            Operaciones = "+";
            Uno = double.Parse(txtExpresion.Text);
            txtExpresion.Clear();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            Operaciones = "-";
            Uno = double.Parse(txtExpresion.Text);
            txtExpresion.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            Operaciones = "*";
            Uno = double.Parse(txtExpresion.Text);
            txtExpresion.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Operaciones = "/";
            Uno = double.Parse(txtExpresion.Text);
            txtExpresion.Clear();
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            Dos = double.Parse(txtExpresion.Text);

            switch (Operaciones)
            {
                case "+": Resultado = Uno + Dos;
                    txtExpresion.Text = Resultado.ToString();
                    break;
                case "-": Resultado = Uno - Dos;
                    txtExpresion.Text = Resultado.ToString();
                    break;
                case "*": Resultado = Uno * Dos;
                    txtExpresion.Text = Resultado.ToString();
                    break;
                case "/": Resultado = Uno / Dos;
                    txtExpresion.Text = Resultado.ToString();
                    break;
                   }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtExpresion.Clear();
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            Operaciones = "Sqrt";
            Uno = double.Parse(txtExpresion.Text);
            Resultado = Uno;
            txtExpresion.Text = Math.Sqrt(Uno).ToString();
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            Operaciones = "Sin";
            Uno = Double.Parse(txtExpresion.Text) * Math.PI / 180.0;
            Resultado = Uno;
            txtExpresion.Text = Math.Sin(Uno).ToString();
         
       }

        private void btnCos_Click(object sender, EventArgs e)
        {
            Operaciones = "Cos";
            Uno = Double.Parse(txtExpresion.Text) * Math.PI / 180.0;
            Resultado = Uno;
            txtExpresion.Text = Math.Cos(Uno).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            Operaciones = "Tan";
            Uno = Double.Parse(txtExpresion.Text) * Math.PI / 180.0;
            Resultado = Uno;
            txtExpresion.Text = Math.Tan(Uno).ToString();

        }
    }
}

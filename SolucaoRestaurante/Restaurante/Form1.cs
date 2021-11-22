using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            //Convertendo dados dos inputs
            /*Comentário
             * várias
             * linhas
             */
            Int32 dividendo = Convert.ToInt32(txtDividendo.Text);
            Int32 divisor = Convert.ToInt32(txtDivisor.Text);
            
            //Calculando o resto da divisão
            Int32 resto = dividendo % divisor;
            //txtResto.Text = Convert.ToString(resto);
            txtResto.Text = resto.ToString();

        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Evento de click do botão Calcular
            Double vlrDespesa = Convert.ToDouble(txtDespesa.Text);
            Double vlrTotal = vlrDespesa * 1.10;
            txtTotalDespesa.Text = vlrTotal.ToString();
            //txtTotalDespesa.BackColor = Color.Blue;

        }
    }
}

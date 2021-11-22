using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validações...
            string turno = null;
            float salario;
            string msgErro = "";
            string categoria = "";
            
            //Validando o turno
            if (Matutino.Checked)
            {
                turno = "Matutino";
            }
            else if (Vespertino.Checked)
            {
                turno = "Vespertino";
            }
            else if (Noturno.Checked)
            {
                turno = "Noturno";
            }
            else
            {
                msgErro += "Informe o turno.\n";
            }

            if (String.IsNullOrEmpty(salMinimo.Text))
            {
                msgErro += "Informe o salário.\n";
            }

            if (String.IsNullOrEmpty(hraTrabalhada.Text))
            {
                msgErro += "Informe a quantidade de horas trabalhadas.\n";
            }

            //Categoria
            if (catCalouro.Checked)
            {
                categoria = "Calouro";
            }
            else if (catVeterano.Checked)
            {
                categoria = "Veterano";
            }
            else
            {
                msgErro += "Informe a categoria.";
            }

            if (String.IsNullOrEmpty(msgErro))
            {
                //Informou todos os dados
                Double coeficiente, salarioBruto, salarioLiquido, desconto;
                coeficiente = calculaCoeficiente(salMinimo.Text, turno);

                salarioBruto = Convert.ToDouble(salMinimo.Text) + coeficiente;

                desconto = calculaImpostoSalario(salMinimo.Text, categoria);

                salarioLiquido = salarioBruto - desconto;

                MessageBox.Show("Salário bruto: " + salarioBruto.ToString() + " | Salário líquido: " + salarioLiquido.ToString() );

            }
            else
            {
                MessageBox.Show("Encontramos alguns erros: \n" + msgErro, "ERRO!");
            }


        }


        /// <summary>
        /// Calcula o coeficiênte do salário
        /// </summary>
        /// <param name="pSalario">Salário</param>
        /// <param name="pTurno">Turno</param>
        public Double calculaCoeficiente(string pSalario, String pTurno)
        {
            try
            {
                double vlrCoeficiente = 0;
                if (pTurno == "Matutino")
                {
                    //1° salário mínimo
                    vlrCoeficiente = Convert.ToDouble(pSalario) * 0.01;
                }
                else if (pTurno == "Vespertino")
                {
                    //2° salário mínimo
                    vlrCoeficiente = Convert.ToDouble(pSalario) * 0.02;
                }
                else
                {
                    //3° salário mínimo
                    vlrCoeficiente = Convert.ToDouble(pSalario) * 0.03;
                }
                return vlrCoeficiente;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro não tratado foi encontrado: " + e.Message.ToString());
                throw;
            }
            finally
            {
                MessageBox.Show("Executando o Finally!");
            }

        }
        


        /// <summary>
        /// Calcula o imposto sobre o salário bruto do funcionário
        /// </summary>
        /// <param name="pSalario"></param>
        /// <param name="pCategoria"></param>
        /// <returns></returns>
        public Double calculaImpostoSalario(string pSalario, string pCategoria)
        {
            try
            {
                double desconto = 0;

                if(pCategoria == "Calouro")
                {
                    if(Convert.ToDouble(pSalario) < 300)
                    {
                        desconto = Convert.ToDouble(pSalario) * 0.01;
                    }
                    else
                    {
                        desconto = Convert.ToDouble(pSalario) * 0.02;
                    }                    
                }
                else
                {
                    if (Convert.ToDouble(pSalario) < 400)
                    {
                        desconto = Convert.ToDouble(pSalario) * 0.03;
                    }
                    else
                    {
                        desconto = Convert.ToDouble(pSalario) * 0.04;
                    }
                }
                return desconto;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro não tratado foi encontrado: " + e.Message.ToString());
                throw;
            }
        }




    }
}

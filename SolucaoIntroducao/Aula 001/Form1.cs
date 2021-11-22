using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_001
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCli cadCli = new FrmCadCli();
            cadCli.ShowDialog();
        }

        private void clientesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei aqui!");

        }
    }
}

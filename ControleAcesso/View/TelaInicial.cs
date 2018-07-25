using ControleAcesso.View;
using ControleAcesso.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroClienteMenu_Click(object sender, EventArgs e)
        {
            CadastroCliente.GetForm.Show();
        }

        private void cadastroCatracaMenu_Click(object sender, EventArgs e)
        {
            CadastroCatraca.GetForm.Show();
        }

        private void cadastroPlanoMenu_Click(object sender, EventArgs e)
        {
            CadastroPlano.GetForm.Show();
        }

        private void statusCatracaMenu_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

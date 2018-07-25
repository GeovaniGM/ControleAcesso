using ControleAcesso.Controller;
using ControleAcesso.DAO;
using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso.View
{
    public partial class CadastroCliente : BaseForm
    {
        #region Construtor
        private CadastroCliente()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        private static CadastroCliente instance;
        public static CadastroCliente Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new CadastroCliente();

                return instance;
            }
        }
        #endregion

        #region Events
        #region Buttons
        private void SaveButton(object sender, EventArgs e)
        {

            /*if (ClienteDAO.Add(Cliente))
                MessageBox.Show($"Id : {Cliente.Id}\n" +
                                $"Codigo : {Cliente.Codigo}\n" +
                                $"Nome : {Cliente.Nome}\n" +
                                $"CPF : {Cliente.CPF}\n" +
                                $"RG : {Cliente.RG}\n" +
                                $"Data de Nascimento : {Cliente.DataNascimento}\n" +
                                $"Plano : {Cliente.Plano}\n" +
                                $"Ativo : {Cliente.Ativo}", "Successo");
            else
                MessageBox.Show("Ocorreu algum erro. Verifique o código!!!", "Fudeu Maluco");
            this.Close();*/

            CadastroClienteController.Instance.SalvarCliente();
            this.Close();
        }

        new private void CancelButton(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Object Changed
        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            CadastroClienteController.Instance.NomeChanged(txtNome.Text);
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            CadastroClienteController.Instance.CPFChanged(txtCPF.Text);
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            CadastroClienteController.Instance.RGChanged(txtRG.Text);
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            CadastroClienteController.Instance.DataNascimentoChanged(dtpDataNascimento.Value);
        }

        private void comboPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            CadastroClienteController.Instance.PlanoChanged((Plano)comboPlano.SelectedIndex);
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CadastroClienteController.Instance.AtivoChanged(chkAtivo.Checked);
        }
        #endregion
        #endregion

        #region Methods
        private void InitializeObject(Action<bool> _action, Cliente _cliente = null)
        {
            Instance.Show();
            CadastroClienteController.Instance.IniciarCadastro(_action, _cliente);
        }

        public void Cadastrar(Action<bool> _action, Cliente _cliente = null)
        {
            InitializeObject(_action, _cliente);
        }

        public void AtualizarCampos(Cliente _cliente)
        {
            txtNome.Text = _cliente.Nome;
            txtCPF.Text = _cliente.CPF;
            txtRG.Text = _cliente.RG;
            dtpDataNascimento.Value = _cliente.DataNascimento > DateTime.MinValue ? _cliente.DataNascimento.Date : DateTime.Now.Date;
            comboPlano.SelectedIndex = (int)_cliente.Plano;
            chkAtivo.Checked = _cliente.Ativo;
        }
        #endregion
    }
}
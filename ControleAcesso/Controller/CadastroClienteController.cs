using ControleAcesso.DAO;
using ControleAcesso.Model;
using ControleAcesso.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso.Controller
{
    public class CadastroClienteController : BaseObject
    {
        #region Construtor
        private CadastroClienteController() { }
        #endregion

        #region Properties
        private static CadastroClienteController instance;
        public static CadastroClienteController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CadastroClienteController();

                return instance;
            }
        }

        private Cliente cliente;
        public Cliente Cliente
        {
            get { return cliente; }
            set { Set(ref cliente, value); }
        }

        private Action<bool> sucessoSalvar;
        public Action<bool> SucessoSalvar
        {
            get { return sucessoSalvar; }
            set { Set(ref sucessoSalvar, value); }
        }

        private bool atualizar;
        public bool Atualizar
        {
            get { return atualizar; }
            private set { Set(ref atualizar, value); }
        }
        #endregion

        #region Methods
        public void SalvarCliente()
        {
            if (Atualizar)
            {
                if(ClienteDAO.Instance.Update(Cliente))
                {
                    MessageBox.Show($"O cliente {Cliente.Nome} foi atualizado com sucesso!", "Sucesso");
                    SucessoSalvar(true);
                }
            }
            else
            {
                if (ClienteDAO.Instance.Add(Cliente))
                {
                    SucessoSalvar(true);
                    MessageBox.Show($"Nome : {Cliente.Nome}\n" +
                                    $"CPF : {Cliente.CPF}\n" +
                                    $"RG : {Cliente.RG}\n" +
                                    $"Data de Nascimento : {Cliente.DataNascimento}\n" +
                                    $"Plano : {Cliente.Plano}\n" +
                                    $"Ativo : {Cliente.Ativo}", "Successo");
                }
                else
                {
                    SucessoSalvar(false);
                }
            }
        }

        internal void IniciarCadastro(Action<bool> _action, Cliente _cliente)
        {
            SucessoSalvar = _action;
            Atualizar = _cliente != null && _cliente.Id != Guid.Empty;
            if (Atualizar)
            {
                Cliente = _cliente;
                CadastroCliente.Instance.AtualizarCampos(Cliente);
            }
            else
                Cliente = new Cliente();
        }

        private void ClonarCliente(Cliente _cliente)
        {
            Cliente = new Cliente()
            {
                Id = _cliente.Id,
                Nome = _cliente.Nome,
                CPF = _cliente.CPF,
                RG = _cliente.RG,
                Ativo = _cliente.Ativo,
                DataNascimento = _cliente.DataNascimento,
                Plano = _cliente.Plano
            };
        }

        internal void AtivoChanged(bool _checked)
        {
            Cliente.Ativo = _checked;
        }

        internal void NomeChanged(string _nome)
        {
            Cliente.Nome = _nome;
        }

        internal void PlanoChanged(Plano _plano)
        {
            Cliente.Plano = _plano;
        }

        internal void DataNascimentoChanged(DateTime _dataNascimento)
        {
            Cliente.DataNascimento = _dataNascimento;
        }

        internal void RGChanged(string _rg)
        {
            Cliente.RG = _rg;
        }

        internal void CPFChanged(string _cpf)
        {
            Cliente.CPF = _cpf;
        }
        #endregion
    }
}
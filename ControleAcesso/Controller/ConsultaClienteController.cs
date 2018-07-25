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
    public class ConsultaClienteController : BaseObject
    {
        #region Construtor
        private ConsultaClienteController()
        {
            InitializeObject();
        }
        #endregion

        #region Properties
        private static ConsultaClienteController instance;
        public static ConsultaClienteController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConsultaClienteController();

                return instance;
            }
        }

        private IList<Cliente> clientes;
        public IList<Cliente> Clientes
        {
            get { return clientes; }
            internal set { Set(ref clientes, value); }
        }

        private DataGridView dgvClientes;
        public DataGridView DgvClientes
        {
            get { return dgvClientes; }
            set { Set(ref dgvClientes, value); }
        }
        #endregion

        #region Methods
        private void InitializeObject()
        {
        }

        public void BuscarClientes(DataGridView _dataGridView)
        {
            DgvClientes = _dataGridView;
            DgvClientes.DataSource = ClienteDAO.Instance.Get();
        }

        public bool AdicionarCliente()
        {
            CadastroCliente.Instance.Cadastrar((atualizar) =>
            {
                if (atualizar)
                    DgvClientes.DataSource = ClienteDAO.Instance.Get();
            }, new Cliente());
            return true;
        }

        public bool ExcluirCliente(DataGridViewRow dgvRow)
        {
            if (MessageBox.Show("Deseja excluir o(s) cliente(s) selecionado?", "Exclusão de Cliente", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return false;

            if (ClienteDAO.Instance.Delete((Guid)dgvRow.Cells[2].Value))
            {
                MessageBox.Show("Cliente excluído com sucesso!");
                DgvClientes.DataSource = ClienteDAO.Instance.Get();
            }

            return true;
        }

        public bool EditarCliente(DataGridViewRow dgvRow)
        {
            Cliente _cliente = ClienteDAO.Instance.GetById((Guid)dgvRow.Cells[2].Value);
            CadastroCliente.Instance.Cadastrar((atualizar) =>
            {
                if (atualizar)
                    DgvClientes.DataSource = ClienteDAO.Instance.Get();
            }, _cliente);
            return true;
        }
        #endregion
    }
}

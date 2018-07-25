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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private static CadastroCliente cadastroCliente;
        public static CadastroCliente GetForm
        {
            get
            {
                if (cadastroCliente == null || cadastroCliente.IsDisposed)
                    cadastroCliente = new CadastroCliente();

                return cadastroCliente;
            }
        }
    }
}

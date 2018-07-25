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
    public partial class CadastroPlano : Form
    {
        public CadastroPlano()
        {
            InitializeComponent();
        }

        private static CadastroPlano cadastroPlano;
        public static CadastroPlano GetForm
        {
            get
            {
                if (cadastroPlano == null || cadastroPlano.IsDisposed)
                    cadastroPlano = new CadastroPlano();

                return cadastroPlano;
            }
        }
    }
}

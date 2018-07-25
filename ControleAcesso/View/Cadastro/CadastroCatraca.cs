using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso.View.Cadastro
{
    public partial class CadastroCatraca : Form
    {
        public CadastroCatraca()
        {
            InitializeComponent();
        }

        private static CadastroCatraca cadastroCatraca;
        public static CadastroCatraca GetForm
        {
            get
            {
                if (cadastroCatraca == null || cadastroCatraca.IsDisposed)
                    cadastroCatraca = new CadastroCatraca();

                return cadastroCatraca;
            }
        }
    }
}

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
    public partial class StatusCatraca : Form
    {
        public StatusCatraca()
        {
            InitializeComponent();
        }

        private void CatracaLiberada()
        {
            //if (checkBox1.Checked)
            //{
            //    label2.Text = "✓";
            //    label2.ForeColor = Color.Green;
            //}
            //else
            //{
            //    label2.Text = "X";
            //    label2.ForeColor = Color.Red;
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CatracaLiberada();
        }

        private static StatusCatraca statusCatraca;
        public static StatusCatraca GetForm
        {
            get
            {
                if (statusCatraca == null || statusCatraca.IsDisposed)
                    statusCatraca = new StatusCatraca();

                return statusCatraca;
            }
        }
    }
}

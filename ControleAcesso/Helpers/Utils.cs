using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso
{
    public static class Utils
    {
        public static double CalculaRaio(double _circunferencia)
        {
            return Math.Round(_circunferencia / (2 * Math.PI), 1);
        }
    }
}

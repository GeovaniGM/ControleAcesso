using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Model
{
    public class Cliente : Pessoa
    {
        #region Construtor
        public Cliente()
        {
            Ativo = true;
        }
        #endregion

        #region Propriedades
        private bool ativo;
        public bool Ativo
        {
            get { return ativo; }
            set { Set(ref ativo, value); }
        }

        private Plano plano;
        public Plano Plano
        {
            get { return plano; }
            set { Set(ref plano, value); }
        }
        #endregion
    }
}

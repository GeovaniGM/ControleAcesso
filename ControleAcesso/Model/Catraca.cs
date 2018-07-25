using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Model
{
    public class Catraca : BaseObject
    {
        #region Construtor
        public Catraca()
        {

        }
        #endregion

        #region Propriedades
        private Guid id;
        public Guid Id
        {
            get { return id; }
            set { Set(ref id, value); }
        }

        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { Set(ref titulo, value); }
        }

        private bool liberada;
        public bool Liberada
        {
            get { return liberada; }
            set { Set(ref liberada, value); }
        }

        private bool operando;
        public bool Operando
        {
            get { return operando; }
            set { Set(ref operando, value); }
        }
        #endregion
    }
}

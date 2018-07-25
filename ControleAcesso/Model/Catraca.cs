using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Model
{
    public class Catraca : BaseModel
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

        private bool liberada;
        public bool Liberada
        {
            get { return liberada; }
            set { Set(ref liberada, value); }
        }

        private bool manutencao;
        public bool Manutencao
        {
            get { return manutencao; }
            set { Set(ref manutencao, value); }
        }


        #endregion
    }
}

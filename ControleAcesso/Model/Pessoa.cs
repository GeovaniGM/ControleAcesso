using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Model
{
    public class Pessoa : BaseObject
    {
        #region Property
        private Guid id;
        public Guid Id
        {
            get { return id; }
            set { Set(ref id, value); }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { Set(ref nome, value); }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento > DateTime.MinValue ? dataNascimento.Date : DateTime.Now.Date; }
            set { Set(ref dataNascimento, value.Date); }
        }

        private string cpf;
        public string CPF
        {
            get { return cpf; }
            set { Set(ref cpf, value); }
        }

        private string rg;
        public string RG
        {
            get { return rg; }
            set { Set(ref rg, value); }
        }

        #endregion

        #region Construtor

        #endregion
    }
}

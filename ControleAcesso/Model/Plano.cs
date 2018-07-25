using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Model
{
    public class Plano : BaseModel
    {
        private Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { Set(ref titulo, value); }
        }

        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }


    }
}

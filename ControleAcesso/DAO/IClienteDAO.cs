using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.DAO
{
    interface IClienteDAO
    {
        bool Add(Cliente cliente);
        bool Add(IList<Cliente> clientes);
        bool Delete(Cliente cliente);
        bool Delete(IList<Cliente> clientes);
        bool Update(Cliente cliente);
        bool Update(IList<Cliente> clientes);
        Cliente GetById(Guid idCliente);
        IList<Cliente> Get();
    }
}

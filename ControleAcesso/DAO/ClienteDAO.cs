using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.DAO
{
    public class ClienteDAO : BaseObject, IClienteDAO
    {
        #region Properties
        private AcademiaContext context;

        private static ClienteDAO instance;
        public static ClienteDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClienteDAO();
                return instance;
            }
            
        }
        #endregion

        #region Construtor
        private ClienteDAO()
        {
            if (context == null)
                context = new AcademiaContext();
        }
        #endregion

        #region Methods
        #region Insert

        /// <summary>
        /// Include a client in the database
        /// </summary>
        /// <param name="cliente">Client to be added in the database</param>
        /// <returns>Success of the addition</returns>
        public bool Add(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            return context.SaveChanges() > 0;
        }

        /// <summary>
        /// Include a list of clients in the database
        /// </summary>
        /// <param name="clientes">List of clients to be added in the database</param>
        /// <returns>Success of the addition</returns>
        public bool Add(IList<Cliente> clientes)
        {
            context.Clientes.AddRange(clientes);
            return context.SaveChanges() > 0;
        }

        #endregion

        #region Delete

        /// <summary>
        /// Delete a client register from the database
        /// </summary>
        /// <param name="id">Id of the client to be deleted</param>
        /// <returns>Success of the deletion</returns>
        public bool Delete(Guid id)
        {
            context.Clientes.Remove(GetById(id));
            return context.SaveChanges() > 0;
        }

        /// <summary>
        /// Delete a client register from the database
        /// </summary>
        /// <param name="cliente">Client to be deleted</param>
        /// <returns>Success of the deletion</returns>
        public bool Delete(Cliente cliente)
        {
            context.Clientes.Remove(cliente);
            return context.SaveChanges() > 0;
        }

        /// <summary>
        /// Delete a list of clients from the database
        /// </summary>
        /// <param name="clientes">List of clients to be deleted</param>
        /// <returns>Success of deletion</returns>
        public bool Delete(IList<Cliente> clientes)
        {
            context.Clientes.RemoveRange(clientes);
            return context.SaveChanges() > 0;
        }

        #endregion

        #region Update

        /// <summary>
        /// Update a client's register in the database
        /// </summary>
        /// <param name="cliente">Client to be updated in the database</param>
        /// <returns>Success of the update</returns>
        public bool Update(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            return context.SaveChanges() > 0;
        }

        /// <summary>
        /// Update a list of clients on the database
        /// </summary>
        /// <param name="clientes">List of clients to be updated in the database</param>
        /// <returns>Success of the update</returns>
        public bool Update(IList<Cliente> clientes)
        {
            context.Clientes.UpdateRange(clientes);
            return context.SaveChanges() > 0;
        }

        #endregion

        #region Select

        /// <summary>
        /// Returns the client whose id is equal to the given by parameter
        /// </summary>
        /// <param name="idCliente">Id of the client that must be retrived from the database</param>
        /// <returns>An object Cliente relative to the result of the search in the database</returns>
        public Cliente GetById(Guid idCliente)
        {
            return context.Clientes.FirstOrDefault(x => x.Id == idCliente);
        }

        /// <summary>
        /// Search a list of clients in the database
        /// </summary>
        /// <returns>All the clients from the Database</returns>
        public IList<Cliente> Get()
        {
            return context.Clientes.ToList();
        }

        #endregion
        #endregion
    }
}

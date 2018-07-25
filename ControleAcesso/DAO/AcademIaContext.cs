using ControleAcesso.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.DAO
{
    public class AcademiaContext : DbContext
    {
        #region Construtor
        public AcademiaContext()
        {
        }

        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {
        }
        #endregion

        #region Properties
        public DbSet<Cliente> Clientes { get; set; }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=Academia.db");
        }
        #endregion
    }
}

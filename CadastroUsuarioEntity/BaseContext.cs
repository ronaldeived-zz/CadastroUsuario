using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CadastroUsuarioEntity
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("DBCS") { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Processo> Processo { get; set; }
        public DbSet<Status> Status{ get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Usuario_Perfil> Usuario_Perfil { get; set; }
        public DbSet<Usuario_Processo> Usuario_Processo{ get; set; }
    }
}

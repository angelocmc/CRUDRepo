using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDTest.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CRUDTest.DAL
{
    public class PessoaContext : DbContext
    {
        public PessoaContext() : base("PessoaContext")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
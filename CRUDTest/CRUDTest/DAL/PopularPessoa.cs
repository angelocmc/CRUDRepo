using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUDTest.Models;

namespace CRUDTest.DAL
{
    public class PopularPessoa : System.Data.Entity.DropCreateDatabaseIfModelChanges<PessoaContext>
    {
        protected override void Seed(PessoaContext context)
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa{NomeCompleto="João Pedro", email="joaopedro@gmail.com", telefone="+55 11 9584-3958"},
                new Pessoa{NomeCompleto="Thiago Santos", email="thiagosantos@gmail.com", telefone="+55 19 9674-4087"},
                new Pessoa{NomeCompleto="Fernanda Souza", email="fernandasouza@gmail.com", telefone="+55 11 9701-6341"}
            };
        }
    }
}
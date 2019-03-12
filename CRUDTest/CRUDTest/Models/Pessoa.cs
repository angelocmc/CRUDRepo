using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDTest.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string NomeCompleto { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
    }
}
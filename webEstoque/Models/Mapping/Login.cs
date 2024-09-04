using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webEstoque.Models.Mapping
{
    public class Login
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public DateTime dataHoraCriacao { get; set; }
        public bool deletado { get; set; }
        public bool administrador { get; set; }


    }
}
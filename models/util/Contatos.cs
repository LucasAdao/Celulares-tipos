using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celulares_tipos.models.util
{
    public class Contatos
    {
        public string Nome { get; set; }
        public string Numero { get; set; }

        public Contatos(string nome, string numero){
            Nome = nome;
            Numero = numero;
        }
    }
}
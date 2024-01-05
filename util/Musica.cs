using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celulares_tipos.util
{
    public class Musica
    {
        public string NomeDaMusica { get; set; }
        public string Autor { get; set; }

        public Musica(string nomeDaMusica, string autor) {
            NomeDaMusica = nomeDaMusica;
            Autor = autor;
        }

    
    }
}
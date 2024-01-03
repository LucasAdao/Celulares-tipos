using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celulares_tipos.models.util
{
    public class Musicas
    {
        public string NomeDaMusica { get; set; }
        public string Autor { get; set; }

        public Musicas(string nomeDaMusica, string autor) {
            NomeDaMusica = nomeDaMusica;
            Autor = autor;
        }
    }
}
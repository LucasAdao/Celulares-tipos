using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Celulares_tipos.models.sistemaOperacional
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo{ get; set; }
        public string Imei {get; set;}
        public int Memoria{get;set;}
        public List<String> Musicas { get; set; }
        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Musicas = new List<string>();
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void AdicionarMusicas(string musica){
            Musicas.Add(musica);
        }
        public void ListarMusicas() { 
            foreach (string musicaAtual in Musicas)
            {
                Console.WriteLine(musicaAtual);
                Thread.Sleep(1000);
            }
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp,int memoriaApp);
    }
}

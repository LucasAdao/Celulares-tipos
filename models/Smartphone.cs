using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Celulares_tipos.util;

namespace Celulares_tipos.models
{
    public abstract class Smartphone
    {

    //passar para private
        public string Numero { get; set; }
        public string Imei { get; set; }
        public string Modelo { get; set;}
        public int Memoria { get; set; }
        public int Bateria = 100;
        public bool Ligado { get; set; }
        public List<Musica> Musicas;
        public List<Contato> Contatos;
        public List<Aplicacao> Aplicacoes;

        public Smartphone(string numero, string imei, string modelo, int memoria) 
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            Memoria = memoria;
            Musicas = new List<Musica>();
            Contatos = new List<Contato>();
            Aplicacoes = new List<Aplicacao>();
        }


        public void Ligar() 
        {
            Ligado = true;
        }
        public void Desligar()
        {
            Ligado = false;
        }
        
        //Lembrar de debugar isso para ver como esta funcionando
        
        public void Carregar() {
            bool carregar = true;
            while (carregar == true) {
                Bateria = Bateria + 20;
                Thread.Sleep(1000);
                Console.WriteLine($"Sua bateria está em {Bateria}, deseja continuar carregando?");
                Console.WriteLine("1-Sim \n 2-Não");
                int opcao = Convert.ToInt32(Console.ReadLine());
                    while (opcao != 1 || opcao != 2) 
                    { 
                        if (opcao == 1)
                        {
                            break;
                        }
                        else if (opcao == 2)
                        {
                            carregar = false;
                        }
                        else {
                            Console.WriteLine("Insira um valor valido");
                        }
                }
            }
        }


        public abstract void AplicativoDeMusicas();

        public abstract void AplicativoDeContatos();

        public abstract void FazerLigacao();

        public abstract void InstalarAplicativo();



        
    }
}
    

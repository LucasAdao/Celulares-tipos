using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Celulares_tipos.util;

namespace Celulares_tipos.models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Imei { get; set; }
        public string Modelo { get; set;}
        public int MemoriaFicha { get; set; }
        public int Bateria = 100;

        public double MemoriaUsavel { get; set; }
        public bool Ligado { get; set; }
        public List<Musica> Musicas;
        public List<Contato> Contatos;
        public List<Aplicacao> Aplicacoes;

        public Smartphone()
        {
            Contatos = new List<Contato>();
            Aplicacoes = new List<Aplicacao>();
            Musicas = new List<Musica>();
        }
        public Smartphone(string numero, string imei, string modelo, int memoria) 
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            MemoriaFicha = memoria;
            Musicas = new List<Musica>();
            Contatos = new List<Contato>();
            Aplicacoes = new List<Aplicacao>();
        }

        public void Desligar()
        {
            Ligado = false;
        }

        public void OlharBarraDeNotificacoes() 
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine($"Bateria - {Bateria}%,Data - {agora.Day}/{agora.Month}/{agora.Year} Hora - {agora.Hour}:{agora.Minute} \nOtimize seu celular! Você já ocupou {MemoriaUsavel}GB/{MemoriaFicha}GB.");
            Thread.Sleep(3000);
        }
        
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

        public void Descricao() 
        {
            Console.WriteLine($"Modelo: {Modelo} \nMemoria: {MemoriaFicha}Gb");
        }

        protected void RemoverMusica()
        {
            Bateria = Bateria - 5;
            Console.WriteLine("Digite o nome da música que você quer remover:");
            string nomeDaMusica = Console.ReadLine();
        
            Musica musicaParaRemover = Musicas.Find(m => m.NomeDaMusica == nomeDaMusica);

            if (musicaParaRemover != null)
            {
                Musicas.Remove(musicaParaRemover);
                Console.WriteLine($"Música '{nomeDaMusica}' removida com sucesso!");
                MemoriaUsavel = MemoriaUsavel + 0.10;
            }
            else
            {
                Console.WriteLine($"Música '{nomeDaMusica}' não encontrada no celular.");
            }
        }

        protected void RemoverContato()
        {
            Bateria = Bateria - 5;
            Console.WriteLine("Digite o nome do contato que você quer remover:");
            string nomeDoContato = Console.ReadLine();
            Contato contatoParaRemover = Contatos.Find(m => m.Nome == nomeDoContato);

            if (contatoParaRemover != null)
            {
                Contatos.Remove(contatoParaRemover);
                Console.WriteLine($"Contato:{nomeDoContato} removida com sucesso!");
                MemoriaUsavel = MemoriaUsavel + 0.05;
            }
            else
            {
                Console.WriteLine($"Contato:{nomeDoContato} não encontrada no celular.");
            }
        }
        public void RemoverAplicativo()
        {
            Bateria = Bateria - 5;
            Console.WriteLine("Digite o nome do Aplicativo que você quer remover:");
            string nomeDoAplicativo = Console.ReadLine();
        
            Aplicacao aplicativoParaRemover = Aplicacoes.Find(m => m.Nome == nomeDoAplicativo);

            if (aplicativoParaRemover != null)
            {
                Aplicacoes.Remove(aplicativoParaRemover);
                MemoriaUsavel = MemoriaUsavel - aplicativoParaRemover.Tamanho;
                Console.WriteLine($"O {nomeDoAplicativo} foi removido com sucesso! e foi liberado {aplicativoParaRemover.Tamanho} de espaço");
            }
            else
            {
                Console.WriteLine($"{nomeDoAplicativo} não encontrado no seu celular.");
            }
        }

        public abstract void Ligar();
        public abstract void AplicativoDeMusicas();

        public abstract void AplicativoDeContatos();

        public abstract void FazerLigacao();

        public abstract void InstalarAplicativo();

        

        
    }
}
    

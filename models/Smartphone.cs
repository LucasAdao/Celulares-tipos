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
            Memoria = memoria;
            Musicas = new List<Musica>();
            Contatos = new List<Contato>();
            Aplicacoes = new List<Aplicacao>();
            MemoriaUsavel = Memoria;
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

        public void Descricao() 
        {
            Console.WriteLine($"Modelo: {Modelo} \nMemoria: {Memoria}Gb");
        }

        protected void RemoverMusica()
        {
        Console.WriteLine("Digite o nome da música que você quer remover:");
        string nomeDaMusica = Console.ReadLine();
        
        Musica musicaParaRemover = Musicas.Find(m => m.NomeDaMusica == nomeDaMusica);

        if (musicaParaRemover != null)
        {
            Musicas.Remove(musicaParaRemover);
            Console.WriteLine($"Música '{nomeDaMusica}' removida com sucesso!");
        }
        else
        {
            Console.WriteLine($"Música '{nomeDaMusica}' não encontrada no celular.");
        }
        }

        protected void RemoverContato()
        {
        Console.WriteLine("Digite o nome do contato que você quer remover:");
        string nomeDoContato = Console.ReadLine();
        
        Contato contatoParaRemover = Contatos.Find(m => m.Nome == nomeDoContato);

        if (contatoParaRemover != null)
        {
            Contatos.Remove(contatoParaRemover);
            Console.WriteLine($"Contato:{nomeDoContato} removida com sucesso!");
        }
        else
        {
            Console.WriteLine($"Contato:{nomeDoContato} não encontrada no celular.");
        }
        }
        protected void RemoverAplicativo()
        {
        Console.WriteLine("Digite o nome do Aplicativo que você quer remover:");
        string nomeDoAplicativo = Console.ReadLine();
        
        Aplicacao aplicativoParaRemover = Aplicacoes.Find(m => m.Nome == nomeDoAplicativo);

        if (aplicativoParaRemover != null)
        {
            Aplicacoes.Remove(aplicativoParaRemover);
            Console.WriteLine($"O {nomeDoAplicativo} foi removido com sucesso!");
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
    

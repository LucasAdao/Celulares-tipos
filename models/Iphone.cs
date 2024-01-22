using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Celulares_tipos.util;

namespace Celulares_tipos.models
{
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }
        public Iphone() { }

        public override void Ligar()
        {
            Ligado = true;

            Console.WriteLine("Iniciando...");
            Thread.Sleep(1000);
            Console.WriteLine(@"
                        ⠀⠀⠀⠀⣀⣀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⡿⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⠟⠁⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⢀⣠⣤⣤⣤⣀⣀⠈⠋⠉⣁⣠⣤⣬⣤⣀⡀⠀⠀
            ⠀⢠⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀
            ⣠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠀
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠀⠀
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀
            ⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣀
            ⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁
            ⠀⠀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀
            ⠀⠀⠀⠈⠙⢿⣿⣿⣿⠿⠟⠛⠻⠿⣿⣿⣿⡿⠋⠀⠀⠀
                                           
            
         ------ Think Different -------                               ");
            Thread.Sleep(1000);
        }

       public override void AplicativoDeContatos()
        {
            Bateria = Bateria - 10;
            bool acessarContatos = true;
            while (acessarContatos == true)
            {
                Console.Clear();
                Console.WriteLine("Lista Telefonica: \n 1-Ver Contatos \n 2-Adicionar Contatos \n 3-Remover Contatos \n 4-Menu Principal");
                int opcaoListaDeContatos = Convert.ToInt32(Console.ReadLine());
                switch (opcaoListaDeContatos) 
                {
                    case 1:
                        if (Contatos.Count == 0)
                        {
                            Console.WriteLine("Você não possui contatos. Insira mais contatos na opção inserir contatos.");
                        }
                        else
                        {
                            foreach (Contato contatoDeLista in Contatos)
                            {
                                Console.WriteLine($"---------------------------\n Nome: {contatoDeLista.Nome} \n Número: {contatoDeLista.Numero}");

                                Thread.Sleep(500);
                            }
                        }
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Thread.Sleep(1000);
                        Console.WriteLine("Digite o nome do contato:");
                        string nomeDoContato = Console.ReadLine();
                        Thread.Sleep(1000);
                        Console.WriteLine("Insira o número de telefone do contato:");
                        string numeroDoContato = Console.ReadLine();
                        Contato contato = new Contato(nomeDoContato, numeroDoContato);
                        Contatos.Add(contato);
                        Console.WriteLine("Contato adicionado com sucesso, digite uma tecla para continuar!");
                        MemoriaUsavel = MemoriaUsavel - 0.05;
                        Console.ReadKey();
                        break;
                    case 3:
                        Thread.Sleep(1000);
                        RemoverContato();
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        acessarContatos = false;
                        break;
                    default:
                        Console.WriteLine("Insira um valor válido!");
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public override void AplicativoDeMusicas()
        {
            Bateria = Bateria - 10;
            bool musicPlayer = true;
            while (musicPlayer == true) 
            {
                Console.Clear();
                Console.WriteLine("Itunes: \n 1-Adicionar Música \n 2-Remover Música \n 3-Listar Músicas \n 4-Menu Principal");
                int opcaoAplicativoDeMusica = Convert.ToInt32(Console.ReadLine());
                switch (opcaoAplicativoDeMusica) 
                { 
                    case 1:
                        Thread.Sleep(1000);
                        Console.WriteLine("Digite o nome da música que você deseja adicionar:");
                        string nomeDaMusica = Console.ReadLine();
                        Thread.Sleep(1000);
                        Console.WriteLine("Agora digite o nome do autor da música:");
                        string autor = Console.ReadLine();
                        Musica music = new Musica(nomeDaMusica, autor);
                        if (music.NomeDaMusica.Length > 0 && music.Autor.Length > 0) 
                        {
                        Musicas.Add(music);
                        Console.WriteLine("Musica adicionada com sucesso!");
                        MemoriaUsavel = MemoriaUsavel - 0.10;
                        Thread.Sleep(1000);
                        }else
                        {
                            Console.WriteLine("Não foi possível adicionar a música, certifique-se de preencher os campos de forma adequada, a música precisa possuir um nome e precisa ter um autor."); 
                        }
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        RemoverMusica();
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        int i = 1;
                        if (Musicas.Count == 0)
                        {
                            Console.WriteLine("Você não adicionou Músicas, use a opção adicionar músicas para adicionar mais músicas!");
                        }
                        else 
                        { 
                            foreach (Musica musica in Musicas)
                            {
                                Console.WriteLine(i + "." + musica.NomeDaMusica + " - " + musica.Autor);
                                Thread.Sleep(500);
                                i++;
                            }
                        }
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                       
                        break;
                    case 4:
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        musicPlayer = false;
                        break;
                        
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        Thread.Sleep(1000);
                        break;
                }
            }
        }


        public override void FazerLigacao()
        {
            Bateria = Bateria - 10;
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Digite o número que você deseja fazer a ligação:");
            string numeroLigacao = Console.ReadLine();
            Random random = new Random();
            int procedimentosDeLigacao = random.Next(1, 4);
            if (procedimentosDeLigacao == 1 || procedimentosDeLigacao == 2)
            {
                Console.WriteLine("Chamando...");
                Thread.Sleep(1000);
                Console.WriteLine("Chamando...");
                Thread.Sleep(1000);
                Console.WriteLine("Chamada em Andamento com "+ numeroLigacao);
                Console.WriteLine("  ");
                stopwatch.Start();

                Console.WriteLine("Para Desligar digite uma tecla");
                Console.ReadKey();
                stopwatch.Stop();
                TimeSpan tempoDecorrido = stopwatch.Elapsed;
                string tempoMinutos = tempoDecorrido.TotalMinutes.ToString("F0");
                string tempoSegundos = tempoDecorrido.TotalSeconds.ToString("F0");
                if (tempoDecorrido.TotalMinutes < 1)
                {
                    Console.WriteLine($"Chamada encerrada! você ficou na chamada {tempoSegundos} segundos ");
                    Console.WriteLine("Digite uma tecla para continuar");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine($"Chamada encerrada! você ficou na chamada {tempoMinutos} minutos");
                    Console.WriteLine("Digite uma tecla para continuar");
                    Console.ReadKey();
                }
            }
            else
            { 
                Console.WriteLine("Chamando...");
                Thread.Sleep(1000);
                Console.WriteLine("Chamando...");
                Thread.Sleep(1000);
                Console.WriteLine("O número: " + numeroLigacao + " está fora de área ou desligado!");
                Console.WriteLine("Digite uma tecla para continuar");
                Console.ReadKey();
            }

        }

        public override void InstalarAplicativo()
        {
            Bateria = Bateria - 10;
            Console.WriteLine("Acessando a Apple Store...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            
            Aplicacao aplicacao = new Aplicacao();
            Console.WriteLine("Digite o nome do aplicativo que você quer instalar:");
            string aplicativoNome = Console.ReadLine();
            aplicacao.Nome = aplicativoNome;
            Random random = new Random();
            aplicacao.Tamanho = random.Next(1, 13);
            if (MemoriaUsavel < aplicacao.Tamanho)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Libere mais memória, o aplicativo excede a memória do dispositivo.");
                Thread.Sleep(1000);
                Console.WriteLine("Sua memória atual é : " + MemoriaUsavel + "Gb. e o aplicativo atual tem " + aplicacao.Tamanho + "Gb");
                Thread.Sleep(1000);
                Console.WriteLine("Digite uma tecla para continuar");
                Console.ReadKey();
            }
            else if(aplicacao.Nome == null || aplicacao.Nome.Length < 3)
            {
                Console.WriteLine("A aplicação é inexistente, tente inserir o nome real dela!");
                Console.WriteLine("                  ");
            }
            else
            {
                Aplicacoes.Add(aplicacao);
                Thread.Sleep(1000);
                Console.WriteLine("Aplicativo instalado com sucesso!");
                Console.WriteLine("Digite uma tecla para continuar");
                Console.ReadKey();
            }

        }




    }
}
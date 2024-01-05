using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Celulares_tipos.util;

namespace Celulares_tipos.models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        public override void AplicativoDeContatos()
        {
            throw new NotImplementedException();
        }

        public override void AplicativoDeMusicas()
        {
            
            Bateria = Bateria - 1;
            bool musicPlayer = true;
            while (musicPlayer == true) 
            {
                Console.WriteLine("MusicPlayer: \n 1-Adicionar Música \n 2-Remover Música \n 3-Listar Músicas \n 4-Sair");
                int opcaoAplicativoDeMusica = Convert.ToInt32(Console.ReadLine());
                switch (opcaoAplicativoDeMusica) 
                { 
                    case 1:
                        Console.WriteLine("Digite o nome da música que você deseja adicionar:");
                        string nomeDaMusica = Console.ReadLine();
                        Console.WriteLine("Agora digite o nome do autor da música:");
                        string autor = Console.ReadLine();
                        Musicas music = new Musicas(nomeDaMusica, autor);
                        ListaDeMusicas.Add(music);
                        Console.WriteLine("           ");
                        Thread.Sleep(1000);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome da música que você deseja remover:");
                        string nomeDaMusicaParaRemover = Console.ReadLine();
                        Console.WriteLine("Agora digite o nome do autor da música que vai ser removida:");
                        string autorParaRemover = Console.ReadLine();
                        Musicas musicQueSeraRemovida = new Musicas(nomeDaMusicaParaRemover, autorParaRemover);
                        ListaDeMusicas.Remove(musicQueSeraRemovida);
                        Console.WriteLine("           ");
                        Thread.Sleep(1000);
                        break;
                    case 3:
                        foreach (Musicas musica in ListaDeMusicas)
                        {
                            Console.WriteLine(musica.NomeDaMusica + " - " + musica.Autor);
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine("           ");
                        break;
                    case 4:
                        musicPlayer = false;
                        break;
                        
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        break;
                }

            }
        }

        
        public override void FazerLigacao()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Digite o número que você deseja fazer a ligação:");
            string numeroLigacao = Console.ReadLine();
            Random random = new Random();
            int procedimentosDeLigacao = random.Next(1, 3);
            if (procedimentosDeLigacao == 1)
            {
                Console.WriteLine("Chamando...");
                Thread.Sleep(1000);
                Console.WriteLine("Chamando...");
                Thread.Sleep(2000);
                Console.WriteLine("Chamada em Andamento com "+ numeroLigacao);
                Console.WriteLine("  ");
                stopwatch.Start();

                Console.WriteLine("Para Desligar digite uma tecla");
                Console.ReadKey();
                stopwatch.Stop();
                TimeSpan tempoDecorrido = stopwatch.Elapsed;
                string tempoMinutos = tempoDecorrido.TotalMinutes.ToString("F2");
                string tempoSegundos = tempoDecorrido.TotalSeconds.ToString("F2");
                if (tempoDecorrido.TotalMinutes < 1)
                {
                    Console.WriteLine($"Chamada encerrada! você ficou na chamada {tempoSegundos} ");
                }
                else 
                {
                    Console.WriteLine($"Chamada encerrada! você ficou na chamada {tempoMinutos}");
                }
            }
            else
            { 
                Console.WriteLine("Chamando...");
                Thread.Sleep(1000);
                Console.WriteLine("Chamando...");
                Thread.Sleep(2000);
                Console.WriteLine("O número: " + numeroLigacao + " está fora de área ou desligado!");
            }

        }

        public override void InstalarAplicativo()
        {
            
        }

        
    }
}
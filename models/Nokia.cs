using System;
using System.Collections.Generic;
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
                        
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome da música que você deseja remover:");
                        string nomeDaMusicaParaRemover = Console.ReadLine();
                        Console.WriteLine("Agora digite o nome do autor da música que vai ser removida:");
                        string autorParaRemover = Console.ReadLine();
                        Musicas musicQueSeraRemovida = new Musicas(nomeDaMusicaParaRemover, autorParaRemover);
                        ListaDeMusicas.Remove(musicQueSeraRemovida);
                        break;
                    case 3:
                        

                        break;
                        

                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        break;
                }

            }
        }

        
        public override void FazerLigacao()
        {
            //TO DO: implementar contato que vc quer ligar
            
            Random random = new Random();
            int procedimentosDeLigacao = random.Next(1, 2);
            if (procedimentosDeLigacao == 1)
            {
                Console.WriteLine("Chamando...");
                Thread.Sleep(1000);
                Console.WriteLine("Chamando...");
                Thread.Sleep(2000);
                Console.WriteLine("Chamada em Andamento");
                Console.WriteLine("  ");
                Console.WriteLine("Para Desligar digite uma tecla");
                Console.ReadKey();
            }
            else
            { 
                Console.WriteLine("Chamando...");
                Thread.Sleep(1000);
                Console.WriteLine("Chamando...");
                Thread.Sleep(2000);
                Console.WriteLine("O celular está fora de área ou desligado!");
            }

        }

        public override void InstalarAplicativo()
        {
            
        }

        
    }
}
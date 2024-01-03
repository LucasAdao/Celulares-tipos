using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
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
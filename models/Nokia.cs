using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celulares_tipos.models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
       

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp,int espacoApp)
        {
           Console.WriteLine("Entra na Play Store");
            Thread.Sleep(2000);
            Console.WriteLine($"Procura por {nomeApp}");
            Thread.Sleep(2000);
            Console.WriteLine("Clica em instalar ou comprar");
            Thread.Sleep(2000);
            Console.WriteLine("...Analizando memória disponivel");
            if(Memoria > espacoApp)
            {
                Thread.Sleep(3000);
                Console.WriteLine("Instalando...");
                Thread.Sleep(3000);
                Console.WriteLine("App Instalado!!");
                Thread.Sleep(2000);
                Console.WriteLine("Perfeito, agora você ja pode aproveitar o seu app e usar ele da maneira que quiser!");
            }else{
                Thread.Sleep(3000);
                Console.WriteLine("Seu Celular não possui espaço para adquirir esse aplicativo");
                Console.WriteLine("É, esse ap não cabe no meu Celular!");

            }
               
        }
    }
}
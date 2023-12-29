using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celulares_tipos.models.sistemaOperacional
{
    // TODO: Herdar da classe "Smartphone"
    /// <summary>
    /// Classe que representa o aparelho da microsoft/nokia e suas funcionalidades
    /// </summary>
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
       

        // TODO: Sobrescrever o método "InstalarAplicativo"
        /// <summary>
        /// Metodo que faz a instalação de aplicativos no aparelho com base no nome e na memória.
        /// </summary>
        /// <param name="nomeApp">serve para dizer o nome que o aparelho vai buscar na loja</param>
        /// <param name="espacoApp">serve para medir a capacidade do aparelho em relação a quantidade de memória do aplicativo</param>
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
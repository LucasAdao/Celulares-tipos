using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celulares_tipos.models.sistemaOperacional
{
    /// <summary>
    /// Classe que representa o aparelho da apple e suas particularidades
    /// </summary>
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        /// <summary>
        /// Metodo que faz a instalação de aplicativos no aparelho com base no nome e na memória.
        /// </summary>
        /// <param name="nomeApp">serve para dizer o nome que o aparelho vai buscar na loja</param>
        /// <param name="espacoApp">serve para medir a capacidade do aparelho em relação a quantidade de memória do aplicativo</param>
        public override void InstalarAplicativo(
            string nomeApp,
            int espacoApp)
        {
            
            Console.WriteLine("Entra na Apple Store");
            Thread.Sleep(2000);
            Console.WriteLine($"Procura por {nomeApp}");
            Thread.Sleep(2000);
            Console.WriteLine("Clica em instalar ou comprar");
            Thread.Sleep(2000);
            Console.WriteLine("...Analizando memória disponivel");
            if(Memoria > espacoApp)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Instalando...");
                Thread.Sleep(2000);
                Console.WriteLine("App Instalado!!");
            }else{
                Thread.Sleep(2000);
                Console.WriteLine("Seu Celular não possui espaço para adquirir esse aplicativo");

            }
               
        }
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Celulares_tipos.models;

namespace Celulares_tipos
{
    public class Program
    {
        static void Main() 
        {
            Console.WriteLine("Vamos simular um modelo de celular!");
            Thread.Sleep(1000);
            Console.WriteLine("Digite: \n 1-Para Iphone \n 2-Para Nokia");
            int opcaoInicial = Convert.ToInt32(Console.ReadLine());
            
            switch (opcaoInicial) 
            { 
            case 1:
                Console.WriteLine("Certo, agora me passe as informações do seu Iphone!");
                Thread.Sleep(1500);
                Console.WriteLine("Modelo:(Ex: Iphone 15 pro max)");
                string modelo = Console.ReadLine();
                Thread.Sleep(500);
                Console.WriteLine("Número:");
                string numero = Console.ReadLine();
                Thread.Sleep(500);
                Console.WriteLine("Memória:");
                int memoria = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(500);
                Console.WriteLine("Imei:");
                string imei = Console.ReadLine();
                Thread.Sleep(500);
                Iphone iphone = new Iphone(numero,imei,modelo,memoria);
                    Console.WriteLine(@"Tudo certo, aparelho abstraido com sucesso!
                                                 ");
                

                break;
            case 2:


            default:
                    Console.WriteLine("Insira um valor válido!");
                    break;    
            }

            
                
            
           
            

        }
    }
}
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
            //>>>>>>>>>>>>>>>>>dar feedbacks nos metodosssssssss<<<<<<<<<<<<<<<<<<<<
            //ajeitar listagem de contatos
            //ajeitar remoção de músicas
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
                Console.WriteLine("Número:(Ex: 81-997505987)");
                string numero = Console.ReadLine();
                Thread.Sleep(500);
                Console.WriteLine("Memória:(Ex: Apenas digite o número de gigas!)");
                int memoria = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(500);
                Console.WriteLine("Imei: (Ex:Digite apenas números e letras maiusculas!)");
                string imei = Console.ReadLine();
                Thread.Sleep(500);
                Iphone iphone = new Iphone(numero,imei,modelo,memoria);
                Console.WriteLine(@"Tudo certo, aparelho abstraido com sucesso!
                                                 ");                                        
                iphone.Descricao();
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Agora iremos iniciar seu aparelho!");
                Thread.Sleep(2000);
                iphone.Ligar();
                Thread.Sleep(1500);


                while (iphone.Ligado)
                {
                    Thread.Sleep(2000);

                    Console.Clear();
                    Console.WriteLine("Menu: \n1-Fazer Ligação \n2-Aplicativo de Contatos \n3-Aplicativo de Músicas \n4-Instalar um aplicativo \n5-Desligar ");
                    int opcaoMenu = Convert.ToInt32(Console.ReadLine());
                    switch (opcaoMenu)
                    {
                        case 1:
                            iphone.FazerLigacao();
                            break;
                        case 2:
                            iphone.AplicativoDeContatos();
                            break;
                        case 3:
                            iphone.AplicativoDeMusicas();
                            break;
                        case 4:
                            iphone.InstalarAplicativo();
                            break;
                        case 5:
                            iphone.Desligar();
                            break;
                        default:
                            Console.WriteLine("Insira um valor válido!");
                            break;
                    }
                }
                break;
            case 2:


            default:
                    Console.WriteLine("Insira um valor válido!");
                    break;    
            }
        }
    }
}
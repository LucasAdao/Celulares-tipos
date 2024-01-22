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
            //feedbacks          - Okay!
            //fazer a função desinstalar app     - Okay!
            //manter o usuário preso na operação  - Okay!
            //memoria usavel -- usar????
            //Diagrama UML  -- em produção
            //fazer a calculadora
            //testar a calculadora
            Console.WriteLine("Vamos simular um modelo de celular!");
            Thread.Sleep(1000);
            Console.WriteLine("Digite: \n 1-Para Iphone \n 2-Para Nokia");
            int opcaoInicial = Convert.ToInt32(Console.ReadLine());
            
            switch (opcaoInicial) 
            { 
            case 1:
                bool passa = false;

                Console.WriteLine("Certo, agora me passe as informações do seu Iphone!");
                Iphone iphone = new Iphone();

                Thread.Sleep(1500);
                while (passa == false) 
                {
                    Console.WriteLine("Modelo:(Ex: Iphone 15 pro max)");
                    string modelo = Console.ReadLine();
                        if (modelo.Length > 3) {
                            iphone.Modelo = modelo;
                            passa = true;
                        }
                        else
                        {
                            Console.WriteLine("Modelo invalido, tente inserir um nome válido!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                }
                passa = false;
                Thread.Sleep(500);
                while (passa == false) 
                {
                    Console.WriteLine("Número:(Ex: 81-997505987)");
                    string numero = Console.ReadLine();
                        if (numero.Length > 3) 
                        {
                            iphone.Numero = numero;
                            passa = true;
                        }
                        else
                        {
                            Console.WriteLine("Número invalido, tente inserir um número válido!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                }
                passa = false;
                Thread.Sleep(500);
                while (passa == false) 
                { 
                    Console.WriteLine("Memória:(Ex: Apenas digite o número de gigas!)");
                    int memoria = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            iphone.Memoria = memoria;
                            passa = true;
                        }
                        catch 
                        {
                            Console.WriteLine("Digite apenas números na opção memória!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                }
                passa = false;
                Thread.Sleep(500);
                while (passa == false)
                {
                    Console.WriteLine("Imei: (Ex:Digite apenas números e letras maiusculas!)");
                    string imei = Console.ReadLine();
                        if (imei.Length > 4)
                        {
                            iphone.Imei = imei;
                            passa = true;
                        }
                        else 
                        {
                            Console.WriteLine($"Insira um imei válido, o {imei} tem menos de 4 caracteres ");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                }
                Thread.Sleep(500);
                //Iphone iphone = new Iphone(numero,imei,modelo,memoria);
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
                    Console.WriteLine("Menu: \n1-Fazer Ligação \n2-Aplicativo de Contatos \n3-Itunes \n4-Instalar um aplicativo \n5-Desligar ");
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
                Console.WriteLine("Aparelho desligado com sucesso! \n\nNão fui eu que ordenei a você? Seja forte e corajoso! Não se apavore nem desanime, pois o Senhor, o seu Deus, estará com você por onde você andar! \n Josué 1:9"); 
                break;

            case 2:
            bool adiante = false;

            Console.WriteLine("Certo, agora me passe as informações do seu Nokia!");
            Nokia nokia = new Nokia();
            Thread.Sleep(1500);
            while (adiante == false) 
                {
                    Console.WriteLine("Modelo:(Ex: Nokia G60)");
                    string modelo = Console.ReadLine();
                        if (modelo.Length > 3) {
                            nokia.Modelo = modelo;
                            adiante = true;
                        }
                        else
                        {
                            Console.WriteLine("Modelo invalido, tente inserir um nome válido!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                }
                adiante = false;
                Thread.Sleep(500);
                while (adiante == false) 
                {
                    Console.WriteLine("Número:(Ex: 81-997505987)");
                    string numero = Console.ReadLine();
                        if (numero.Length > 3) 
                        {
                            nokia.Numero = numero;
                            adiante = true;
                        }
                        else
                        {
                            Console.WriteLine("Número invalido, tente inserir um número válido!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                }
                adiante = false;
                Thread.Sleep(500);
                while (adiante == false) 
                { 
                    Console.WriteLine("Memória:(Ex: Apenas digite o número de gigas!)");
                    int memoria = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            nokia.Memoria = memoria;
                            adiante = true;
                        }
                        catch 
                        {
                            Console.WriteLine("Digite apenas números na opção memória!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                }
                adiante = false;
                Thread.Sleep(500);
                while (adiante == false)
                {
                    Console.WriteLine("Imei: (Ex:Digite apenas números e letras maiusculas!)");
                    string imei = Console.ReadLine();
                        if (imei.Length > 4)
                        {
                            nokia.Imei = imei;
                            adiante = true;
                        }
                        else 
                        {
                            Console.WriteLine($"Insira um imei válido, o {imei} tem menos de 4 caracteres ");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                }
                Thread.Sleep(500);
                //Nokia nokia = new Nokia(numeroNokia,imeiNokia,modeloNokia,memoriaNokia);
                Console.WriteLine(@"Tudo certo, aparelho abstraido com sucesso!
                                                 ");                                        
                nokia.Descricao();
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Agora iremos iniciar seu aparelho!");
                Thread.Sleep(2000);
                nokia.Ligar();
                Thread.Sleep(1500);


                    while (nokia.Ligado)
                    {
                        Thread.Sleep(2000);

                        Console.Clear();
                        Console.WriteLine("Menu: \n1-Fazer Ligação \n2-Aplicativo de Contatos \n3-Music Player \n4-Instalar um aplicativo \n5-Desligar ");
                        int opcaoMenu = Convert.ToInt32(Console.ReadLine());
                        switch (opcaoMenu)
                        {
                            case 1:
                                nokia.FazerLigacao();
                                break;
                            case 2:
                                nokia.AplicativoDeContatos();
                                break;
                            case 3:
                                nokia.AplicativoDeMusicas();
                                break;
                            case 4:
                                nokia.InstalarAplicativo();
                                break;
                            case 5:
                                nokia.Desligar();
                                break;
                            default:
                                Console.WriteLine("Insira um valor válido!");
                                break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Aparelho desligado com sucesso! \n\nNão fui eu que ordenei a você? Seja forte e corajoso! Não se apavore nem desanime, pois o Senhor, o seu Deus, estará com você por onde você andar! \n Josué 1:9");  
                    break;
            default:
                    Console.WriteLine("Insira um valor válido!");
                    break;    
            }
        }
    }
}
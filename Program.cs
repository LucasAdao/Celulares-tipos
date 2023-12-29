using Celulares_tipos.models.sistemaOperacional;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Oi eu sou Lucas, e meu celular é literalmente um Nokia!! hehehe");
        Thread.Sleep(3000);
        Console.WriteLine("Ele tem essas configurações: numero: 4002 8922, Imei:777666, modelo:Nokia G21 e possui memória de 64 gb");
        Nokia nokia = new Nokia("40028922", "Nokia G21 ", "777666", 64);
        Thread.Sleep(5000);
        Console.WriteLine(@"           ");
        Console.WriteLine("E eu gosto muito de escutar Imagine Dragons e Matui com meu celular!!");
        Thread.Sleep(3000);
        Console.WriteLine("Essas são As músicas que possuo em meu celular!");
        Thread.Sleep(2000);
        nokia.AdicionarMusicas("Matue - Maquina do Tempo");
        nokia.AdicionarMusicas("Matue - 777666");
        nokia.AdicionarMusicas("Matue - De Peça em Peça");
        nokia.AdicionarMusicas("Imagine Dragons - It's Time");
        nokia.AdicionarMusicas("Imagine Dragons - Radioactive");
        nokia.AdicionarMusicas("Imagine Dragons - Zero");
        nokia.AdicionarMusicas("Imagine Dragons - Bones");

        // foreach (string musicaAtual in nokia.Musicas)
        // {
        //     Console.WriteLine(musicaAtual);
        //     Thread.Sleep(1000);

        // }
        nokia.ListarMusicas();
        

        Thread.Sleep(2000);
        Console.WriteLine("             ");
        Console.WriteLine("Eu sei que vocês estão interessados em saber como eu instalo um app no meu celular!");
        Thread.Sleep(2000);
        Console.WriteLine("Para instalar um app no meu Nokia eu faço dessa forma!");
        Thread.Sleep(3000);
        Console.WriteLine("Me diga o nome do app que você quer instalar:");
        string nomeApp = Console.ReadLine();
        Thread.Sleep(2000);
        Console.WriteLine("Agora insira a quantidade de memoria que ele ocupa(Apenas números, vão ser considerados como gigas!)");
        int espacoApp = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(3000);
        Console.WriteLine("Fechado, agora vamos ver se da pra instalar");

        nokia.InstalarAplicativo(nomeApp, espacoApp);
        Console.WriteLine("                 ");
        Console.WriteLine("Agora vou deixar a bola da vez com minha namorada");
        Console.WriteLine("                 ");
        Thread.Sleep(3000);
        Console.WriteLine("Oi gente, eu sou Maria Cláudia, e meu celular é um Iphone 15!! Amo tirar fotos");
        Thread.Sleep(3000);
        Console.WriteLine("Ele tem essas configurações: numero: 4002 8922, Imei:Gabrielle Aplin home, modelo:Iphone 15 e possui memória de 999 gb");
        Iphone iphone = new Iphone("40028922", "Iphone 15 ", "Gabrielle Aplin home", 999);
        Thread.Sleep(5000);

        Console.WriteLine("Eu curto muito escutar músicas assim como meu namorado, porém eu só deixo poucas músicas no meu celular");
        Thread.Sleep(5000);
        Console.WriteLine("As músicas que estão no meu celular são:");
        iphone.AdicionarMusicas("Gabrielle Aplin - Home");
        iphone.AdicionarMusicas("Marilia Mendonça - Leão");

        iphone.ListarMusicas();


        Console.WriteLine("Para instalar um app nele eu faço dessa forma!");
        Thread.Sleep(2000);
        Console.WriteLine("Me diga um app para instalar:");
        string nomeAppp = Console.ReadLine();
        Thread.Sleep(2000);
        Console.WriteLine("Quanto de memoria o aplicativo possui?(apenas digite o número de gbs que ele ocupa)");
        int espacoAppp = Convert.ToInt32(Console.ReadLine());
        Thread.Sleep(3000);
        Console.WriteLine("Fechado, agora vamos ver se da pra instalar");

        iphone.InstalarAplicativo(nomeAppp, espacoAppp);

        Console.WriteLine("Muito bom, agora é só aproveitar seu app! :b ");

        }
    }

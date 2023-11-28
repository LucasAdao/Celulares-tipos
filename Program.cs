using Celulares_tipos.models;

Console.WriteLine("Oi eu sou Lucas, e meu celular é literalmente um Noka!! hehehe");
Thread.Sleep(3000);
Console.WriteLine("Ele tem essas configurações: numero: 4002 8922, Imei:777666, modelo:Nokia G21 e possui memória de 64 gb");
Nokia nokia = new Nokia("40028922","Nokia G21 ","777666",64);
Thread.Sleep(5000);
Console.WriteLine("Para instalar um app nele eu faço dessa forma!");
Thread.Sleep(2000);
Console.WriteLine("Me diga um app para instalar:");
string nomeApp = Console.ReadLine();
Thread.Sleep(2000);
Console.WriteLine("Agora a gente vai ver a quantidade de memoria que ele ocupa, quanto ele ocupa, veja ai e me diga?(apenas digite o número de gbs que ele ocupa)");
int espacoApp = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(3000);
Console.WriteLine("Fechado, agora vamos ver se da pra instalar");

nokia.InstalarAplicativo(nomeApp, espacoApp);
Console.WriteLine("                 ");
Console.WriteLine("Agora vou deixar a bola da vez com minha namorada");
Console.WriteLine("                 ");
Console.WriteLine("Oi gente, eu sou Maria Cláudia, e meu celular é um Iphone 15!! Amo tirar fotos");
Thread.Sleep(3000);
Console.WriteLine("Ele tem essas configurações: numero: 4002 8922, Imei:Gabrielle Aplin home, modelo:Iphone 15 e possui memória de 999 gb");
Iphone iphone = new Iphone("40028922","Iphone 15 ","Gabrielle Aplin home",999);
Thread.Sleep(5000);
Console.WriteLine("Para instalar um app nele eu faço dessa forma!");
Thread.Sleep(2000);
Console.WriteLine("Me diga um app para instalar:");
string nomeAppp = Console.ReadLine();
Thread.Sleep(2000);
Console.WriteLine("Quanto de memoria o Itunes ocupa?(apenas digite o número de gbs que ele ocupa)");
int espacoAppp = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(3000);
Console.WriteLine("Fechado, agora vamos ver se da pra instalar");

iphone.InstalarAplicativo(nomeAppp, espacoAppp);

Console.WriteLine("Muito bom, agora é só aproveitar seu app! :b ");


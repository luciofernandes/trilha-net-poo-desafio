using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "11111111", 512);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone ipone = new Iphone("123456", "Modelo 1", "11111111", 512);
ipone.ReceberLigacao();
ipone.InstalarAplicativo("Facebook");
using DesafioPOO.Models;

Console.WriteLine("Smartphone: Nokia");
var nokiaSmartphone = new Nokia("991234567", "Nokia X30 5G", "727047026928505", 128);
nokiaSmartphone.Ligar();
nokiaSmartphone.ReceberLigacao();
nokiaSmartphone.InstalarAplicativo("Instagram");
Console.WriteLine("");
Console.WriteLine("Smartphone: iPhone");
var iphone = new Iphone("987654321", "iPhone 15 Plus", "301052730543273", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Threads");
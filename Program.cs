using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("1234", "Black100", "987-556-6456", 128);
nokia.Ligar();
nokia. InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("3453", "Pro Max 13", "1869-863-2345", 256);
iphone.Ligar();
iphone.InstalarAplicativo("YouTube");

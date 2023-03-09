using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone");
var iphone = new Iphone("993674859", "XR", "12345", 64);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

//Não é possível alterar modelo, IMEI e memória após instanciar objeto, porque o set é privado.
//iphone.Memoria = 34;  ---> não funciona
//iphone.Numero = "993445566";----> funciona


Console.WriteLine("\n");

Console.WriteLine("Nokia");
var nokia = new Nokia("924875670", "Tijolao", "098765", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "784512", modelo: "Modelo Teste", imei: "123456789", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("Netflix");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "124578", modelo: "Teste Modelo", imei: "987654321", memoria: "128");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Sky");
iphone.Ligar();
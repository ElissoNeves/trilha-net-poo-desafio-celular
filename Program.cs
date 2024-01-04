using System.Xml.Schema;
using DesafioPOO.Models;

// Testes realizados

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "92017-1992", modelo:"Modelo 15", imei: "217171092", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99217-1710", modelo:"Modelo Note 12 Pro", imei: "199220177", memoria: 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("YouTube");
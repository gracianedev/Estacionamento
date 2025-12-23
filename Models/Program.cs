
using Estacionamento.Models;
Garagem garagem = new Garagem ();
garagem.ValorDiaria = 40.00M;
garagem.ValorHora = 8.00M;
garagem.Lotacao = 1;

Veiculo veiculo1 = new Veiculo("Hyundai", "HB20", "ISU-7729");
Veiculo veiculo2 = new Veiculo("Renault","Sandero", "ICQ-1801");

Console.WriteLine("- - - - - - - \n");

garagem.EntrarVeiculo(veiculo1);

Console.WriteLine("- - - - - - - \n");

garagem.EntrarVeiculo(veiculo2);

Console.WriteLine("- - - - - - - \n");
Console.WriteLine("- - - - - - - \n");

garagem.SairVeiculo(veiculo1.Placa);

Console.WriteLine("- - - - - - - \n");

garagem.SairVeiculo(veiculo2.Placa);

Console.WriteLine("- - - - - - - \n");

garagem.EntrarVeiculo(veiculo2);

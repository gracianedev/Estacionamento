using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Estacionamento.Models
{
    public class Garagem
    {
        public Garagem(decimal valorHora, decimal valorDiaria, int lotacao)
        {
            this.ValorHora = valorHora;
            this.ValorDiaria = valorDiaria;
            this.Lotacao = lotacao;

        }

        public Garagem()
        {

        }
        public decimal ValorHora { get; set; }

        public decimal ValorDiaria { get; set; }

        public int Lotacao { get; set; }

        public decimal CalcularValor(TimeSpan intervalo)
        {
            if (intervalo.Days < 1 && intervalo.Hours < 4)
            {
                decimal valor = intervalo.Hours * ValorHora;
                return valor;
            }
            else
            {
                decimal valorTotal = ValorDiaria * ((decimal)intervalo.Days) + ValorHora * (intervalo.Hours);
                return valorTotal;
            }
        }

        private Dictionary<string, Veiculo> veiculos = new Dictionary<string, Veiculo>();

        public void EntrarVeiculo(Veiculo veiculo)
        {

            if (veiculos.Count >= Lotacao)
            {
                Console.WriteLine($"Estacionamento lotado! \nNão há vaga para o veículo {veiculo.Modelo} placa {veiculo.Placa}");
            }
            else
            {
                veiculo.DataEntrada = DateTime.Now;
                string entrada = veiculo.DataEntrada.ToString("dd/MM/yyyy HH:mm:ss");
                veiculos.Add(veiculo.Placa, veiculo);
                Console.WriteLine($"Veículo permitido. Carro placa  {veiculo.Placa} entrou {entrada}" +
               $"\nO estacionamento está com {veiculos.Count} veículos (a capacidade máxima é de {Lotacao} veículos.)");
            }
        }

        public void SairVeiculo(string placa)
        {
            if (veiculos.TryGetValue(placa, out Veiculo v))
            {
                v.DataSaida = DateTime.Now.AddHours(52); //gerado um horário de saída para testes
                string saida = v.DataSaida.ToString("dd/MM/yyyy HH:mm:ss");
                TimeSpan intervalo = (v.DataSaida - v.DataEntrada);
                decimal ValorDevido = CalcularValor(intervalo);
                Console.WriteLine($"Valor a pagar do veículo placa {v.Placa}: {ValorDevido :C2}"+
                "\n" + $" Permaneceu {intervalo.Days} dias {intervalo.Hours} horas {intervalo.Minutes} minutos no estacionamento \n ");
                veiculos.Remove(v.Placa);
                Console.WriteLine($"Agora há {veiculos.Count} veículos no estacionamento. Há {Lotacao - veiculos.Count} vaga(s) disponível(is).");
            }
            else
            {
                Console.WriteLine($" O veículo placa {placa} não ingressou neste estacionamento.");
            }
        }
    }
}
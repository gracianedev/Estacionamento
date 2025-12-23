using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Veiculo {
        public string Marca {get; set;}
        public string Placa {get; set;}
        public string Modelo {get; set;}

        public DateTime DataEntrada {get; set;}
        public DateTime DataSaida {get; set;}

        public Veiculo ()
        {
        }

        public Veiculo (String marca, String modelo, String placa)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
        }

}

}
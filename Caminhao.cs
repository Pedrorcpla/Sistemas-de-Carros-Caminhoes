using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarrosCaminhoes
{
    class Caminhao : Veiculo
    {
        public int numero_eixos;
        public double peso_maximo_carga, peso, metragem;
        
        public Caminhao()
        {
            this.numero_eixos = 0;
            this.peso_maximo_carga = 0;
            this.peso = 0;
            this.metragem = 0;
        }
        public Caminhao(string modelo, string fabricante, string cor, int ano, int numero_portas, string placa, int numero_eixos, double peso_maximo_carga, double peso, double metragem)
            : base(modelo, fabricante, cor, ano, numero_portas, placa)
        {
            this.numero_eixos = numero_eixos;
            this.peso_maximo_carga = peso_maximo_carga;
            this.peso = peso;
            this.metragem = metragem;
        }
        public int Numero_eixos
        {
            get { return numero_eixos; }
            set { numero_eixos = value; }
        }
        public double Peso_maximo_carga
        {
            get { return peso_maximo_carga; }
            set { peso_maximo_carga = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Metragem
        {
            get { return metragem; }
            set { metragem = value; }
        }
    }
}

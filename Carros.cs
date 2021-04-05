using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarrosCaminhoes
{
    class Carros : Veiculo
    {
        public string tipoCarro;
        public int capacidadePortaMala;
        public bool bagageiro;

        public Carros()
        {
            this.tipoCarro = null;
            this.capacidadePortaMala = 0;
            this.bagageiro = false;
        }
        public Carros(string modelo, string fabricante, string cor, int ano, int numero_portas, string placa, string tipoCarro, int capacidadePortaMala, bool bagageiro)
        : base(modelo, fabricante, cor, ano, numero_portas, placa)
        {
            this.tipoCarro = tipoCarro;
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
        }
        public string TipoCarro
        {
            get { return tipoCarro; }
            set { tipoCarro = value; }
        }
        public int CapacidadePortaMala
        {
            get { return capacidadePortaMala; }
            set { capacidadePortaMala = value; }
        }
        public bool Bagageiro
        {
            get { return bagageiro; }
            set { bagageiro = value; }
        }
    }
}

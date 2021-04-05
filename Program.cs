using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarrosCaminhoes
{
    class Program
    {
        static void Main(string[] args)
        { 
            int x=0, y=0, m;
            Carros[] carro = new Carros[300];
            carro[x] = new Carros();
            Caminhao[] caminhao = new Caminhao[200];
            caminhao[y] = new Caminhao();
           
            do
            {
                Console.Clear();
                Console.WriteLine("_____Sistemas de Veículos_____");
                Console.WriteLine("\n1- Cadastro de Carro");
                Console.WriteLine("2- Cadastro de Caminhão");
                Console.WriteLine("3- Consulta por placa");
                Console.WriteLine("4- Consultar Caminhão por modelo/marca");
                Console.WriteLine("5- Consultar Carro por cor");
                Console.WriteLine("6- Exibir todos os Carros cadastrados");
                Console.WriteLine("7- Exibir todos os Caminhões cadastrados");
                Console.WriteLine("0- Sair");
                Console.Write("\nOpção: ");
                m = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (m)
                {
                    case 1:
                        Console.WriteLine("_____Cadastro de Carro_____");
                        Console.Write("\nModelo: ");
                        carro[x].modelo = Console.ReadLine();
                        Console.Write("Fabricante: ");
                        carro[x].fabricante = Console.ReadLine();
                        Console.Write("Cor: ");
                        carro[x].cor = Console.ReadLine();
                        Console.Write("Ano: ");
                        carro[x].ano = int.Parse(Console.ReadLine());
                        Console.Write("Número de Portas: ");
                        carro[x].numero_portas = int.Parse(Console.ReadLine());
                        Console.Write("Tipo de Carro: ");
                        carro[x].tipoCarro = Console.ReadLine();
                        Console.Write("Capacidade do Porta Malas: ");
                        carro[x].capacidadePortaMala = int.Parse(Console.ReadLine());
                        Console.Write("Bagageiro (true/false): ");
                        carro[x].bagageiro = bool.Parse(Console.ReadLine());
                        Console.Write("Placa: ");
                        carro[x].placa = Console.ReadLine();
                        Console.WriteLine("\n---CADASTRO FINALIZADO---");
                        x++;
                        Console.ReadKey();
                        
                        break;
                    case 2:
                        Console.WriteLine("_____Cadastro de Caminhão_____");
                        Console.Write("\nModelo: ");
                        caminhao[y].modelo = Console.ReadLine();
                        Console.Write("Fabricante: ");
                        caminhao[y].fabricante = Console.ReadLine();
                        Console.Write("Cor: ");
                        caminhao[y].cor = Console.ReadLine();
                        Console.Write("Ano: ");
                        caminhao[y].ano = int.Parse(Console.ReadLine());
                        Console.Write("Número de Portas: ");
                        caminhao[y].numero_portas = int.Parse(Console.ReadLine());
                        Console.Write("Número de Eixos: ");
                        caminhao[y].numero_eixos = int.Parse(Console.ReadLine());
                        Console.Write("Peso máximo de carga: ");
                        caminhao[y].peso_maximo_carga = double.Parse(Console.ReadLine());
                        Console.Write("Peso do veículo: ");
                        caminhao[y].peso = double.Parse(Console.ReadLine());
                        Console.Write("Metragem do veículo: ");
                        caminhao[y].metragem = double.Parse(Console.ReadLine());
                        Console.Write("Placa: ");
                        caminhao[y].placa = Console.ReadLine();
                        Console.WriteLine("\n---CADASTRO FINALIZADO---");
                        Console.ReadKey();
                        y++;
                        break;
                    case 3:
                        Console.WriteLine("_____Consultar por Placa_____");
                        Console.Write("\nPlaca: ");
                        string placa = Console.ReadLine();
                        Console.WriteLine("\n---Carros---");
                        Console.WriteLine("Cod|  Modelo  |Fabricante|  Cor   |Ano |Placa");
                        for (x = 0; x < 300; x++)
                        {
                            if((carro[x].placa) == placa)
                            {
                                Console.WriteLine("{0,-3}|{1,-10}|{2,-10}|{3,-8}|{4,-4}|{5}", x, carro[x].modelo, carro[x].fabricante, carro[x].cor, carro[x].ano, carro[x].placa);
                            }
                        }
                        Console.WriteLine("\n---Caminhões---");
                        Console.WriteLine("Cod|  Modelo  |Fabricante|  Cor   |Ano |Placa");
                        for (y = 0; y < 200; y++)
                        {
                            if ((caminhao[y].placa) == placa)
                            {
                                Console.WriteLine("{0,-1}|{1,-10}|{2,-10}|{3,-8}|{4,-4}|{5}", y, caminhao[y].modelo, caminhao[y].fabricante, caminhao[y].cor, caminhao[y].ano, caminhao[y].placa);
                            }
                        }
                        Console.WriteLine("\n---TODOS VEÍCULOS ENCONTRADOS---");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("_____Consultar Caminhão por Marca_____");
                        Console.Write("\nMarca: ");
                        string marca = Console.ReadLine();
                        Console.WriteLine("\n---Caminhões---");
                        Console.WriteLine("Cod|  Modelo  |Fabricante|  Cor   |Ano |Placa");
                        for (y = 0; y < 200; y++)
                        {
                            if ((caminhao[y].modelo).ToUpper() == marca.ToUpper())
                            {
                                Console.WriteLine("{0,-3}|{1,-10}|{2,-10}|{3,-8}|{4,-4}|{5}", y, caminhao[y].modelo, caminhao[y].fabricante, caminhao[y].cor, caminhao[y].ano, caminhao[y].placa);
                            }
                        }
                        Console.WriteLine("\n---TODOS CAMINHÕES ENCONTRADOS---");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("_____Consultar Carro por Cor_____");
                        Console.Write("\nCor: ");
                        string cor = Console.ReadLine();
                        Console.WriteLine("\n---Carros---");
                        Console.WriteLine("Cod|  Modelo  |Fabricante|  Cor   |Ano |Placa");
                        for (x = 0; x < 200; x++)
                        {
                            if ((carro[x].cor).ToUpper() == cor.ToUpper())
                            {
                                Console.WriteLine("{0,-3}|{1,-10}|{2,-10}|{3,-8}|{4,-4}|{5}", x, carro[x].modelo, carro[x].fabricante, carro[x].cor, carro[x].ano, carro[x].placa);
                            }
                        }
                        Console.WriteLine("\n---TODOS CARROS ENCONTRADOS---");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("_____Todos os Carros_____");
                        Console.WriteLine("Cod|  Modelo  |Fabricante|  Cor   |Ano |Portas|   Tipo   |Placa");
                        for (x = 0; x < 200; x++)
                        { 
                                Console.WriteLine("{0,-3}|{1,-10}|{2,-10}|{3,-8}|{4,-4}|{5,-6}|{6,-10}|{7}", x, carro[x].modelo, carro[x].fabricante, carro[x].cor, carro[x].ano, carro[x].numero_portas, carro[x].tipoCarro, carro[x].placa);
                        }
                        Console.WriteLine("\n---TODOS CARROS---");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("_____Todos os Caminhões___");
                        Console.WriteLine("Cod|  Modelo  |Fabricante|  Cor   |Ano |Eixos|Peso Carga|  Peso  | Metragem |   Placa   ");
                        for (y = 0; y < 200; y++)
                        {
                            Console.WriteLine("{0,-3}|{1,-10}|{2,-10}|{3,-8}|{4,-4}|{5,-5}|{6,-10}|{7,-8}|{8,-10}|{9}", y, caminhao[y].modelo, caminhao[y].fabricante, caminhao[y].cor, caminhao[y].ano, caminhao[y].numero_eixos, caminhao[y].peso_maximo_carga, caminhao[y].peso, caminhao[y].metragem, caminhao[y].placa);
                        }
                        Console.WriteLine("\n---TODOS CAMINHÕES---");
                        Console.ReadKey();
                        break;
                }
                    
            } while (m != 0);
        }
    }
}

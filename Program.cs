using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite os dados para o Nokia:");
            Nokia nokiaPhone = CriarNokia();

            TestarSmartphone(nokiaPhone, "Snake");

            Console.WriteLine("Digite os dados para o iPhone:");
            Iphone iphone = CriarIphone();

            TestarSmartphone(iphone, "Instagram");
        }

        static Iphone CriarIphone()
        {
            Console.Write("Número: ");
            string numero = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("IMEI: ");
            string imei = Console.ReadLine();

            Console.Write("Memória: ");
            int memoria = SolicitarInteiro();

            return new Iphone(numero, modelo, imei, memoria);
        }

        static Nokia CriarNokia()
        {
            Console.Write("Número: ");
            string numero = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("IMEI: ");
            string imei = Console.ReadLine();

            Console.Write("Memória: ");
            int memoria = SolicitarInteiro();

            return new Nokia(numero, modelo, imei, memoria);
        }

        static int SolicitarInteiro()
        {
            while (true)
            {
                Console.Write("Insira um valor inteiro válido: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, insira um valor inteiro válido.");
                }
            }
        }

        static void TestarSmartphone(Smartphone smartphone, string aplicativo)
        {
            smartphone.Ligar();
            smartphone.ReceberLigacao();
            smartphone.InstalarAplicativo(aplicativo);
            Console.WriteLine();  // Adicionando uma linha em branco para melhorar a legibilidade
        }
    }
}
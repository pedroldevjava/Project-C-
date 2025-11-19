using System;
using System.Globalization;

namespace CourseCSharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem em sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome,idade e altura (mesma linha)");

            // método split para separar os dados em um vetor //
            string[] vetor = Console.ReadLine().Split(' ');
            
            // ---------------------------------//
            
            vetor[0] = nome;
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("SAÍDA ESPERADA (NÚMEROS REAIS COM DUAS CASAS DECIMAIS)"); ;

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
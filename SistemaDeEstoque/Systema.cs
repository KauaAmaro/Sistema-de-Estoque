using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[ ] args)
        { 
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto " + p);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite a quantidade a ser adicionado: ");
            int qrt = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qrt);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Dados atualizados " + p);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite a quantidade a ser retirada: ");
            int qrte = int.Parse(Console.ReadLine());
            p.RetirarProdutos(qrte);

            Console.WriteLine();
            Console.Write("Dados atualizados " + p);
            Console.WriteLine();

        }
    }
}
using System;
using System.Globalization;

namespace ProdutoEstoqueTS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            //Recebimento das informações
            Console.Write("Informe o nome do produto: ");
            p.Product = Console.ReadLine();
            Console.Write("Informe o preço do produto: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a quantidade em estoque: ");
            p.Qty = int.Parse(Console.ReadLine());

            //Exibição das informações iniciais
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine(" ");

            //Adição de produtos
            Console.Write("Informe a quantidade de produtos a serem adicionados: ");
            int qtt = int.Parse(Console.ReadLine());
            p.AddProduct(qtt);

            //Exibição das informações atualizadas após adição
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine(" ");

            //Subtração de produtos
            Console.Write("Informe a quantidade de produtos a serem removidos:");
            qtt = int.Parse(Console.ReadLine());
            p.RemoveProduct(qtt);

            //Exibição das informações atualizadas após subtração
            Console.WriteLine("Dados do Produto: " + p);

            Console.ReadKey();
        }
    }
}

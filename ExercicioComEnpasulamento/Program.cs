using System.Globalization;

namespace ExercicioComEnpasulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
           
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(add);
            Console.WriteLine();
            Console.Write("Dados Atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de prodrutos a ser removido do estoque: ");
            int rmv = int.Parse(Console.ReadLine());
            p.RemoverProdutos(rmv);
            Console.WriteLine();
            Console.Write("Dados Atualizados: " + p);

        }
    }
}

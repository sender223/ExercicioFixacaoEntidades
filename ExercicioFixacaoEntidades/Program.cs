using System;
using System.Globalization;
using ExercicioFixacaoEntidades.Entidades;
using ExercicioFixacaoEntidades.Entidades.Enums;

namespace ExercicioFixacaoEntidades {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Entre com os dados do Cliente: ");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY):");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());            
            Console.WriteLine("Entre com a data do Pedido: ");
            Console.Write("Status Pedido: ");
            StatusPedido statusPedido = Enum.Parse<StatusPedido>(Console.ReadLine());

            Cliente c1 = new Cliente(nomeCliente, emailCliente, dataNasc);
            Pedido p1 = new Pedido(DateTime.Now, statusPedido, c1);

            Console.WriteLine("Quantos Itens tem nesse pedido: ");
            int numItens = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numItens; i++) {
                Console.WriteLine($"Entre com os dados do {i}º Item: ");
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Entre com o Preço do Produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nomeProduto, precoProduto);

                Console.Write("Entre Com a Quantidade do Produto: ");
                int qntProduto = int.Parse(Console.ReadLine());

                ItemPedido itens = new ItemPedido(produto , precoProduto, qntProduto);
                p1.AdicionarItem(itens);               

            }

            Console.WriteLine();
            Console.WriteLine("Resumo do Pedido: ");
            Console.WriteLine(p1);
        }
    }
}

using System;
using System.Globalization;
using ExercicioFixacaoEntidades.Entidades;
using ExercicioFixacaoEntidades.Entidades.Enums;

namespace ExercicioFixacaoEntidades {
    class Program {
        static void Main(string[] args) {
            //solicitando os dados ao usuário
            Console.WriteLine("Entre com os dados do Cliente: ");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY):");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());            
            Console.WriteLine("Entre com a data do Pedido: ");
            Console.Write("Status Pedido: ");
            //aqui o statusPedido1 será convertido de string para Enum modo net.core
            StatusPedido statusPedido = Enum.Parse<StatusPedido>(Console.ReadLine());
            //aqui o statusPedido2 será convertido de string para Enum modo netframework.(USE O PRIMEIRO OU O SEGUNDO)
            StatusPedido statusPedido2 = (StatusPedido)Enum.Parse(typeof(StatusPedido), Console.ReadLine());
            //instanciando a classe Cliente e atribuindo os valores diretamente
            Cliente c1 = new Cliente(nomeCliente, emailCliente, dataNasc);
            //instanciando a classe Pedido e atribuindo os valores diretamente, incluindo a composição c1 do cliente.
            Pedido p1 = new Pedido(DateTime.Now, statusPedido, c1);

            Console.WriteLine("Quantos Itens tem nesse pedido: ");
            int numItens = int.Parse(Console.ReadLine());
            //fazendo um for para cadastrar todos os itens que o usuário solicitou.
            for (int i = 1; i <= numItens; i++) {
                Console.WriteLine($"Entre com os dados do {i}º Item: ");
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Entre com o Preço do Produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //instanciando a classe Produto e atribuindo os valores diretamente
                Produto produto = new Produto(nomeProduto, precoProduto);

                Console.Write("Entre Com a Quantidade do Produto: ");
                int qntProduto = int.Parse(Console.ReadLine());
                //instanciando a classe ItemPedido e atribuindo os valores diretamente, incluindo o 
                //nome do produto que se encontra na variavel produto que declaramos acima. 
                ItemPedido itens = new ItemPedido(produto , precoProduto, qntProduto);
                //pegamos a variavel p1 de "pedido" e chamamos a função adicionarItem e inserimos o "itens"
                //da classe ItemPedido.
                p1.AdicionarItem(itens);               

            }
            //finalizando imprimindo tudo. 
            Console.WriteLine();
            Console.WriteLine("Resumo do Pedido: ");
            Console.WriteLine(p1);
        }
    }
}

using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoEntidades.Entidades {
    class ItemPedido {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        //aqui estamos compondo o objeto usando a classe Produto
        //para sabermos o nome do produto e o valor cadastrado inicialmente.
        //na notação UML podemos verificar essa marcação.
        public Produto Produto { get; set; }

        public ItemPedido() {
        }

        public ItemPedido(Produto produto, double preco, int quantidade) {
            Produto = produto;            
            Preco = preco;
            Quantidade = quantidade;
        }

        public double SubTotal() {
            return Preco * Quantidade;

        }
        //usamos o override string para imprimir os itens.
        public override string ToString() {
            return Produto.Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

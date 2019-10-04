using System.Globalization;

namespace ExercicioFixacaoEntidades.Entidades {
    class ItemPedido {
       //atributos autoimplementados
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        //aqui estamos compondo o objeto usando a classe Produto
        //para sabermos o nome do produto e o valor cadastrado inicialmente.
        //na notação UML podemos verificar essa marcação.
        public Produto Produto { get; set; }
        //construtor padrao
        public ItemPedido() {
        }
        //construror com argumentos
        public ItemPedido(Produto produto, double preco, int quantidade) {
            Produto = produto;            
            Preco = preco;
            Quantidade = quantidade;
        }
        //metodo para calcular o subtotal dos itens
        public double SubTotal() {
            return Preco * Quantidade;

        }
        //metodo para representar o objeto em forma de string
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

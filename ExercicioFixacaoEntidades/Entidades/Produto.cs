namespace ExercicioFixacaoEntidades.Entidades {
    class Produto {
        //propriedades autoimplementadas
        public string Nome { get; set; }
        //aqui precisamos deixar cadastrado o preço do produto inicial. 
        //
        public double Preco { get; set; }
        //construtor
        public Produto() {
        }
        //construtor com argumentos
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
}


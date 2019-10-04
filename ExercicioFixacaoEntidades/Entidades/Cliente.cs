using System;

namespace ExercicioFixacaoEntidades.Entidades {
    class Cliente {
        //propriedades autoimplementadas
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }

        //construtor padrao
        public Cliente() {

        }
        //construtor com argumentos
        public Cliente(string nome, string email, DateTime aniversario) {
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
        }
        //metodo para representar o objeto em forma de string
        public override string ToString() {
            return Nome
                + ", ("
                + Aniversario.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}

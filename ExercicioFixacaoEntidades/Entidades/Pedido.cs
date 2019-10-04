using System;
using System.Text;
using ExercicioFixacaoEntidades.Entidades.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoEntidades.Entidades {
    class Pedido {
        //propriedades autoimplementadas
        public DateTime Data { get; set; }
        //chamando a Composição do tipo Enum.
        public StatusPedido Status { get; set; }
        //criando uma lista do tipo ItemPedido e instanciando a mesma para que não seja nula
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        //chamando a Composição Cliente
        public Cliente Cliente { get; set; }
        //construtor padrao
        public Pedido() {
        }
        //construtor padrao com argumentos, incluindo as composições. 
        public Pedido(DateTime data, StatusPedido status, Cliente cliente) {
            Data = data;
            Status = status;            
            Cliente = cliente;
        }
        //metodo para adicionar um item ao ItemPedido
        public void AdicionarItem(ItemPedido item) {
            Itens.Add(item);
        }
        //metodo para remover um item ao ItemPedido
        public void RemoveItem(ItemPedido item) {
            Itens.Add(item);
        }
        //metodo para calcular o total do pedido
        public double Total() {
            //cria uma variavel soma que ira receber valor zerado
            double soma = 0.0;
            //percorre todos os "Itens" do tipo ItemPedido
            foreach(ItemPedido item in Itens) {
                //se existir soma recebe ele mesmo + item.Subtotal()
                soma = soma + item.SubTotal();
            }
            //retorna o valor total da soma
            return soma;
        }
        //aqui criamos o metodo StringBuilder para construir uma estrutura de string para ser exibida.
        public override string ToString() {
            StringBuilder sb = new StringBuilder();            
            sb.AppendLine("Data do Pedido: " + Data.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Pedido: " + Status);
            sb.AppendLine("Nome do Cliente: " + Cliente);
            sb.AppendLine("Itens do Pedido:");
            //para cada item em Itens do tipo ItemPedido
            foreach (ItemPedido item in Itens) {
                //Imprima o item e transformado em string.
                sb.AppendLine(item.ToString());
            }
            
            sb.AppendLine("Preço Total: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}

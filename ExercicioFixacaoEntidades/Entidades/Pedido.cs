using System;
using System.Text;
using ExercicioFixacaoEntidades.Entidades.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoEntidades.Entidades {
    class Pedido {

        public DateTime Data { get; set; }
        public StatusPedido Status { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        public Cliente Cliente { get; set; }

        public Pedido() {
        }

        public Pedido(DateTime data, StatusPedido status, Cliente cliente) {
            Data = data;
            Status = status;            
            Cliente = cliente;
        }

        public void AdicionarItem(ItemPedido item) {
            Itens.Add(item);
        }
        public void RemoveItem(ItemPedido item) {
            Itens.Add(item);
        }

        public double Total() {
            double soma = 0.0;
            foreach(ItemPedido item in Itens) {
                soma = soma + item.SubTotal();
            }
            return soma;
        }
        //aqui criamos o metodo StringBuilder para construir uma estrutura de string para ser exibida.
        public override string ToString() {
            StringBuilder sb = new StringBuilder();            
            sb.AppendLine("Data do Pedido: " + Data.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Pedido: " + Status);
            sb.AppendLine("Nome do Cliente: " + Cliente);
            sb.AppendLine("Itens do Pedido:");
            foreach (ItemPedido item in Itens) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço Total: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}

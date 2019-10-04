using System;
using ExercicioFixacaoEntidades.Entidades.Enums;
using System.Collections.Generic;

namespace ExercicioFixacaoEntidades.Entidades {
    class Pedido {

        public DateTime Data { get; set; }
        public StatusPedido Status { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        public Cliente Cliente { get; set; }

        public Pedido() {
        }

        public Pedido(DateTime data, StatusPedido status, List<ItemPedido> itens, Cliente cliente) {
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
            foreach(ItemPedido i in)

        }
    }
}

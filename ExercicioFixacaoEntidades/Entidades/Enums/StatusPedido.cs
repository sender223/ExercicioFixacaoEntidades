namespace ExercicioFixacaoEntidades.Entidades.Enums {
    //classe do tipo Enum para representar o status do pedido.
    enum StatusPedido : int {
        PAGAMENTO_PENDENTE = 0,
        PROCESSANDO = 1,
        ENVIANDO = 2,
        ENTREGUE = 3
    }
}

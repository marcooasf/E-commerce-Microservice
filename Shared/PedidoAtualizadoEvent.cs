namespace Shared;

public class PedidoAtualizadoEvent
{
    public Guid PedidoId { get; set; }
    public string ClienteNome { get; set; } = string.Empty;
    public string ClienteEmail { get; set; } = string.Empty;
    public string StatusPedido { get; set; } = string.Empty;
    public decimal ValorTotal { get; set; }
    public DateTime DataAtualizacao { get; set; }
}
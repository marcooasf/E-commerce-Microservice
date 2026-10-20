namespace OrderApi.Dtos;

public class AtualizarPedidoRequest
{
    public string ClienteNome { get; set; } = string.Empty;
    public string ClienteEmail { get; set; } = string.Empty;
    public string StatusPedido { get; set; } = string.Empty;
    public decimal ValorTotal { get; set; }
}
namespace HC_7572.Domain.Objects;

public sealed class Product
{
    public Guid Id { get; set; }

    public string Sku { get; set; } = null!;

    public string Name { get; set; } = null!;
}
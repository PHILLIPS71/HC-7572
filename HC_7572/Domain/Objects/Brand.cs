namespace HC_7572.Domain.Objects;

public sealed class Brand
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<Product> Products { get; set; } = [];
}
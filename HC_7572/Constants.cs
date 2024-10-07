using HC_7572.Domain.Objects;

namespace HC_7572;

public sealed class Constants
{
    public static ICollection<Brand> Brands = new List<Brand>
    {
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Nike",
            Products = new List<Product>
            {
                new() { Id = Guid.NewGuid(), Sku = Guid.NewGuid().ToString(), Name = "Air Jordan", },
                new() { Id = Guid.NewGuid(), Sku = Guid.NewGuid().ToString(), Name = "Air Force 1", }
            }
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "Adidas",
            Products = new List<Product>
            {
                new() { Id = Guid.NewGuid(), Sku = Guid.NewGuid().ToString(), Name = "Ultraboost 1.0", },
                new() { Id = Guid.NewGuid(), Sku = Guid.NewGuid().ToString(), Name = "Gazelle", }
            }
        }
    };
}
using HC_7572.Domain.Objects;
using HotChocolate.Pagination;
using HotChocolate.Types.Pagination;

namespace HC_7572.GraphQL.Types.Objects;

[ObjectType<Brand>]
public static partial class BrandType
{
    [UsePaging]
    internal static Connection<Product> GetProducts(
        [Parent(nameof(Brand.Id))] Brand parent,
        PagingArguments arguments,
        CancellationToken cancellation)
    {
        var edges = Constants
            .Brands
            .Where(x => x.Id == parent.Id)
            .SelectMany(x => x.Products)
            .Select(user => new Edge<Product>(user, y => y.Id.ToString()))
            .ToList();

        var info = new ConnectionPageInfo(false, false, null, null);
        var connection = new Connection<Product>(edges, info);

        return connection;
    }
}
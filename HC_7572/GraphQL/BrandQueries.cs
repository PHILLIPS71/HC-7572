using HC_7572.Domain.Objects;

namespace HC_7572.GraphQL;

[QueryType]
internal sealed class BrandQueries
{
    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Brand> Brands() => Constants.Brands.AsQueryable();
}
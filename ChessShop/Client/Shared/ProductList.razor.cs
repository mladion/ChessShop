using ChessShop.Shared;

namespace ChessShop.Client.Shared
{
    public partial class ProductList
    {
        List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Title = "Modern Chess Openings",
                Description = "A chess opening or simply an opening is the initial stage of a chess game.",
                Image = "https://www.libris.ro/img/pozeprod/59/1002/BC/15187043.jpg",
                Price = 159.03m,
                OriginalPrice = 199.99m
            },
            new Product
            {
                Id = 2,
                CategoryId = 3,
                Title = "Queen's Indian: Move by Move",
                Description = "This series provides an ideal platform to study chess openings.",
                Image = "https://cdn4.libris.ro/img/pozeprod/59/1002/D0/10932353.jpg",
                Price = 110.03m,
                OriginalPrice = 149.99m
            }
        };
    }
}

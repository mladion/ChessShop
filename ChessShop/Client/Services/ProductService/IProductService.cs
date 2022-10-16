using ChessShop.Shared;

namespace ChessShop.Client.Services.ProductService
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}


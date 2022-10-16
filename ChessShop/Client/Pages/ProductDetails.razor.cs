using ChessShop.Shared;
using Microsoft.AspNetCore.Components;

namespace ChessShop.Client.Pages
{
    public partial class ProductDetails
    {
        private Product? product = null;

        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            if (ProductService.Products == null || ProductService.Products.Count == 0)
                ProductService.LoadProducts();
            else
                product = ProductService.Products.FirstOrDefault(x => x.Id == Id);
        }
    }
}

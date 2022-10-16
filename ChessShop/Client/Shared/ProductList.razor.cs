namespace ChessShop.Client.Shared
{
    public partial class ProductList
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            ProductService.LoadProducts();
        }
    }
}

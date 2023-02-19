using ServiceFUEN.Models.EFModels;

namespace ServiceFUEN.Models.ViewModels
{
    public static partial class ProductExts
    {
        public static ProductDetailVM ToProductDetailVM(this Product product)
        {
            return new ProductDetailVM
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                BrandId= product.BrandId,
                CategoryId= product.CategoryId,
                ReleaseDate= product.ReleaseDate,
                ManufactorDate= product.ManufactorDate,
                ProductSpec = product.ProductSpec,
                Source = product.ProductPhotos.Select(x=>x.Source).ToList(),
                Inventory= product.Inventory,
            };
        }



    }
}

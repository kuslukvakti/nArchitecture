namespace RentACar.Application.Features.Brands.Models
{
    using Core.Persistence.Paging;
    using RentACar.Application.Features.Brands.Dtos;

    public class BrandListModel : BasePageableModel
    {
        public IList<BrandListDto> Items { get; set; } 
    }
}

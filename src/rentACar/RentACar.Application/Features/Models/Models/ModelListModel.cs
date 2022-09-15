namespace RentACar.Application.Features.Models.Models
{
    using Core.Persistence.Paging;
    using RentACar.Application.Features.Models.Dtos;
    using System.Collections.Generic;

    public class ModelListModel : BasePageableModel
    {
        public IList<ModelListDto> Items { get; set; }
    }
}

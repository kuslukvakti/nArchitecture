namespace RentACar.WebAPI.Controllers
{
    using Application.Features.Brands.Commands.CreateBrand;
    using Application.Features.Brands.Dtos;
    using Core.Application.Requests;
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Application.Features.Brands.Models;
    using RentACar.Application.Features.Brands.Queries.GetListBrand;

    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
            CreatedBrandDto result = await Mediator.Send(createBrandCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQuery getListBrandQuery = new() { PageRequest = pageRequest };
            
            BrandListModel result = await Mediator.Send(getListBrandQuery);

            return Ok(result);
        }

    }
}

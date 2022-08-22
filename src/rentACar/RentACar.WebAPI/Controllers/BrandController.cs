namespace RentACar.WebAPI.Controllers
{
    using Application.Features.Brands.Commands.CreateBrand;
    using Application.Features.Brands.Dtos;
    using Microsoft.AspNetCore.Mvc;

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
    }
}

﻿namespace RentACar.WebAPI.Controllers
{
    using RentACar.Application.Features.Models.Models;
    using RentACar.Application.Features.Models.Queries.GetListModel;
    using RentACar.Application.Features.Models.Queries.GetListModelByDynamic;
    using Core.Application.Requests;
    using Core.Persistence.Dynamic;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new GetListModelQuery { PageRequest = pageRequest };
            ModelListModel result = await Mediator.Send(getListModelQuery);
            return Ok(result);

        }

        [HttpPost("GetList/ByDynamic")]
        public async Task<ActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] Dynamic dynamic)
        {
            GetListModelByDynamicQuery getListByDynamicModelQuery = new GetListModelByDynamicQuery { PageRequest = pageRequest, Dynamic = dynamic };
            ModelListModel result = await Mediator.Send(getListByDynamicModelQuery);
            return Ok(result);

        }
    }
}
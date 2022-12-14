namespace RentACar.WebAPI.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    public class BaseController : ControllerBase
    {
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private IMediator? _mediator;


    }
}

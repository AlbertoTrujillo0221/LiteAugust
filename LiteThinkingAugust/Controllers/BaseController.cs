using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LiteThinkingAugust.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;

        protected IMediator Mediator => this._mediator;

        protected IMapper Mapper;
        
    }
}

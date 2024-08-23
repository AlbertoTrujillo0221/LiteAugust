using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Core;

namespace LiteThinkingAugust.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;

        protected IMediator Mediator => this._mediator ??= EngineContext.Current.Resolve<IMediator>();

        protected IMapper Mapper => EngineContext.Current.Resolve<Mapper>();        
    }
}

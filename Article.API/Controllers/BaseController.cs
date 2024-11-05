using Article.Domain.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Article.API.Controllers;


[ApiController]
public class BaseController : ControllerBase
{
    protected readonly IMediator _mediator;
    public BaseController(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected IActionResult ParseResult<T>(ServiceResponse<T> result)
    {
        return result.Status == ResponseStatus.Failed ? BadRequest(result) : Ok(result);
    }

    protected IActionResult ParseRawResult<T>(ServiceResponse<T> result)
    {
        return result.Status == ResponseStatus.Failed ? BadRequest(result.ResponseObject) : Ok(result.ResponseObject);
    }
}
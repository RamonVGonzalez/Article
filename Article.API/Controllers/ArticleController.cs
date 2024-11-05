using Article.Domain.Base;
using Article.Domain.DTO;
using Article.Services.LikeFeature.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Article.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ArticleController : BaseController
{
    private readonly ILogger<ArticleController> _logger;

    public ArticleController(
        ILogger<ArticleController> logger,
        IMediator mediator)
        :base(mediator)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("LikeArticle")]
    [Produces(typeof(ServiceResponse<LikeArticleResponse>))]
    public async Task<IActionResult> BuyTreasuryBill([FromBody] LikeArticleRequest request)
    {
        LikeCommand command = new(request);

        var result = await _mediator.Send(command);

        return ParseResult(result);
    }
}


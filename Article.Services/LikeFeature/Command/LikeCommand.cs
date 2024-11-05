
using Article.Domain.Base;
using Article.Domain.DTO;
using Article.Services.Messaging;

namespace Article.Services.LikeFeature.Command;

public record LikeCommand (LikeArticleRequest Request)
 : ICommand<ServiceResponse<LikeArticleResponse>>
{

}

public class LikeCommandHandler : ICommandHandler<LikeCommand, ServiceResponse<LikeArticleResponse>>
{
    public Task<ServiceResponse<ServiceResponse<LikeArticleResponse>>> Handle(LikeCommand request, CancellationToken cancellationToken)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
}

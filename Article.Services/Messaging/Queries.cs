using Article.Domain.Base;
using MediatR;

namespace Article.Services.Messaging;

public interface IQuery<TResponse>
    : IRequest<ServiceResponse<TResponse>>
{
}

public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, ServiceResponse<TResponse>>
    where TQuery : IQuery<TResponse>
{
}

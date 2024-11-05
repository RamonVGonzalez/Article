using Article.Domain.Base;
using MediatR;

namespace Article.Services.Messaging;

public interface ICommand<TResponse>
    : IRequest<ServiceResponse<TResponse>>
{
}

public interface ICommandHandler<TCommand, TResponse>
    : IRequestHandler<TCommand, ServiceResponse<TResponse>>
    where TCommand : ICommand<TResponse>
{
}

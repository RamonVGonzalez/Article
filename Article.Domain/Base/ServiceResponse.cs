namespace Article.Domain.Base;
public class ServiceResponse<T>
{
    public string Message { get; }
    public ResponseStatus Status { get; } = ResponseStatus.Failed;
    public T? ResponseObject { get; } = default;
    public bool ResponseObjectExists { get; } = false;

    public ServiceResponse(string message)
    {
        Message = message;
    }
    public ServiceResponse(string message, ResponseStatus status)
        : this(message)
    {
        Status = status;
    }

    public ServiceResponse(T? responseObject, string message = "success")
        : this(message, ResponseStatus.Success)
    {
        ResponseObject = responseObject;
        ResponseObjectExists = responseObject != null;
    }
}

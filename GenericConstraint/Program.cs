var handler = new Handler<Request, Response>();
var result = handler.Handle(null);
if (result.Message is null)
{
}

public class Handler<TRequest, TResponse>
    where TRequest : IRequest
    where TResponse : IResponse
{
    public TResponse Handle(TRequest request)
    {
        return default;
    }
}

public interface IRequest { }
public interface IResponse { }

public class Request : IRequest
{
    public string Email { get; set; } = string.Empty;
}

public class Response : IResponse
{
    public string Message { get; set; } = string.Empty;
}
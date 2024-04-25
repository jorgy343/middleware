namespace Middleware;

public class InterfaceMiddlewareBinder
{
    private readonly Type _middlewareType;

    public InterfaceMiddlewareBinder(Type middlewareType)
    {
        _middlewareType = middlewareType ?? throw new ArgumentNullException(nameof(middlewareType));
    }

    public MiddlewareDelegate CreateMiddleware(MiddlewareDelegate next)
    {
        return async context =>
        {
            IMiddleware? middleware = context.Services.GetService(_middlewareType) as IMiddleware;

            if (middleware is null)
            {
                throw new InvalidOperationException();
            }

            await middleware.InvokeAsync(context, next);
        };
    }
}
namespace Middleware;

public interface IMiddleware
{
    Task InvokeAsync(MiddlewareContext context, MiddlewareDelegate next);
}
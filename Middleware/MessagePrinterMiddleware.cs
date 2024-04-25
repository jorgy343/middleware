namespace Middleware;

public class MessagePrinterMiddleware : IMiddleware
{
    public async Task InvokeAsync(MiddlewareContext context, MiddlewareDelegate next)
    {
        Console.WriteLine($"Key: {context.Message.Key}, Value: {context.Message.Value}");
        await next(context);
    }
}
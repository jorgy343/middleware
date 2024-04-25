namespace Middleware;

public static class Extensions
{
    public static MiddlewareBuilder AddExceptionHandling(this MiddlewareBuilder builder)
    {
        InterfaceMiddlewareBinder binder = new(typeof(ExceptionHandlingMiddleware));
        builder.Use(binder.CreateMiddleware);

        return builder;
    }

    public static MiddlewareBuilder AddMessagePrinting(this MiddlewareBuilder builder)
    {
        InterfaceMiddlewareBinder binder = new(typeof(MessagePrinterMiddleware));
        builder.Use(binder.CreateMiddleware);

        return builder;
    }
}
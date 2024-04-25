namespace Middleware;

public static class ExampleUse
{
    public static async Task Example()
    {
        MiddlewareBuilder builder = new();

        MiddlewareDelegate middlewareEntry = builder
            .AddExceptionHandling()
            .AddMessagePrinting()
            .Build();

        MiddlewareContext context = new(null!, null!); // Nulls just for examples sake.

        await middlewareEntry(context);
    }
}
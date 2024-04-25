namespace Middleware;

public class MiddlewareBuilder
{
    private readonly List<Func<MiddlewareDelegate, MiddlewareDelegate>> _components = [];

    public MiddlewareBuilder Use(Func<MiddlewareDelegate, MiddlewareDelegate> middleware)
    {
        _components.Add(middleware);
        return this;
    }

    public MiddlewareDelegate Build()
    {
        MiddlewareDelegate app = message =>
        {
            return Task.CompletedTask;
        };

        for (int i = _components.Count - 1; i >= 0; i--)
        {
            app = _components[i](app);
        }

        return app;
    }
}
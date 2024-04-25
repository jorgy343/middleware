namespace Middleware;

public record class MiddlewareContext(IServiceProvider Services, Message Message);
using Microsoft.AspNetCore.Builder;

namespace JapaneseBackend.Middlewares
{
    public static class GraphQlMiddlewareExtensions
    {
        public static IApplicationBuilder UseGraphQl(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GraphQlMiddleware>();
        }
    }
}

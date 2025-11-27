using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace MyApi.Filters
{
    public class TimeActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var sw = Stopwatch.StartNew();

            var result = await next(); // run action

            sw.Stop();
            Console.WriteLine($"⏱ Execution Time: {sw.ElapsedMilliseconds} ms");
        }
    }
}

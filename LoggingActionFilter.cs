using Microsoft.AspNetCore.Mvc.Filters;

namespace MyApi.Filters
{
    public class LoggingActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("➡ Before Action: " + context.ActionDescriptor.DisplayName);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("⬅ After Action: " + context.ActionDescriptor.DisplayName);
        }
    }
}

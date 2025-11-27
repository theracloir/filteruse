using Microsoft.AspNetCore.Mvc.Filters;

namespace MyApi.Filters
{
    public class ResultFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("➡ Before sending response...");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("⬅ Response sent to client.");
        }
    }
}

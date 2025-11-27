using Microsoft.AspNetCore.Mvc.Filters;

namespace MyApi.Filters
{
    public class ResourceFilter : IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("🔹 Resource filter BEFORE everything.");
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("🔹 Resource filter AFTER everything.");
        }
    }
}

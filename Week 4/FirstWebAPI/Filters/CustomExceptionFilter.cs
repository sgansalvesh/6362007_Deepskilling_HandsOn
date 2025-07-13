using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiHandson.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var message = $"[{DateTime.Now}] {exception.Message}\n";

            File.AppendAllText("exceptions.log", message); // Logs to file

            context.Result = new ObjectResult("An internal error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}

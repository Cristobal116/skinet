
namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            // La siguiente sintaxis de switch está disponible a partir de la versión 8 de C#.
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the path to the dark side. Erros leads to anger. Anger leads to hate. Hate leads to career change",
                _ => null
            };
        }
    }
}
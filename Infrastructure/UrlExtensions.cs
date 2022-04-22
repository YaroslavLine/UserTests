namespace UserTests.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request)
        {
            return !request.QueryString.HasValue ? request.Path.ToString() : request.Path + request.QueryString;
        }
    }
}
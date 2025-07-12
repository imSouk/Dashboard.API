using Microsoft.AspNetCore.Http;

namespace Dashboard_webAPI.Core.Interfaces
{
    public  interface ICookieService
    {
        public  HttpResponse GenerateCookie(HttpResponse response, string token)
        {
            return response;
        }
    }
}

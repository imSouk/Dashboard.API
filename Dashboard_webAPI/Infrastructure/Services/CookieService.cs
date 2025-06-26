

namespace Dashboard_webAPI.Infrastructure.Services
{
    public class CookieService
    {
        public static HttpResponse GenerateCookie(HttpResponse response, string token)
        {
            
            response.Cookies.Append("UserCookie", token);
            CookieOptions cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddHours(8),
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict
            };
            response.Cookies.Append("CookieOptions","cookieValueWithOptions", cookieOptions);
            return response;
        }
    }
}

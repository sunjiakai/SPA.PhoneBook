using Microsoft.AspNetCore.Antiforgery;
using SPA.PhoneBook.Controllers;

namespace SPA.PhoneBook.Web.Host.Controllers
{
    public class AntiForgeryController : PhoneBookControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

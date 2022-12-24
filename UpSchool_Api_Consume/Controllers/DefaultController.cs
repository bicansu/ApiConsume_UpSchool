using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Threading.Tasks;

namespace UpSchool_Api_Consume.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44349/api/Category");
            if(responseMessage.StatusCode==System.Net.HttpStatusCode.OK)
            {
                var response = await responseMessage.Content.ReadAsStringAsync();
                return View();
            }
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        //[Route("")]
        public string Phone()
        {
            return "26250213";
        }
        //[Route("address")]
        public string Address()
        {
            return "Helgesensgade";
        }
    }
}

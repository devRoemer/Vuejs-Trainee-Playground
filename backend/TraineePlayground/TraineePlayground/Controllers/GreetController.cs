using Microsoft.AspNetCore.Mvc;
using TraineePlayground.Services;

namespace TraineePlayground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetController : ControllerBase
    {
        private GreetService Service;

        public GreetController(GreetService service)
        {
            Service = service;
        }

        [HttpGet]
        public string Get([FromQuery] string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new System.Exception("UserName may not be empty");
            }

            return Service.Greet(userName);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Controllers
{
    [Route("khach-hang")]
    public class CustomerController : Controller
    {
        [Route("vip/{id:int}")]
        public string Vip(int id)
        {
            return "<h1>Khách hàng vip</h1>, ID: " + id;
        }
        [Route("vip/{id:alpha}")]
        public string Vip(string id)
        {
            return "<h1>Khách hàng vip</h1>, ID: " + id;
        }

        [Route("")]
        [Route("normal")]
        public string Normal()
        {
            return "<h1>Khách hàng thường</h1>";
        }
    }
}
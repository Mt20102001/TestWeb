using Microsoft.AspNetCore.Mvc;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class PostController : Controller
    {
        public string PostsByID(int id)
        {
            return "Hello from PostController, ID: " + id;
        }

        public string PostsByPostName(string id)
        {
            return "Hello from PostController, ID: " + id;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return "Hello from AdminController";
        }
    }
}
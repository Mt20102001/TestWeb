using Microsoft.AspNetCore.Mvc;
using TestWeb.Models;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace TestWeb.Controllers
{
    public class HomeController : Controller
    {
        // HttpContext ctx;
        // public HomeController(IHttpContextAccessor _ctx)
        // {
        //     ctx = _ctx.HttpContext;
        // }

        //[Route("Home/Index/{id:int}")]
        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "Hello from Model, ID = " + id;
            return View(model);
        }

        // public async void Index()
        // {
        //     //Set Status Code
        //     ctx.Response.StatusCode = 200;
        //     //Set Context Type
        //     ctx.Response.ContentType = "text/html";
        //     //Create Response
        //     ctx.Response.Headers.Add("SomeHeader","Value");
        //     byte[] content = Encoding.ASCII.GetBytes(s:$"<html><body><p>My first paragraph.</p></body>");
        //     //Send it to the Client
        //     await ctx.Response.Body.WriteAsync(content, offset:0, count:content.Length);
        // }

        // public IActionResult Index(int id)
        // {
        //     if(id == 0)
        //         return NotFound();
            
        //     return Content("Hello World");
        // }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pizza.crud.Models;

namespace pizza.crud.Controllers;

public class BreadController : Controller
{
    private readonly ILogger<BreadController> _logger;

    private readonly IBreadService _breadService;

    public BreadController (ILogger<BreadController> logger ,IBreadService breadService)
    {
        _logger = logger;
        _breadService = breadService;
    }

     public IActionResult AddBread() //empty form
    {
        return View();
    }

      
      [HttpPost] //action verb 

       public IActionResult AddBread(BreadRequestModel requestModel) //action method
    {
        Bread bread = _breadService.AddNewBread(requestModel);

        return RedirectToAction("GetAllBread");
    }

     [HttpGet]
    public IActionResult GetBread(int id)
    {
        Bread bre = _breadService.GetBread(id);
        return View(bre);
    }

     public  IActionResult GetAllBread()
    {
       List<Bread> piz = _breadService.GetAllBread();
       return View(piz);
    }

   [HttpGet]
       public  IActionResult UpdateBread(int id)
    {
        Bread pi = _breadService.GetBread(id);
         return View(pi);

    }

    [HttpPost]
       public  IActionResult UpdateBread(Bread bread)
    {
        Bread piz = _breadService.UpdateBread(bread);
         return RedirectToAction("GetAllBread");
    }

 [HttpGet]
       public  IActionResult DeleteBread(int id)
    {
        Bread bread = _breadService.GetBread(id);
         return View(bread);
    }

     [HttpPost , ActionName("DeleteBread")] //Method overloading i.e dis one , dis one , we can't have same deletepizza method.
       public  IActionResult RealDelete(int id)
    {
        _breadService.DeleteNewBread(id);
         return RedirectToAction("GetAllBread");
    }

    


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

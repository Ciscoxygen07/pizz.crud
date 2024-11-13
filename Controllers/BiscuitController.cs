using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pizza.crud.Models;

namespace pizza.crud.Controllers;

public class BiscuitController : Controller
{
    private readonly ILogger<BiscuitController> _logger;

    private readonly IBiscuitService _biscuitService;

    public BiscuitController (ILogger<BiscuitController> logger ,IBiscuitService biscuitService)
    {
        _logger = logger;
        _biscuitService = biscuitService;
    }

     public IActionResult AddBiscuit() //empty form
    {
        return View();
    }

      
      [HttpPost] //action verb 

       public IActionResult AddBiscuit(BiscuitRequestModel biscuitrequestModel) //action method
    {
        Biscuit biscuit = _biscuitService.AddNewBiscuit(biscuitrequestModel);

        return RedirectToAction("GetAllBiscuit");
    }

     [HttpGet]
    public IActionResult GetBiscuit(int id)
    {
        Biscuit bre = _biscuitService.GetBiscuit(id);
        return View(bre);
    }

     public  IActionResult GetAllBiscuit()
    {
       List<Biscuit> piz = _biscuitService.GetAllBiscuit();
       return View(piz);
    }

   [HttpGet]
       public  IActionResult UpdateBiscuit(int id)
    {
        Biscuit pi = _biscuitService.GetBiscuit(id);
         return View(pi);

    }

    [HttpPost]
       public  IActionResult UpdateBiscuit(Biscuit biscuit)
    {
        Biscuit piz = _biscuitService.UpdateBiscuit(biscuit);
         return RedirectToAction("GetAllBiscuit");
    }

 [HttpGet]
       public  IActionResult DeleteBiscuit(int id)
    {
        Biscuit biscuit = _biscuitService.GetBiscuit(id);
         return View (biscuit);
    }

     [HttpPost , ActionName("DeleteBiscuit")] //Method overloading i.e dis one , dis one , we can't have same deletepizza method.
       public  IActionResult RealDelete(int id)
    {
        _biscuitService.DeleteBiscuit(id);
         return RedirectToAction("GetAllBiscuit");
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

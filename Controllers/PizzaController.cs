using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pizza.crud.Models;

namespace pizza.crud.Controllers;

public class PizzaController : Controller
{
    private readonly ILogger<PizzaController> _logger;

    private readonly IPizzaService _pizzaService;

    public PizzaController (ILogger<PizzaController> logger ,IPizzaService pizzaService)
    {
        _logger = logger;
        _pizzaService = pizzaService;
    }

     public IActionResult AddPizza() //empty form
    {
        return View();
    }

      
      [HttpPost] //action verb 

       public IActionResult AddPizza(PizzaRequestModel pizzaRequestModel) //action method
    {
        Pizza pizza = _pizzaService.AddNewPizza(pizzaRequestModel);

        return RedirectToAction("GetAllPizza");
    }

    //    [HttpPost] //action verb 

    //    public IActionResult AddPizza(PizzaRequestModel pizzaRequestModel) //action method
    // {
    //     Pizza pizza = _pizzaService.AddNewPizza(pizzaRequestModel);

    //     return RedirectToAction("Privacy", "Home");
    // }

     [HttpGet]
    public IActionResult GetPizza(int id)
    {
        Pizza pi = _pizzaService.GetPizza(id);
        return View(pi);
    }

     public  IActionResult GetAllPizza()
    {
       List<Pizza> piz = _pizzaService.GetAllPizza();
       return View(piz);
    }

   [HttpGet]
       public  IActionResult UpdatePizza(int id)
    {
        Pizza pi = _pizzaService.GetPizza(id);
         return View(pi);

    }

    [HttpPost]
       public  IActionResult UpdatePizza(Pizza model)
    {
        Pizza piz = _pizzaService.UpdatePizza(model);
         return RedirectToAction("GetAllPizza");
    }

 [HttpGet]
       public  IActionResult DeletePizza(int id)
    {
        Pizza pi = _pizzaService.GetPizza(id);
         return View(pi);
    }

     [HttpPost , ActionName("DeletePizza")] //Method overloading i.e dis one , dis one , we can't have same deletepizza method.
       public  IActionResult RealDelete(int id)
    {
        _pizzaService.DeleteNewPizza(id);
         return RedirectToAction("GetAllPizza");
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

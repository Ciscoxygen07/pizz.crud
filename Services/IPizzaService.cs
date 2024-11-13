using pizza.crud.Models;

public interface IPizzaService
{
   void DeleteNewPizza(int id); 

   Pizza AddNewPizza(PizzaRequestModel requestModel);

   Pizza UpdatePizza(Pizza model);
    
   List<Pizza> GetAllPizza(); 

   Pizza GetPizza(int id); 
}
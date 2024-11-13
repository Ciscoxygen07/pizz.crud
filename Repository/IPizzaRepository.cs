using pizza.crud.Models;

public interface IPizzaRepository
{
   void DeletePizza( Pizza pizz); //interface method

   Pizza AddPizza(Pizza pizz);

   Pizza UpdatePizza(Pizza pizz);
    
   List<Pizza> GetAllPizza(); // we don't  need to get all by collecting parameters

   Pizza GetPizza(int id); //retrieve
}



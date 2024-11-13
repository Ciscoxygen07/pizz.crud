using pizza.crud.Models;

public class PizzaRepository : IPizzaRepository
{
    //mocked data
   static List <Pizza> _pizzaList = new List <Pizza>()//collection of objects more than one
   {
        new Pizza{Id = 1, Name ="onion pizza", Description = "sweet pizza" , IsAvailable = true},   //object initializer
        new Pizza{Id = 2, Name ="pepper pizza", Description = "hot pizza" , IsAvailable = true},
        new Pizza{Id = 3, Name ="chicken pizza", Description = "yummy pizza" , IsAvailable = false}
   };
  
   public Pizza AddPizza(Pizza pizz) //object holding 1
   {
     _pizzaList.Add(pizz);
     return pizz;
   }

   public void DeletePizza(Pizza pizz)
   {
    //  GetPizza(result.Id);
    _pizzaList.Remove(pizz);
   }

    public List <Pizza> GetAllPizza ()
   {
      return _pizzaList.ToList();
   }

   public Pizza GetPizza(int id)
   {
       Pizza? result =  _pizzaList.Find( x => x.Id == id);
       return result; 
   }

   public Pizza UpdatePizza(Pizza pizz) //object holding 1
   {
        Pizza? piz =  GetPizza(pizz.Id);
        piz.Name = pizz.Name;
        piz.Description = pizz.Description;
        piz.IsAvailable = pizz.IsAvailable;
        return piz;
   }


}
public class BreadRepository : IBreadRepository
{
    //mocked data
   static List <Bread> _bread = new List <Bread>()//collection of objects more than one
   {
        new Bread{Id = 1, Name ="coconut bread", Description = "sweet" , IsAvailable = true},   //object initializer
         new Bread{Id = 2, Name ="sardine bread", Description = "hot" , IsAvailable = true},
          new Bread{Id = 3, Name ="buttered bread", Description = "yummy" , IsAvailable = false}
   };
  
   public Bread AddBread(Bread bread) //object holding 1
   {
     _bread.Add(bread);
     return bread;
   }

   public void DeleteBread(Bread bread)
   {
    //  GetPizza(result.Id);
    _bread.Remove(bread);
   }

    public List <Bread> GetAllBread ()
   {
      return _bread.ToList();
   }

   public Bread GetBread(int id)
   {
       Bread? bread =  _bread.Find( s => s.Id == id);
       return bread; 
   }

   public Bread UpdateBread(Bread bread) //object holding 1
   {
        Bread? bred = GetBread(bread.Id);
        bred.Name = bread.Name;
        bred.Description = bread.Description;
        bred.IsAvailable = bread.IsAvailable;
        return bred;
   }


}
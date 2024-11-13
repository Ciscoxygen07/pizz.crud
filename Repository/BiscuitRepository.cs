public class BiscuitRepository : IBiscuitRepository
{
    //mocked data
   static List <Biscuit> _biscuit = new List <Biscuit>()//collection of objects more than one
   {
        new Biscuit{Id = 1, Name ="chocolate", Description = "sweet" , IsAvailable = true},   //object initializer
         new Biscuit{Id = 2, Name ="creamy", Description = "hot" , IsAvailable = true},
          new Biscuit{Id = 3, Name ="milky", Description = "yummy" , IsAvailable = false}
   };
  
   public Biscuit AddBiscuit(Biscuit biscuit) //object holding 1
   {
     _biscuit.Add(biscuit);
     return biscuit;
   }

   public void DeleteBiscuit(Biscuit biscuit)
   {
    _biscuit.Remove(biscuit);
   }

    public List <Biscuit> GetAllBiscuit ()
   {
      return _biscuit.ToList();
   }

   public Biscuit GetBiscuit(int id)
   {
       Biscuit? biscuit =  _biscuit.Find( s => s.Id == id);
       return biscuit; 
   }

   public Biscuit UpdateBiscuit(Biscuit biscuit) //object holding 1
   {
        Biscuit? bisc = GetBiscuit(biscuit.Id);
        bisc.Name = biscuit.Name;
        bisc.Description = biscuit.Description;
        bisc.IsAvailable = biscuit.IsAvailable;
        return bisc;
   }


}
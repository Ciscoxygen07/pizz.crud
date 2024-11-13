public class BiscuitService : IBiscuitService
{
    private readonly IBiscuitRepository _repository2;

     public  BiscuitService(IBiscuitRepository repository2)
    {
      _repository2 = repository2;
    }


   public void DeleteBiscuit(int id)
    {
     Biscuit biscuit =_repository2.GetBiscuit(id);
      _repository2.DeleteBiscuit(biscuit);
    }
   


    public List<Biscuit> GetAllBiscuit()
    {
        return _repository2.GetAllBiscuit();
    }
    
    public Biscuit GetBiscuit(int id)
   {
     Biscuit biscuit =_repository2.GetBiscuit(id);
     return biscuit;
   }

    public Biscuit AddNewBiscuit(BiscuitRequestModel requestModel)
    {
         Biscuit bsc = new  Biscuit();
        bsc.Name = requestModel.Name;
        bsc.Description = requestModel.Description;
        bsc.IsAvailable = requestModel.IsAvailable;
        bsc.Id = 4;
        _repository2.AddBiscuit(bsc); // a class that talks to the database
        return bsc;
    }

  public  Biscuit UpdateBiscuit(Biscuit biscuit)
    {
         Biscuit pi =  _repository2.UpdateBiscuit(biscuit);
        return pi;

    }

}


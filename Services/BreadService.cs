public class BreadService : IBreadService
{
    private readonly IBreadRepository _repository1;

     public  BreadService(IBreadRepository repository1)
    {
      _repository1 = repository1;
    }


   public void DeleteNewBread(int id)
    {
      Bread pi = _repository1.GetBread(id);
       _repository1.DeleteBread(pi);
    }
   


   public  Bread AddNewBread(BreadRequestModel requestModel)
    {
      
        Bread brea = new  Bread();
        brea.Name = requestModel.Name;
        brea.Description = requestModel.Description;
        brea.IsAvailable = requestModel.IsAvailable;
        brea.Id = 4;
        _repository1.AddBread(brea); // a class that talks to the database
        return brea;
    }

    public Bread UpdateBread(Bread bread)
    {
       Bread pi =  _repository1.UpdateBread(bread);
        return pi;

    }

    public List<Bread> GetAllBread()
    {
      return _repository1.GetAllBread(); 

    }
    
    public Bread GetBread(int id)
   {
     Bread bea = _repository1.GetBread(id);
     return bea;
   }
}
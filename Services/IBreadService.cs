public interface IBreadService
{
   void DeleteNewBread(int id); 

   Bread AddNewBread(BreadRequestModel requestModel);

   Bread UpdateBread(Bread bread);
    
   List<Bread> GetAllBread(); 

   Bread GetBread(int id); 
}
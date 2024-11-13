public interface IBreadRepository
{


   void DeleteBread(Bread bread); //interface method

   Bread  AddBread(Bread bread);

   Bread UpdateBread(Bread bread);
    
   List<Bread> GetAllBread(); // we don't  need to get all by collecting parameters

   Bread GetBread (int id); //retrieve
}



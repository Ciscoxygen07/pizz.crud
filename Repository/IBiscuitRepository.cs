public interface IBiscuitRepository
{


   void DeleteBiscuit( Biscuit biscuit); //interface method

   Biscuit AddBiscuit(Biscuit biscuit);

   Biscuit UpdateBiscuit(Biscuit biscuit);
    
   List<Biscuit> GetAllBiscuit(); // we don't  need to get all by collecting parameters

   Biscuit GetBiscuit(int id); //retrieve
}
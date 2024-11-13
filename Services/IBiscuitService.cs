public interface IBiscuitService
{
    void DeleteBiscuit(int id);

    Biscuit GetBiscuit(int id);

    Biscuit AddNewBiscuit(BiscuitRequestModel requestModel);

    List <Biscuit> GetAllBiscuit();

    Biscuit UpdateBiscuit(Biscuit biscuit);

}
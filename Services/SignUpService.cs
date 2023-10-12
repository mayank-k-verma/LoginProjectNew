using LoginProject.Database;
using LoginProject.Models;

namespace LoginProject.Services;

public interface ISignUpService{
    public bool AddingUserToDatabase(SignUpModel request);
}

public class SignUpService : ISignUpService{

    private readonly ApplicationDbContext _dbContext;
    public SignUpService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public bool AddingUserToDatabase(SignUpModel request){
        try
        {
            if(request != null){
                _dbContext.Add(request);
                _dbContext.SaveChanges();
            }
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using LoginProject.Database;
using LoginProject.Models;

namespace LoginProject.Services;

public interface ILoginService{
    public bool CheckingUserFromDatabase(LoginModel request);
}

public class LoginService : ILoginService{
    private readonly ApplicationDbContext _dbContext;
    public LoginService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool CheckingUserFromDatabase(LoginModel request){
        SignUpModel userFromDb = _dbContext.users.FirstOrDefault(a => a.Email == request.Email);
        if(userFromDb != null && userFromDb.Password == request.Password)  return true;
        return false;
    }
}
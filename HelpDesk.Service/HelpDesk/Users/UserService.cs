using HelpDesk.Domain.Users;
using HelpDesk.Infra.Data.Repositories;

namespace HelpDesk.Service.HelpDesk.Users;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        
    }

    public Task<User> InsertUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> DeleteUserAsync(User user)
    {
        throw new NotImplementedException();
    }
}
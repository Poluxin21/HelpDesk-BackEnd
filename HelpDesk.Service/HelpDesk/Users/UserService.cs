using HelpDesk.Domain.Users;
using HelpDesk.Infra.Data.Repositories;
using HelpDesk.Infra.Data.Repositories.Core;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Service.HelpDesk.Users;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAtlxRepositories<User> _userRepository;
    
    public UserService(IUnitOfWork unitOfWork, IAtlxRepositories<User> userRepository)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public async Task<User> InsertUserAsync(User user)
    {
        var userExists = await _unitOfWork.Query<User>()
            .Where(x => x.Email == user.Email)
            .FirstOrDefaultAsync();
        
        if (userExists is not null)
            throw new Exception("User already exists");
        
        await _userRepository.AddAsync(user);
        await _unitOfWork.SaveChangesAsync();
        return user;
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
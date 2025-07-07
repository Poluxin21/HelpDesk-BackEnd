using HelpDesk.Domain.Users;

namespace HelpDesk.Service.HelpDesk.Users;

public interface IUserService
{
    Task<User> InsertUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<User> DeleteUserAsync(User user);
}
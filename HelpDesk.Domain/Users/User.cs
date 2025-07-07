using HelpDesk.Domain.Utils.DomainTypes;

namespace HelpDesk.Domain.Users;

public class User : AggregateRootIdType<int>
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public bool Ativo { get; set; }
    
    private User() {}
    
    public User(string nome, string email, string password, string role, bool ativo)
    {
        Nome = nome;
        Email = email;
        Password = password;
        Role = role;
        Ativo = ativo;
    }
    
}
using HelpDesk.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpDesk.Infra.Data.Configures.Users;

public class UserConfigure : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome);
        builder.Property(x => x.Email);
        builder.Property(x => x.Password);
        builder.Property(x => x.Role);
        builder.Property(x => x.Ativo);
    }
}
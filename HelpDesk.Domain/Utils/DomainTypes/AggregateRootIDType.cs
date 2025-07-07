namespace HelpDesk.Domain.Utils.DomainTypes;

public class AggregateRootIdType<T>
{
    public T Id { get; set; }
    public DateTime? IncluidoEm { get; set; }
    public DateTime? AlteradoEm { get; set; }
}
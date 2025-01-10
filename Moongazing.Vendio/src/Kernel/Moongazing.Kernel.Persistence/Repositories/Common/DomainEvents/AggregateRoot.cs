using Moongazing.Kernel.Persistence.Repositories.Common.DomainEvents;
using Moongazing.Kernel.Persistence.Repositories.Common;

public abstract class AggregateRoot<TId> : Entity<TId>, IAggregateRoot<TId>
{
    private readonly List<IDomainEvent> domainEvents = new();

    public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        if (domainEvent == null) throw new ArgumentNullException(nameof(domainEvent));
        domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        domainEvents.Clear();
    }
}

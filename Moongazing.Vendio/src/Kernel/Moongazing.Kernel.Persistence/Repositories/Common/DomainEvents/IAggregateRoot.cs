namespace Moongazing.Kernel.Persistence.Repositories.Common.DomainEvents;

public interface IAggregateRoot<TId> : IEntity<TId>
{
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    void ClearDomainEvents();
    void AddDomainEvent(IDomainEvent domainEvent);
}


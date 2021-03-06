﻿using Weapsy.Cqrs.Domain;

namespace Weapsy.Cqrs.EventStore.CosmosDB.MongoDB.Documents.Factories
{
    public interface IEventDocumentFactory
    {
        EventDocument CreateEvent(IDomainEvent @event, long version);
    }
}

namespace Frank.Messaging;

public interface IMessagingManager
{
    Task CreateTopicAsync<T>(CancellationToken cancellationToken);
    
    Task CreateSubscriptionAsync<T>(CancellationToken cancellationToken);
}
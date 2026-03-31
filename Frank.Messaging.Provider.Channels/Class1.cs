namespace Frank.Messaging.Provider.Channels;

public class ChannelMessagingManager() : IMessagingManager
{
    /// <inheritdoc />
    public Task CreateTopicAsync<T>(CancellationToken cancellationToken) => Task.CompletedTask;

    /// <inheritdoc />
    public Task CreateSubscriptionAsync<T>(CancellationToken cancellationToken) => Task.CompletedTask;
}


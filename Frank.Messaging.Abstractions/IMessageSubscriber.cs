namespace Frank.Messaging;

public interface IMessageSubscriber<T>
{
    Task StartAsync(CancellationToken cancellationToken);
    
    Task StopAsync(CancellationToken cancellationToken);
}
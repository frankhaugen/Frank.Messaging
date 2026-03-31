namespace Frank.Messaging;

public interface IMessagePublisher<T>
{
    Task PublishAsync(Message<T> message, CancellationToken cancellationToken);
}
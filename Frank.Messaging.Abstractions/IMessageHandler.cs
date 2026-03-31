namespace Frank.Messaging;

public interface IMessageHandler<T>
{
    Task HandleAsync(Message<T> message, CancellationToken cancellationToken);
}
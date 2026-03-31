using System.Threading.Channels;

namespace Frank.Messaging;

public class Message<T>
{
    public Guid Id { get; } = Guid.NewGuid();
    
    public Guid CorrelationId { get; set; } = Guid.Empty;
    
    public T? Payload { get; init; }
}
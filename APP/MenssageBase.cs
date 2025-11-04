public abstract class MessageBase
{

    protected MessageBase(string message)
    {

        Message = message;
        SendAt = DateTime.Now;

    }

    public strting Message { get; }

    public DateTime SendAt { get; 
    }

}
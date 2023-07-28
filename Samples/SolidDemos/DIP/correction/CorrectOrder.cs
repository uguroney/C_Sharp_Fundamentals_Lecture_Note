namespace DIP.correction;

public class Order{

}


public interface ILogger
{
    void Log(string message);
}

public class OrderProcessor
{
    private readonly ILogger _logger;

    public OrderProcessor(ILogger logger)
    {
        _logger = logger;
    }

    public void Process(Order order)
    {
        try
        {
            // process the order
        }
        catch (Exception ex)
        {
            _logger.Log(ex.Message);
        }
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        // log the message to a database
    }
}

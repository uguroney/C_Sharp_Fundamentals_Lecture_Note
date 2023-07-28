namespace DIP.violation;

public class Order{

}

public class OrderProcessor
{
    private readonly DatabaseLogger _logger;

    public OrderProcessor()
    {
        _logger = new DatabaseLogger(); // Violation: depending on a concrete implementation
    }

    public void Process(Order order)
    {
        try
        {
            // process the order
        }
        catch (Exception ex)
        {
            _logger.Log(ex.Message); // Violation: depending on a concrete implementation
        }
    }
}

public class DatabaseLogger
{
    public void Log(string message)
    {
        // log the message to a database
    }
}


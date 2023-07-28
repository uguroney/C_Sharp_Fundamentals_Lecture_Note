namespace SRP.correction;

public class CustomerRepository
{
    private readonly string connectionString;

    public CustomerRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void Save(Customer customer)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)", connection))
                {
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

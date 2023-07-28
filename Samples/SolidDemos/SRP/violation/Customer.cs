namespace SRP.violation;

internal class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void Save()
    {
        try
        {
            using (var connection = new SqlConnection("Server=10.10.10.22;Database=DemoVs;User Id=sa;Password=rfvtgb45!!;"))
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)", connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Email", Email);
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

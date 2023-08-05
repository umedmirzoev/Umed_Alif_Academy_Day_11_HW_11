public record ClientInfo(string FirstName, string LastName, string Phone, string Email, string Password, string Age);
public record OrderInfo(string OrderNumber, string Description, string OrderPrice, DateTime OrderDate);
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to CRM!");
        Client clientService = new();

        while (true)
        {
            Console.WriteLine("Enter a command: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "create client")
            {
                CreateClient(clientService);
            }
            else if (input == "create order")
            {
                CreateOrder();
            }
            else if (input == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }
    }

    private static void CreateClient(Client clientService)
    {
        try
        {
            Console.WriteLine("Enter the First Name of the client:");
            string firstName = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Last Name of the client:");
            string lastName = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Email of the client:");
            string email = Console.ReadLine().Trim();
            
            Console.WriteLine("Enter the Age of the client:");
            string age = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Phone Number of the client:");
            string phoneNum = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Password of the client:");
            string password = Console.ReadLine().Trim();

            var clientinfo = new ClientInfo(firstName, lastName, phoneNum, email, password, age);

            clientService.CreateClient(clientinfo);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid client information: {ex.Message}");
        }
    }

    private static void CreateOrder()
    {
        try
        {
            Console.WriteLine("Enter the Order Number:");
            string orderNumber = Console.ReadLine().Trim();
            Console.WriteLine("Enter the Order Description:");
            string description = Console.ReadLine().Trim();
            Console.WriteLine("Enter the Order Price:");
            string orderPrice = Console.ReadLine().Trim();

            Order order = new (orderNumber, description, orderPrice, DateTime.Now);

            // Save the order to CRM
            Console.WriteLine("Order created successfully!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid order information: {ex.Message}");
        }
    }
}

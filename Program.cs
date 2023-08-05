public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to CRM!");

        while (true)
        {
            Console.WriteLine("Enter a command: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "create client")
            {
                CreateClient();
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

    private static void CreateClient()
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

            Console.WriteLine("Enter the Passport Number of the client:");
            string passportNum = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Phone Number of the client:");
            string phoneNum = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Password of the client:");
            string password = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Maritual Status of the client:");
            string status = Console.ReadLine().Trim();

            Client client = new (firstName, lastName, email, age, passportNum, password, phoneNum, status);

            // Save the client to CRM 
            Console.WriteLine("Client created successfully!");
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

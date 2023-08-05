public record ClientInfo(string FirstName, string LastName, string Phone, string Email, string Password, string Age);
public record OrderInfo(string OrderNumber, string Description, string OrderPrice, DateTime OrderDate);
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to CRM!");
        Client clientService = new();
        Order orderService = new();

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
                CreateOrder(orderService);
            }
            else if (input == "get client by name")
            {
                GetClientByName(clientService);
            }
            else if (input == "get order by description")
            {
                GetOrderByDescription(orderService);
            }
            else if (input == "get order by order number")
            {
                GetOrderByOrderNumber(orderService);
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

    private static void CreateOrder(Order orderService)
    {
        try
        {
            Console.WriteLine("Enter the Order Number:");
            string orderNumber = Console.ReadLine().Trim();
            Console.WriteLine("Enter the Order Description:");
            string description = Console.ReadLine().Trim();
            Console.WriteLine("Enter the Order Price:");
            string orderPrice = Console.ReadLine().Trim();

            OrderInfo orderInfo = new(orderNumber, description, orderPrice, DateTime.Now);

            // Save the order to CRM
            Console.WriteLine("Order created successfully!");
            orderService.CreateOrder(orderInfo);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid order information: {ex.Message}");
        }
    }

    private static void GetClientByName(Client clientService)
    {
        Console.WriteLine("Enter First Name of the client:");
        string firstName = Console.ReadLine().Trim();

        Console.WriteLine("Enter Last Name of the client:");
        string lastName = Console.ReadLine().Trim();

        var client = clientService.GetClientByName(firstName, lastName);

        if (client != null)
        {
            Console.WriteLine($"Client found: {client.FirstName} {client.LastName}");
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }

    private static void GetOrderByDescription(Order orderService)
    {
        Console.WriteLine("Enter Order Description:");
        string description = Console.ReadLine().Trim();

        var order = orderService.GetOrderByDescription(description);

        if (order != null)
        {
            Console.WriteLine($"Order found: {order.OrderNumber} - {order.Description}");
        }
        else
        {
            Console.WriteLine("Order not found.");
        }
    }

    private static void GetOrderByOrderNumber(Order orderService)
    {
        Console.WriteLine("Enter Order Number:");
        string orderNumber = Console.ReadLine().Trim();

        var order = orderService.GetOrderByOrderNumber(orderNumber);

        if (order != null)
        {
            Console.WriteLine($"Order found: {order.OrderNumber} - {order.Description}");
        }
        else
        {
            Console.WriteLine("Order not found.");
        }
    }
}

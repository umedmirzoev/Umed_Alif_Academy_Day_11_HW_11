public interface IOrderService
{
    void CreateOrder(OrderInfo order);
    OrderInfo GetOrderByDescription(string description);
    OrderInfo GetOrderByOrderNumber(string orderNumber);
    void UpdateOrderDescription(OrderInfo order, string newDescription);
    void DeleteOrder(OrderInfo order);
}

public abstract class Order : IOrderService
{
    private List<OrderInfo> orders = new List<OrderInfo>();

    public void CreateOrder(OrderInfo order)
    {
        if (!ValidateOrder(order))
        {
            throw new ArgumentException("Invalid order information.");
        }

        orders.Add(order);
        Console.WriteLine("Order created and added successfully!");
    }

    public virtual OrderInfo GetOrderByDescription(string description)
    {
        return orders.Find(order => order.Description == description);
    }

    public virtual OrderInfo GetOrderByOrderNumber(string orderNumber)
    {
        return orders.Find(order => order.OrderNumber == orderNumber);
    }


    public virtual void UpdateOrderDescription(OrderInfo order, string newDescription)
    {
        if (order != null)
        {
            order = order with { Description = newDescription };
            Console.WriteLine("Order description updated successfully!");
        }
        else
        {
            Console.WriteLine("Order not found.");
        }
    }

    public virtual void DeleteOrder(OrderInfo order)
    {
        if (order != null)
        {
            orders.Remove(order);
            Console.WriteLine("Order deleted successfully!");
        }
        else
        {
            Console.WriteLine("Order not found.");
        }
    }



    private bool ValidateOrder(OrderInfo order)
    {
        return !string.IsNullOrWhiteSpace(order.OrderNumber) &&
               !string.IsNullOrWhiteSpace(order.Description);
    }
}


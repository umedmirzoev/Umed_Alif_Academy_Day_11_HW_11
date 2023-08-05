public interface IOrderService
{
    void CreateOrder(OrderInfo order);
    OrderInfo GetOrderByDescription(string description);
    OrderInfo GetOrderByOrderNumber(string orderNumber);
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

    private bool ValidateOrder(OrderInfo order)
    {
        return !string.IsNullOrWhiteSpace(order.OrderNumber) &&
               !string.IsNullOrWhiteSpace(order.Description);
    }
}


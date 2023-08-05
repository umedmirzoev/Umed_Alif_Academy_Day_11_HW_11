class Order
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

    public OrderInfo GetOrderByDescription(string description)
    {
        return orders.Find(order => order.Description == description);
    }

    public OrderInfo GetOrderByOrderNumber(string orderNumber)
    {
        return orders.Find(order => order.OrderNumber == orderNumber);
    }

    private bool ValidateOrder(OrderInfo order)
    {
        return !string.IsNullOrWhiteSpace(order.OrderNumber) &&
               !string.IsNullOrWhiteSpace(order.Description);
    }
}
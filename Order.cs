class Order
{
    public string orderNumber { get; init; }
    public string description { get; init; }
    public string orderPrice { get; init; }
    public DateTime orderDate { get; init; }

    public Order(string orderNum, string des, string price, DateTime date)
    {
        orderNumber = orderNum;
        description = des;
        orderPrice = price;
        orderDate = date;
    }

    public string _orderNumber
    {
        get => _orderNumber;
        init => _orderNumber = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string _description
    {
        get => _description;
        init => _description = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string _orderPrice
    {
        get => _orderPrice;
        init => _orderPrice = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public string _orderDate
    {
        get => _orderDate;
        init => _orderDate = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
}
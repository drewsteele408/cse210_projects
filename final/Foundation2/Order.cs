public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int GetTotalOrderPrice()
    {
        int total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label for Order: Customer: {_customer.GetCustomerInfo()}Products:";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId}), Quantity: {product.Quantity}, Unit Price: {product.UnitPrice}";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label for Order: {_customer.GetCustomerInfo()}";
    }
}
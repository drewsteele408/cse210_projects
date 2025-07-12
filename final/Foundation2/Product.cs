public class Product
{
    private string _name;
    private string _productId;
    private int _unitPrice;
    private int _quantity;

    public string Name => _name;
    public string ProductId => _productId;
    public int UnitPrice => _unitPrice;
    public int Quantity => _quantity;

    public Product(string name, string productId, int unitPrice, int quantity)
    {
        _name = name;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public int GetTotalPrice()
    {
        return _unitPrice * _quantity;
    }
}
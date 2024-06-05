class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }
        totalPrice += _customer.IsInUSA() ? 5 : 35; // Shipping cost
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId} \n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.Name} \nAddress: {_customer.Address.ToString()}";
    }
}

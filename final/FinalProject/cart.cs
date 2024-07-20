using System.Runtime.CompilerServices;

class Cart
{
    private List<Product> _products;
    private double _totalCost;
    public Cart(double totalCost)
    {
        _products = new List<Product>();
        _totalCost = totalCost;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
        _totalCost += product.GetPrice();
    }
    public void DeleteProduct(Product product)
    {
        _products.Remove(product);
        _totalCost -= product.GetPrice();
    }
    public void DisplayCart()
    {
        int productNumber = 1;
        Console.WriteLine("Your Cart: ");
        Console.WriteLine();
        foreach (Product product in _products)
        {
            product.DisplayProductCart(productNumber);
            productNumber += 1;
        }
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${_totalCost:F2}");
        Console.WriteLine();
    }
    public List<Product> GetListProducts()
    {
        return _products;
    }
    public double GetTotalCost()
    {
        return _totalCost;
    }
}
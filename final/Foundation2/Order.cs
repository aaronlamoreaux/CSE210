public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void NewProducts(Product product)
    {
        _products.Add(product);
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public double OrderPrice()
    {
        double price = 0;
        if (GetCustomer().IsUsa())
        {
            foreach (Product product in GetProducts())
            {
                price += product.FullPrice();
            }
            price += 5;
        }
        else
        {
            foreach (Product product in GetProducts())
            {
                price += product.FullPrice();
            }
            price += 35;
        }
        return price;
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"Shipping to:\n{GetCustomer().GetName()}\n{GetCustomer().GetAddress().FullAddress()}");
    }

    public void PackingLabel()
    {
        Console.WriteLine("Order includes:");
        foreach (Product product in GetProducts())
        {
            Console.WriteLine($"{product.GetName()} {product.GetId()}");
        }
    }
}
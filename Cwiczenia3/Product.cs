namespace ConsoleApp1;

public class Product
{
    public string name { get; set; }
    public double temperature { get; set; }

    public Product(string name, double temperature)
    {
        this.name = name;
        this.temperature = temperature;
    }
}
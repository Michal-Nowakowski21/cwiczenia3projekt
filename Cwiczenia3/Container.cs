using System.Runtime.CompilerServices;

namespace ConsoleApp1;

public abstract class Container
{
    public double mass { get; set; }
    public double height{ get; set; }
    public double weight{ get; set; }
    public double depth{ get; set; }
    public double ładownosc { get; set; }
    public string serialNumber { get; set; }

    public Container(double mass, double height, double weight, double depth, double ładownosc)
    {
        this.mass = mass;
        this.height = height;
        this.weight = weight;
        this.depth = depth;
        this.ładownosc = ładownosc;
    }

    public void OproznienieLadunku()
    {
        weight = 0.0;
    }

    public void ZaladowanieLadunku(double masa)
    {   
        try
        {
            if (masa+mass<=ładownosc)
            {
                mass = mass+masa;
                Console.WriteLine("zaladowano ładunek do : "+ serialNumber);

            }
            else
            {
                throw new OverfillException();
            }
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public override string ToString()
    {
        return "Mass : " + mass + ", Height : " + height + ", Weight : " + weight + ", Depth : " + depth + ", ładownosc : " + ładownosc + ", serialNumber: " + serialNumber;
    }
}
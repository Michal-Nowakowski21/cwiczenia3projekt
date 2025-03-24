using System.Security.Cryptography;

namespace ConsoleApp1;

public class ContainerPlyn: Container, IHazardNotifier
{
    private bool _hazard;
    public static int liczbakontenerow=1;

    private bool hazard
    {
        get => _hazard;
        set
        {
            if (_hazard != value) 
            {
                _hazard = value; 

                if (_hazard)
                {
                    Notify(true);
                }
            }
        }
    }
    public ContainerPlyn(double mass, double height, double weight, double depth, double ładownosc) : base(mass, height, weight, depth, ładownosc)
    {
        hazard = false;
        serialNumber = "KON-L-" + liczbakontenerow++;
    }
    public void Notify(bool a)
    {
        
        if (a)
        {
            Console.WriteLine("HAZARD HAZARD HAZARD " + string.Join(", ", serialNumber));
        }
    }
    public void ZaladowanieLadunku(double masa, string bezpieczenstwo)
    {
        if (bezpieczenstwo.Equals("niebezpieczny"))
        {
            hazard = true;
        }
        try
        {
            if (hazard)
            {
                if (mass +masa<=(this.ładownosc/2.0))
                {
                    mass = mass + masa;
                    Console.WriteLine("zaladowano ładunek do : "+ serialNumber);
                } else
                {
                    Console.WriteLine("proba wykonania niebezpiecznej operacji");
                    hazard = false;
                }  
                
            }
            else
            {
                if (mass +masa<=this.ładownosc*0.9)
                {
                    mass = mass+ masa;
                    Console.WriteLine("zaladowano ładunek do : "+ serialNumber);

                }
                else
                {
                    Console.WriteLine("proba wykonania niebezpiecznej operacji");
                    hazard = false;
                }    
            }

            if (mass>ładownosc)
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
}
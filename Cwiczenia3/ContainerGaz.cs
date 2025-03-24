namespace ConsoleApp1;

public class ContainerGaz: Container, IHazardNotifier
{
    public static int liczbakontenerow=1;
    private bool _hazard;
    private double cisnienie;

    public bool hazard
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
    public ContainerGaz(double mass, double height, double weight, double depth, double ładownosc, double cisnienie) : base(mass, height, weight, depth, ładownosc)
    {
        this.cisnienie = cisnienie;
        serialNumber = "KON-G-" + liczbakontenerow++;

    }
    
    public new void OproznienieLadunku()
    {
        weight = weight*5/100;
    }
    
    public void Notify(bool a)
    {
        
        if (a)
        {
            Console.WriteLine("HAZARD HAZARD HAZARD " + string.Join(", ", serialNumber));
        }
    }
}
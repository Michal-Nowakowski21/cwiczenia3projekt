namespace ConsoleApp1;

public class OverfillException : Exception
{
    public OverfillException()
    {
        Console.WriteLine("kontener zostal przepelniony za duza masa");
    }
}
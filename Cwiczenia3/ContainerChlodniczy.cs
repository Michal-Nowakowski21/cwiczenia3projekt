namespace ConsoleApp1;

public class ContainerChlodniczy : Container
{
    public static int liczbakontenerow=1;
    private String rodzajProduktu="";
    private double temperature;
    

    public ContainerChlodniczy(double mass, double height, double weight, double depth, double ładownosc,string rodzajProduktu) : base(mass, height, weight, depth, ładownosc)
    {
        this.rodzajProduktu = rodzajProduktu;
        serialNumber = "KON-C-" + liczbakontenerow++;

    }
    public void ZaladowanieLadunku(double masa , Product product)
    {
        if (product.temperature>=temperature && rodzajProduktu.Equals(product.name))
        {
            try
            {
                if (masa+mass<=ładownosc)
                {
                    mass = mass+masa;
                    Console.WriteLine("zaladowano ładunek do : "+ serialNumber);

                    rodzajProduktu = product.name;
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
        else
        {
            Console.WriteLine("ten produkt nie pasuje do tego kontenera");
        }
      
    }
}
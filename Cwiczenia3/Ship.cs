namespace ConsoleApp1;

public class Ship
{
    private List<Container> containers = new List<Container>();
    private double maxSpeed;
    private int maxConteinerNumber=0;
    private double maxWeight=0;
    private double currentWeight=0;
    private double currentCount=0;
    

    public Ship(double maxSpeed, int maxConteinerNumber, double maxWeight)
    {
        this.maxSpeed = maxSpeed;
        this.maxConteinerNumber = maxConteinerNumber;
        this.maxWeight = maxWeight;
    }

    public void AddContainer(Container container)
    {
        if (currentWeight + container.weight <= maxWeight && containers.Count < maxConteinerNumber)
        {
            containers.Add(container);
            currentWeight=currentWeight+container.weight;
            currentCount++;
            Console.WriteLine("zaladowano kontener : "+ container.serialNumber);
        }
        else
        {
            Console.WriteLine("przekroczenie dopuszczalnej wagi badz liczby kontenerow");
        }
        
    }
    public void AddContainer(List<Container> containers2)
    {
        for (int i=0 ; i<containers2.Count ; i++)
        {
            if (currentWeight + containers2[i].weight <= maxWeight && containers.Count < maxConteinerNumber)
            {
                containers.Add(containers2[i]);
                currentWeight=currentWeight+containers2[i].weight;
                currentCount++;
                Console.WriteLine("zaladowano kontener : "+ containers2[i].serialNumber);
            }
            else
            {
                Console.WriteLine("przekroczenie dopuszczalnej wagi badz liczby kontenerow");
            }
        }
        
        
    }

    public void rozladujkontener(Container containerr)
    {
        for (int i=0 ; i<containers.Count ; i++)
        {
            if (containerr.serialNumber == containers[i].serialNumber) 
            {
                containers.Remove(containerr);
                currentWeight=currentWeight-containerr.weight;
                currentCount--;
                Console.WriteLine("rozladowano kontener : "+ containerr.serialNumber);
            }
        }
        
    }

    public void zastap(Container container, Container container2)
    {
        for (int i=0; i<containers.Count ; i++)
        {
            if (container.serialNumber == containers[i].serialNumber) 
            {
                containers.Remove(container);
                currentWeight=currentWeight-container.weight+container2.weight;
                containers.Add(container2);
                Console.WriteLine("zastapiono kontener : "+ container.serialNumber + " nowym kontenerem : "+ container2.serialNumber);
            }
        }
        
    }

    public void przenies(Ship ship2, Container container)
    {
        for(int i=0; i<containers.Count ; i++)
        {
            if (containers[i].serialNumber == container.serialNumber)
            {
                containers.Remove(container);
                ship2.containers.Add(container);
                Console.WriteLine("przeniesiono kontener : "+ container.serialNumber);
            }
        }
    }

    public override string ToString()
    {
        String listakontenerów = "";
        for (int i = 0; i < containers.Count(); i++)
        {
            listakontenerów=listakontenerów+containers[i].serialNumber+", ";
        }
        return "maxSpeed : " + maxSpeed + ", maxConteinerNumber : " + maxConteinerNumber + ", maxWeight : " + maxWeight + ", currentWeight : " + currentWeight + ", currentCount : " + currentCount + ", listaKontenerów : " + listakontenerów;
    }
}
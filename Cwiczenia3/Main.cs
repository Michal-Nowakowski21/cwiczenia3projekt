
using ConsoleApp1;
//Stworzenie kontenera danego typu
ContainerPlyn containerPlyn = new ContainerPlyn(2,2,2,2,10);
ContainerPlyn containerPlyn2 = new ContainerPlyn(2,4,3,2,20);
ContainerGaz containerGaz = new ContainerGaz(4,3,5,6,30,6);
ContainerGaz containerGaz2 = new ContainerGaz(3,3,5,6,7,3);
ContainerChlodniczy containerChlodniczy = new ContainerChlodniczy(4,3,2,4,80,"banan");
ContainerChlodniczy containerChlodniczy2 = new ContainerChlodniczy(2, 3, 4, 2, 70,"banan");
Console.WriteLine(containerPlyn);
Console.WriteLine(containerPlyn2);
Console.WriteLine(containerGaz);
Console.WriteLine(containerGaz2);
Console.WriteLine(containerChlodniczy);
Console.WriteLine(containerChlodniczy2);
containerGaz2.hazard = true;
//zaladowanie ladunku do danego kontenera
containerPlyn2.ZaladowanieLadunku(1, "bezpieczny");
containerPlyn.ZaladowanieLadunku(1, "niebezpieczny");
containerPlyn.ZaladowanieLadunku(10, "niebezpieczny");
containerGaz.ZaladowanieLadunku(2);
//containerGaz2.ZaladowanieLadunku(8); // odpowiednio wyrzuca blad
Product banan = new Product("banan", 10);
Product czekolada = new Product("czekolada", 15);

containerChlodniczy.ZaladowanieLadunku(20,banan);
containerChlodniczy.ZaladowanieLadunku(20,czekolada);

containerChlodniczy2.ZaladowanieLadunku(20,banan);
containerChlodniczy2.ZaladowanieLadunku(20,banan);
//zaladowanie kontenera na statek
Ship ship = new Ship(10,5,80);
ship.AddContainer(containerPlyn);
ship.AddContainer(containerPlyn2);
ship.AddContainer(containerGaz);
ship.AddContainer(containerGaz2);
ship.AddContainer(containerChlodniczy);
ship.AddContainer(containerChlodniczy2);
Ship ship2 = new Ship(10,4,70);
ContainerChlodniczy containerChlodniczy3 = new ContainerChlodniczy(4,3,2,4,80,"banan");
List<Container> containers = new List<Container>();
containers.Add(containerChlodniczy3);
containers.Add(containerChlodniczy2);
ship2.AddContainer(containers);
ship2.rozladujkontener(containerChlodniczy2);
ContainerGaz containerGaz3 = new ContainerGaz(4,3,5,6,30,6);
ship.zastap(containerChlodniczy,containerGaz3);
ship.przenies(ship2, containerGaz3);
Console.WriteLine(ship);
Console.WriteLine(ship2);
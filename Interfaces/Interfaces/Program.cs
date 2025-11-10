using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("                             HAWK                                  ");
        Console.WriteLine("-------------------------------------------------------------------");

        Console.WriteLine("\nANIMAL : HAWK");
        Hawk hawk = new Hawk();
        hawk.Hunt();

        Console.WriteLine("\n-------------------------------------------------------------------");
        Console.WriteLine("                           RABBIT                                  ");
        Console.WriteLine("-------------------------------------------------------------------");

        Console.WriteLine("\nANIMAL : RABBIT");

        Rabbit rabbit = new Rabbit();
        rabbit.Flee();

        Console.WriteLine("\n-------------------------------------------------------------------");
        Console.WriteLine("                             FISH                                  ");
        Console.WriteLine("-------------------------------------------------------------------");

        Console.WriteLine("\nANIMAL : FISH");

        Fish fish = new Fish();
        fish.Hunt();
        fish.Flee();
        Console.WriteLine("\n-------------------------------------------------------------------");


    }
}
public interface IPredator
{
    void Hunt()
    {
    }
}
public interface IPrey
{ 
    void Flee()
    { 
    }

}
public class Hawk:IPredator
{
    public void Hunt()
    {
        Console.WriteLine("-The Hawk hunts for Rabbit as food.");
    }
    
}
public class Rabbit:IPrey
{
    public void Flee()
    {
        Console.WriteLine("-The Rabbit flee's away when the Hawk is around.");
    }
}
public class Fish:IPredator,IPrey
{
    public void Hunt()
    {
        Console.WriteLine("-The Fish hunts for smaller fish as food.");
    }
    public void Flee()
    {
        Console.WriteLine("-The Fish flee's away from the Shark for survival.");
    }
}
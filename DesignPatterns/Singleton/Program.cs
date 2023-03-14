using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        Singleton.Singleton firstInstance = Singleton.Singleton.getInstance;

        Console.WriteLine($"Counter: {firstInstance.addCounter().ToString()}"); // Counter: 1
        Console.WriteLine($"Counter: {firstInstance.addCounter().ToString()}"); // Counter: 2
        Console.WriteLine($"Counter: {firstInstance.addCounter().ToString()}"); // Counter: 3

        Singleton.Singleton secondInstance = Singleton.Singleton.getInstance;

        //since we are reusing the same instance from Singleton class then the value of Counter now is going to be 4
        Console.WriteLine($"Counter: {secondInstance.addCounter().ToString()}"); // Counter: 4

        //now wheter we use the first or the second instance the value of Counter will be 5
        Console.WriteLine($"Counter: {firstInstance.addCounter().ToString()}"); // Counter: 5

    }
}
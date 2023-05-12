// Interfaccia astratta per la creazione di oggetti
public interface IAnimalFactory
{
    ICarnivore CreateCarnivore();
    IHerbivore CreateHerbivore();
}

// Interfaccia per gli oggetti carnivori
public interface ICarnivore
{
    void Eat(IHerbivore herbivore);
}

// Interfaccia per gli oggetti erbivori
public interface IHerbivore
{
    void Eat();
}

// Implementazione concreta della fabbrica di animali di tipo africano
public class AfricanAnimalFactory : IAnimalFactory
{
    public ICarnivore CreateCarnivore()
    {
        return new Lion();
    }

    public IHerbivore CreateHerbivore()
    {
        return new Wildebeest();
    }
}

// Implementazione concreta della fabbrica di animali di tipo nordamericano
public class NorthAmericanAnimalFactory : IAnimalFactory
{
    public ICarnivore CreateCarnivore()
    {
        return new Wolf();
    }

    public IHerbivore CreateHerbivore()
    {
        return new Bison();
    }
}

// Implementazione concreta di un oggetto carnivoro di tipo leone
public class Lion : ICarnivore
{
    public void Eat(IHerbivore herbivore)
    {
        // Implementazione del comportamento di un leone che mangia un erbivoro
        Console.WriteLine("Il leone mangia uno gnu");
    }
}

// Implementazione concreta di un oggetto erbivoro di tipo gnu
public class Wildebeest : IHerbivore
{
    public void Eat()
    {
        // Implementazione del comportamento di un gnu che mangia erba
        Console.WriteLine("Lo gnu mangia l'erba");
    }
}

// Implementazione concreta di un oggetto carnivoro di tipo lupo
public class Wolf : ICarnivore
{
    public void Eat(IHerbivore herbivore)
    {
        // Implementazione del comportamento di un lupo che mangia un erbivoro
        Console.WriteLine("Il lupo mangia il bisonte");
    }
}

// Implementazione concreta di un oggetto erbivoro di tipo bisonte
public class Bison : IHerbivore
{
    public void Eat()
    {
        // Implementazione del comportamento di un bisonte che mangia erba
        Console.WriteLine("Il bisonte mangia l'erba");
    }
}

// Esempio di utilizzo delle fabbriche di animali
public class AnimalWorld
{
    private IAnimalFactory factory;
    private ICarnivore carnivore;
    private IHerbivore herbivore;

    public AnimalWorld(IAnimalFactory factory)
    {
        this.factory = factory;
        carnivore = factory.CreateCarnivore();
        herbivore = factory.CreateHerbivore();
    }

    public void RunFoodChain()
    {
        carnivore.Eat(herbivore);
    }
}

public static class Program {
    public static void Main(string [] args) {
        AfricanAnimalFactory africanFactory = new AfricanAnimalFactory();
        NorthAmericanAnimalFactory americanFactory = new NorthAmericanAnimalFactory();

        AnimalWorld african = new AnimalWorld(africanFactory);
        AnimalWorld american = new AnimalWorld(americanFactory);

        african.RunFoodChain();
        american.RunFoodChain();
    }
}
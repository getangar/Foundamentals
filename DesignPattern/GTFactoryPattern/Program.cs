public interface IAnimal {
    void MakeSound();
}

public class Dog : IAnimal {
    public void MakeSound() {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimal {
    public void MakeSound() {
        Console.WriteLine("Meow!");
    }
}

public abstract class AnimalFactory {
    public abstract IAnimal CreateAnimal();
}

public class DogFactory : AnimalFactory {
    public override IAnimal CreateAnimal()
    {
        return new Dog();
    }
}

public class CatFactory : AnimalFactory {
    public override IAnimal CreateAnimal()
    {
        return new Cat();
    }
}

public static class Program {
    static void Main(string [] args) {
        AnimalFactory factory = new DogFactory();
        IAnimal animal = factory.CreateAnimal();
        animal.MakeSound();
    }
}


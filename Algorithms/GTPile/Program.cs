public class GTPile<T> {
    private List<T> elements;

    public GTPile() {
        elements = new List<T>();
    }

    public void Push(T element) {
        elements.Add(element);
    }

    public T Pop() {
        if (elements.Count == 0) {
            throw new InvalidOperationException("The pile is empty!");
        }

        T element = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);

        return element;
    }

    public T Peek() {
        if (elements.Count == 0) {
            throw new InvalidOperationException("The pile is empty!");
        }

        return elements[elements.Count - 1];
    }

    public bool IsEmpty() {
        return elements.Count == 0;
    }

    public int Count() {
        return elements.Count;
    }
}

public class Program {
    // See https://aka.ms/new-console-template for more information

    public static void Main(string[] args) {
        var pile = new GTPile<int>();

        Console.WriteLine($"Elements in pile: {pile.Count()}");
        
        pile.Push(3);
        pile.Push(-2);
        pile.Push(11);

        Console.WriteLine($"Elements in pile: {pile.Count()}");

        var elem = pile.Pop();
        Console.WriteLine($"Element = {elem}");
        elem = pile.Pop();
        Console.WriteLine($"Element = {elem}");
        elem = pile.Pop();
        Console.WriteLine($"Element = {elem}");


        Console.WriteLine($"Elements in pile: {pile.Count()}");  
    }
}

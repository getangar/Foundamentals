public class GTQueue<T> {
    private List<T> elements;

    public GTQueue() {
        elements = new List<T>();
    }

    public void Enqueue(T element) {
        elements.Add(element);
    }

    public T Dequeue() {
        if (elements.Count == 0) {
            throw new InvalidOperationException("Empty queue");
        }

        T element = elements[0];
        elements.RemoveAt(0);

        return element;
    }

    public bool IsEmpty() {
        return elements.Count == 0;
    }

    public int Count() {
        return elements.Count;
    }
}

public class Program {
    public static void Main(string[] args) {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
    }
}
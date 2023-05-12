namespace DesignPetterns {
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object lockObject = new object();

        private Singleton()
        {
            // Costruttore privato per evitare la creazione di istanze esterne.
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        // Metodi pubblici della classe Singleton
        public void SomeMethod()
        {
            Console.WriteLine("SomeMethod...");
        }
    }   

    public class Program {
        public static void Main(string[] args) {
            Singleton singleton = Singleton.Instance;
            singleton.SomeMethod();
        }
    }
}

namespace TheOneRing {
    internal class Program {
        static void Main(string[] args) {
            Ring theone = new Ring();
            Hobbit bilbo = new Hobbit("Name", theone);
            bilbo.RingEvent += bilbo.Event;
            ConsoleKey key;
            do {
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar) || bilbo.Seele == 0) {
                    Console.Clear();
                    Console.WriteLine("Hi, Bilbo\tUnsichtbar: {0}\tSeele: {1}\nUm den einen Ring auf- oder abzusetzten Space drücken", bilbo.Unsichtbar, bilbo.Seele);
                    if (bilbo.Ringfinger == theone) {
                        bilbo.Seele -= 1;
                    }
                    Thread.Sleep(1000);
                }
                bilbo.RingBenutzen();
            } while (bilbo.Seele > 0);
        }
    }
}

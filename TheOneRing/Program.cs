
namespace TheOneRing {
    internal class Program {
        static void Main(string[] args) {
            Ring theone = new Ring();
            Hobbit bilbo = new Hobbit("Name", theone);
            bilbo.RingEventFinger += bilbo.AmfingerEvent;
            bilbo.RingEventTasche += bilbo.NichtamfingerEvent;
            ConsoleKey key;
            //while (bilbo.Seele > 0) {
            do {
                //int antwort;
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.NumPad0)) {
                    Console.Clear();
                    Console.WriteLine("Hi, Bilbo\tUnsichtbar: {0}\tSeele: {1}\nwas möchtest Du tun?\nUm den einen Ring aufzusetzen oder Ring abzusetzten Numpad 0 drücken", bilbo.Unsichtbar, bilbo.Seele);
                    //key = Console.ReadKey(true).Key;
                    //switch (key) {
                    //    case ConsoleKey.NumPad0:
                    //    bilbo.RingBenutzen();
                    //    break;
                    //    default:
                    //    break;
                    //}
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
//while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)) {
//    // do something
//}
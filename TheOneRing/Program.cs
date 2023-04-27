namespace TheOneRing {
    internal class Program {
        static void Main(string[] args) {
            Ring theone = new Ring();
            Hobbit bilbo = new Hobbit("Name", theone);
            bilbo.RingEventFinger += bilbo.AmfingerEvent;
            bilbo.RingEventTasche += bilbo.NichtamfingerEvent;
            while (bilbo.Seele > 0) {
                int antwort;
                Console.Clear();
                Console.WriteLine("Hi, Bilbo\tUnsichtbar: {0}\tSeele: {1}\nwas möchtest Du tun?\n1)Ring aufsetzen\n2)Ring absetzten", bilbo.Unsichtbar, bilbo.Seele);
                antwort = Convert.ToInt16(Console.ReadLine());
                switch (antwort) {
                    case 1:
                    bilbo.RingBenutzen();
                    break;
                    case 2:
                    bilbo.RingAblegen();
                    break;
                    default:
                    break;
                }
            }

        }
    }
}
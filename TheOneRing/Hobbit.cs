namespace TheOneRing {
    internal class Hobbit {
        public event EventHandler<RingEventArgs> RingEvent;
        public string Name { get; set; }
        public Ring Ringfinger { get; set; }
        public Ring Tasche { get; set; }
        public bool Unsichtbar { get; set; }
        public int Seele { get; set; }
        public Hobbit(string name, Ring theone) {
            Name = name;
            Tasche = theone;
            Unsichtbar = false;
            Seele = 100;
        }
        public void RingBenutzen() {
            if (RingEvent != null) {
                RingEventArgs rea = new RingEventArgs();
                if (this.Ringfinger == null) {
                    rea.Unsichtbar = true;
                    rea.Finger = this.Tasche;
                    rea.Tasche = null;
                    RingEvent(this, rea);
                }
                else {
                    rea.Unsichtbar = false;
                    rea.Tasche = this.Ringfinger;
                    rea.Finger = null;
                    RingEvent(this, rea);
                }
            }
        }
        public void Event(object o, RingEventArgs e) {
            ((Hobbit)o).Unsichtbar = e.Unsichtbar;
            ((Hobbit)o).Ringfinger = e.Finger;
            ((Hobbit)o).Tasche = e.Tasche;
        }
    }
}

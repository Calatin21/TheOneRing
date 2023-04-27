namespace TheOneRing {
    internal class Hobbit {
        public event EventHandler<RingEventArgs> RingEventFinger;
        public event EventHandler<RingEventArgs> RingEventTasche;
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
            if (RingEventFinger != null) {
                this.RingamFinger(this, new RingEventArgs());
            }
        }
        public void RingAblegen() {
            if (RingEventTasche != null) {
                this.RingvomFinger(this, new RingEventArgs());
            }
        }
        public void RingamFinger(object o, RingEventArgs e) {
            RingEventFinger(o, e);
        }
        public void RingvomFinger(object o, RingEventArgs e) {
            RingEventTasche(o, e);
        }
        public void AmfingerEvent(object o, RingEventArgs e) {
            ((Hobbit)o).Unsichtbar = true;
            ((Hobbit)o).Seele -= 1;
            ((Hobbit)o).Ringfinger = ((Hobbit)o).Tasche;
            ((Hobbit)o).Tasche = null;
        }
        public void NichtamfingerEvent(object o, RingEventArgs e) {
            ((Hobbit)o).Tasche = ((Hobbit)o).Ringfinger;
            ((Hobbit)o).Ringfinger = null;
            ((Hobbit)o).Unsichtbar = false;
        }
    }
}

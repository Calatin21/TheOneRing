namespace TheOneRing {
    internal class Hobbit {
        public event EventHandler<RingEventArgs> RingEvent;
        public string Name { get; set; }
        public bool Unsichtbar { get; set; }
        public int Seele { get; set; }
        public Hobbit(string name) {
            Name = name;
            Unsichtbar = false;
            Seele = 100;
        }
        public void RingBenutzen() {
            if (RingEvent != null) {
                RingEventArgs rea = new RingEventArgs();
                if (!this.Unsichtbar) {
                    rea.Unsichtbar = true;
                    RingEvent(this, rea);
                }
                else {
                    rea.Unsichtbar = false;
                    RingEvent(this, rea);
                }
            }
        }
        public void Event(object o, RingEventArgs e) {
            ((Hobbit)o).Unsichtbar = e.Unsichtbar;
        }
    }
}

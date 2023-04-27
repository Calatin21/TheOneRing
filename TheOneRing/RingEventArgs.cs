namespace TheOneRing {
    internal class RingEventArgs : EventArgs {
        public bool Unsichtbar { get; set; }
        public Ring Finger { get; set; }
        public Ring Tasche { get; set; }
    }
}

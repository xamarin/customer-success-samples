namespace FormsTrays
{
    using System;

    public class TrayEventArgs : EventArgs
    {
        private readonly Tray tray;

        public TrayEventArgs(Tray tray)
        {
            this.tray = tray;
        }

        public Tray Tray
        {
            get { return this.tray; }
        }
    }
}
namespace RemoteDevices.Devices
{
    public abstract class Device
    {
        public bool On { get; set; }
        public int Volume { get; set; }
        public double Channel { get; set; }

        protected Device(int volume, double channel)
        {
            On = false;
            Volume = volume;
            Channel = channel;
        }

        public virtual bool IsOn() 
        {
            return On;
        }
        public virtual void TurnOn()
        {
            On = true;
        }
        public virtual void TurnOff()
        {
            On = false;
        }
        public virtual int GetCurrentVolume()
        {
            return Volume;
        }
        public virtual void TurnVolumeUp(int volumeUp)
        {
            Volume += volumeUp;
        }
        public virtual void TurnVolumeDown(int volumeDown)
        {
            if (volumeDown > GetCurrentVolume())
                Volume = 0;
            else
                Volume -= volumeDown;
        }
        public abstract void ChannelUp();
        public abstract void ChannelDown();
    }
}

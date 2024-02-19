namespace RemoteDevices.Devices
{
    public class Radio : Device
    {
        public Radio() : base(15, 92.7)
        {
        }

        public override void ChannelDown()
        {
            Channel -= 0.7;
        }

        public override void ChannelUp()
        {
            Channel += 0.7;
        }
    }
}

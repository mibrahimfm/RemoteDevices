namespace RemoteDevices.Devices
{
    public class TV : Device
    {
        public TV() : base(10, 1)
        {
        }

        public override void ChannelDown()
        {
            Channel--;
        }

        public override void ChannelUp()
        {
            Channel++;
        }
    }
}

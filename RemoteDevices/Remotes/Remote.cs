using RemoteDevices.Devices;

namespace RemoteDevices.Remotes
{
    public class Remote
    {
        public Device Device { get; set; }

        public Remote(Device device)
        {
            Device = device;
        }

        public void TogglePower()
        {
            if (Device.IsOn())
                Device.TurnOff();
            else
                Device.TurnOn();
        }

        public void VolumeDown()
        {
            Device.TurnVolumeDown(10);
        }

        public void VolumeUp()
        {
            Device.TurnVolumeUp(10);
        }

        public void ChannelDown()
        {
            Device.ChannelDown();
        }

        public void ChannelUp()
        {
            Device.ChannelUp();
        }

        public void DisplayDevice()
        {
            Console.WriteLine($"Is on: {Device.IsOn()}");
            Console.WriteLine($"Current channel: {Device.Channel:F1}");
            Console.WriteLine($"Current volume: {Device.GetCurrentVolume()}");

        }
    }
}

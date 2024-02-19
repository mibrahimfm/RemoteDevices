using RemoteDevices.Devices;

namespace RemoteDevices.Remotes
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(Device device) : base(device)
        {
        }

        public void Mute()
        {
            Device.TurnVolumeDown(Device.GetCurrentVolume());
        }
    }
}

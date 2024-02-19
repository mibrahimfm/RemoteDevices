
using RemoteDevices.Devices;
using RemoteDevices.Remotes;

Device device = new TV();
Remote remote = new(device);

remote.TogglePower();
remote.ChannelUp();
remote.VolumeUp();
remote.DisplayDevice();

device = new Radio();
AdvancedRemote remote2 = new(device);
remote2.ChannelDown();
remote2.ChannelDown();
remote2.Mute();
remote2.DisplayDevice();
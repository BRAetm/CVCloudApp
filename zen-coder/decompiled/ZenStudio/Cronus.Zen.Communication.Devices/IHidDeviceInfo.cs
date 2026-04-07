namespace Cronus.Zen.Communication.Devices;

public interface IHidDeviceInfo
{
	ushort VendorID { get; }

	ushort ProductID { get; }

	ushort Usage { get; }

	ushort UsagePage { get; }
}

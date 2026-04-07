using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Threading;
using MahApps.Metro.Controls;
using WlanApi;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class MainWindow : MetroWindow, INotifyPropertyChanged, IComponentConnector
{
	private enum WizardStep
	{
		WaitingForDevice,
		SelectFirmware,
		EnterWifiCredentials,
		ConfigureConsole,
		SavingAndRestarting,
		WaitingForReconnection,
		MonitoringUpdate,
		Completed
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public string removedSerial;

		public MainWindow _003C_003E4__this;

		private static _003C_003Ec__DisplayClass29_0 JVW;

		public _003C_003Ec__DisplayClass29_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal void _003CDeviceCheckCallback_003Eb__1()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					_003C_003E4__this.OnPropertyChanged(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xC120EAC ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340));
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5C4E91EC ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65), removedSerial);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_353cc89a97134b3dab46f13c2f0d5345 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		static _003C_003Ec__DisplayClass29_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool KVg()
		{
			return JVW == null;
		}

		internal static _003C_003Ec__DisplayClass29_0 XV1()
		{
			return JVW;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_1
	{
		public string foundSerial;

		public MainWindow _003C_003E4__this;

		internal static _003C_003Ec__DisplayClass29_1 cVA;

		public _003C_003Ec__DisplayClass29_1()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d2338023c8544d0e8649719c51cf0dae == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal void _003CDeviceCheckCallback_003Eb__7()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					_003C_003E4__this.OnPropertyChanged(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4FEABCC7 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e));
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_225ba267fe26452a859963d16a9c6edd == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x7DB4E79D ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175), foundSerial);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d2338023c8544d0e8649719c51cf0dae != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		static _003C_003Ec__DisplayClass29_1()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool QVE()
		{
			return cVA == null;
		}

		internal static _003C_003Ec__DisplayClass29_1 KVd()
		{
			return cVA;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_2
	{
		public Exception ex;

		internal static _003C_003Ec__DisplayClass29_2 QVz;

		public _003C_003Ec__DisplayClass29_2()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal void _003CDeviceCheckCallback_003Eb__10()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFBE84 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138), o_0304_030B.W_03014(ex, o_0304_030B.C_0304_030C));
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4c7aa379fe63429c9a5648f0c3a496e7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		static _003C_003Ec__DisplayClass29_2()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool XpD()
		{
			return QVz == null;
		}

		internal static _003C_003Ec__DisplayClass29_2 Jpv()
		{
			return QVz;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public int written;

		public int total;

		public MainWindow _003C_003E4__this;

		internal static _003C_003Ec__DisplayClass30_0 YpF;

		public _003C_003Ec__DisplayClass30_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_577024c9b9304ef0a1869ca375c2d204 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal string _003CDevice_DataReceived_003Eb__3()
		{
			int num = 1;
			int num2 = num;
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					w_0304_0313.W_03014(_003C_003E4__this.StatusText, result = C_0304l.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x2FCF66B3 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a), written, total, C_0304l.s_0304m), w_0304_0313.b_0304_0314);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ce3991d1f51e4f6e8568482226882025 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return result;
				}
			}
		}

		static _003C_003Ec__DisplayClass30_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool qp6()
		{
			return YpF == null;
		}

		internal static _003C_003Ec__DisplayClass30_0 PpS()
		{
			return YpF;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public MainWindow _003C_003E4__this;

		public int totalBytes;

		public int bytesWritten;

		private static _003C_003Ec__DisplayClass47_0 epX;

		public _003C_003Ec__DisplayClass47_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_95da1571cded41d097dc9e01312a6680 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal void _003CUpdateProgressBarFromBytes_003Eb__0()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				default:
					d_0304j.W_03014(_003C_003E4__this.UpdateProgressBar, Y_0301r.W_03014(bytesWritten, totalBytes, Y_0301r.F_0301s), d_0304j.C_0304k);
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					X_0304h.W_03014(_003C_003E4__this.UpdateProgressBar, false, X_0304h.j_0304i);
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					P_0304n.W_03014(_003C_003E4__this.UpdateProgressBar, totalBytes, P_0304n.y_0304o);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		static _003C_003Ec__DisplayClass47_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool DpH()
		{
			return epX == null;
		}

		internal static _003C_003Ec__DisplayClass47_0 lpt()
		{
			return epX;
		}
	}

	private ZenLinkHidDevice _device;

	private readonly DispatcherTimer _timer;

	private string _firmwareVersion;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private WizardStep _currentStep;

	private string _selectedUpdateUrl;

	private bool _deviceDisconnectedForUpdate;

	private DateTime _disconnectionTime;

	private bool _isRegularFirmware;

	private bool _appModeMessageShown;

	private bool _appModeReconnectionMessageShown;

	private bool _updateCompleted;

	private string _consoleName;

	private string _consoleProfileName;

	private string _registKey;

	private byte[] _rpKey;

	private bool _flashOnlyMode;

	internal MainWindow Root;

	internal Button BackButton;

	internal Border WaitingPanel;

	internal TextBlock WaitingText;

	internal Border FirmwareSelectionPanel;

	internal Border WifiCredentialsPanel;

	internal TextBox WifiSsidBox;

	internal PasswordBox WifiPasswordBox;

	internal CheckBox Use40MhzCheckBox;

	internal Border ConsoleConfigPanel;

	internal TextBox ConsoleProfileNameBox;

	internal TextBlock ConsoleNameText;

	internal Button LoadConsoleDataButton;

	internal CheckBox FlashOnlyModeCheckBox;

	internal Border ProgressPanel;

	internal TextBlock StatusText;

	internal ProgressBar UpdateProgressBar;

	internal Border CompletedPanel;

	internal TextBox OutputConsoleBox;

	internal TextBlock CurrentFwVersion;

	private bool _contentLoaded;

	internal static MainWindow vVo;

	public ZenLinkHidDevice Device
	{
		get
		{
			return _device;
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_device = value;
					num2 = 2;
					break;
				case 2:
					OnPropertyChanged(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4FEABCB7 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e));
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				default:
					OnPropertyChanged(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x22A31558 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c1be1b45dbbd4f769f36fd21d36e7f59));
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public string DeviceConnected
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x619C28E1 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_21e98ef4eaf84e4d8faaaec3a382e068);
				case 2:
					return Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x71DFC805 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187);
				case 1:
				{
					ZenLinkHidDevice device = Device;
					if (device == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0042670e6f54a62abe3949793fdea70 != 0)
						{
							num2 = 0;
						}
						break;
					}
					if (device.IsConnected)
					{
						num2 = 2;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50a77b94ed45479dbe8d46063da46bd1 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				}
				}
			}
		}
	}

	public ZenLinkResponseData.ZenLinkStatus DeviceStatus
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					ZenLinkHidDevice device2 = Device;
					if (device2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e == 0)
						{
							num2 = 0;
						}
						break;
					}
					return device2.Status;
				}
				default:
				{
					ZenLinkHidDevice device = Device;
					if (device == null)
					{
						num2 = 3;
						break;
					}
					if (device.IsConnected)
					{
						num2 = 4;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fae40d88e3574df5aa9c4dc3b17260d4 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 2;
				}
				case 2:
				case 3:
					return ZenLinkResponseData.ZenLinkStatus.NotConnected;
				case 4:
					return ZenLinkResponseData.ZenLinkStatus.Unknown;
				}
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					if ((object)propertyChangedEventHandler2 == propertyChangedEventHandler)
					{
						num2 = 5;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				case 4:
					propertyChangedEventHandler2 = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0b947f42d424e71aa93063b3ccbbc7b == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					propertyChangedEventHandler2 = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_327d25deb5ac44ada715c7ead1c1918d == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				case 3:
					value2 = (PropertyChangedEventHandler)y_03023.W_03014(propertyChangedEventHandler, value, y_03023.T_03024);
					num2 = 4;
					continue;
				case 1:
					break;
				}
				propertyChangedEventHandler = propertyChangedEventHandler2;
				num2 = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d != 0)
				{
					num2 = 3;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 5;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 5:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 4;
					break;
				case 1:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 2:
					value2 = (PropertyChangedEventHandler)X_03025.W_03014(propertyChangedEventHandler2, value, X_03025.m_03026);
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num2 = 2;
					break;
				default:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num2 = 3;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 4;
				}
			}
		}
	}

	public MainWindow()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		_selectedUpdateUrl = "";
		_isRegularFirmware = true;
		_consoleName = "";
		_consoleProfileName = Kusbq8F7xd8hvTfPmi.grulUC7Fy(-632601858 ^ -1822012373 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357);
		_registKey = "";
		_rpKey = new byte[16];
		((MetroWindow)this)._002Ector();
		int num = 10;
		string semVer = default(string);
		string commitsSinceVersionSource = default(string);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				UpdateWizardUI();
				num = 6;
				break;
			case 9:
				semVer = GitVersionInformation.SemVer;
				num2 = 8;
				goto IL_00a5;
			case 8:
				commitsSinceVersionSource = GitVersionInformation.CommitsSinceVersionSource;
				num = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b5166be943434fc89f58fe94f4427546 != 0)
				{
					num = 0;
				}
				break;
			case 7:
				o_0303p.W_03014(new TextBoxWriter(OutputConsoleBox), o_0303p.K_0303q);
				num2 = 4;
				goto IL_00a5;
			case 2:
				R_0303v.W_03014(_timer, true, R_0303v.I_0303w);
				num = 3;
				break;
			case 3:
				PropertyChanged += SelfPropertyChanged;
				num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fd11df4b554a4857971cbcb3f50852a1 == 0)
				{
					num = 0;
				}
				break;
			case 5:
			{
				MainWindow root = Root;
				B_0303j.W_03014(root, u_0303n.W_03014(B_0303l.W_03014(root, B_0303l.H_0303m), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x52C0903 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcfd4456535940d28c81b9e4f3883ae7), GitVersionInformation.CommitDate, u_0303n.f_0303o), B_0303j.F_0303k);
				num = 7;
				break;
			}
			case 6:
				return;
			case 10:
				InitializeComponent();
				num = 9;
				break;
			case 4:
				_timer = new DispatcherTimer(F_0303r.W_03014(500.0, F_0303r.z_0303s), DispatcherPriority.Normal, DeviceCheckCallback, p_0303t.W_03014(p_0303t.G_0303u));
				num = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 != 0)
				{
					num = 2;
				}
				break;
			case 1:
				{
					B_0303j.W_03014(Root, e_0303_0313.W_03014(commitsSinceVersionSource, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x22A3119A ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c1be1b45dbbd4f769f36fd21d36e7f59), e_0303_0313.C_0303_0314) ? I_0301f.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x407CA8AF ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f), semVer, I_0301f.G_0301g) : s_0303h.W_03014(new string[8]
					{
						Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x505724DD ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_327d25deb5ac44ada715c7ead1c1918d),
						GitVersionInformation.Major,
						Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xFA62877 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_95da1571cded41d097dc9e01312a6680),
						GitVersionInformation.Minor,
						Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4997C4CD ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_38834d0493064add9a2735fdb19406c5),
						GitVersionInformation.Patch,
						Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x25140795 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9d36fdf97c024002867cae0bb6aa1fbf),
						GitVersionInformation.CommitsSinceVersionSource
					}, s_0303h.t_0303i), B_0303j.F_0303k);
					num = 5;
					break;
				}
				IL_00a5:
				num = num2;
				break;
			}
		}
	}

	private void SelfPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 1:
				if (!e_0303_0313.W_03014(K_0303x.W_03014(e, K_0303x.N_0303y), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFA224 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138), e_0303_0313.C_0303_0314))
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f43509d83f5a4360b41bf11f28723098 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			OnPropertyChanged(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4D777122 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c9a32eeeb3884a54899eeffd5f76bd12));
			num2 = 2;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f != 0)
			{
				num2 = 2;
			}
		}
	}

	private void DeviceCheckCallback(object sender, EventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				P_0303z.W_03014(delegate
				{
					switch (1)
					{
					case 0:
						break;
					case 1:
						try
						{
							int num3;
							if (Device != null)
							{
								num3 = 44;
								goto IL_0046;
							}
							goto IL_0459;
							IL_02a4:
							bool flag = ZenLinkHid.IsZenLinkAppModeConnected();
							num3 = 55;
							goto IL_0046;
							IL_0046:
							_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_2 = default(_003C_003Ec__DisplayClass29_0);
							ZenLinkHidDevice[] zenLinkDevices = default(ZenLinkHidDevice[]);
							_003C_003Ec__DisplayClass29_1 _003C_003Ec__DisplayClass29_ = default(_003C_003Ec__DisplayClass29_1);
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 4:
									return;
								case 5:
									return;
								case 20:
									return;
								case 59:
									return;
								case 28:
									if (_currentStep == WizardStep.SavingAndRestarting)
									{
										num3 = 13;
										continue;
									}
									goto case 29;
								case 21:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(_003C_003Ec__DisplayClass29_2._003CDeviceCheckCallback_003Eb__1);
									num3 = 28;
									continue;
								case 46:
								case 60:
									zenLinkDevices = ZenLinkHid.GetZenLinkDevices();
									num3 = 13;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d2338023c8544d0e8649719c51cf0dae == 0)
									{
										num3 = 58;
									}
									continue;
								case 44:
									if (!Device.IsConnected)
									{
										num3 = 45;
										continue;
									}
									goto IL_0459;
								case 55:
									if (!flag)
									{
										num3 = 34;
										continue;
									}
									goto case 12;
								case 56:
									Device.DataReceived += Device_DataReceived;
									num3 = 1;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f == 0)
									{
										num3 = 0;
									}
									continue;
								case 49:
									_003C_003Ec__DisplayClass29_2.removedSerial = Device.Serial;
									num3 = 41;
									continue;
								case 62:
									Device.SendCommand(new ZenLinkCommandData(ZenLinkCommandData.ZenLinkCommand.GetFwVersion));
									num3 = 5;
									continue;
								case 11:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
									{
										int num10 = 3;
										int num11 = num10;
										while (true)
										{
											switch (num11)
											{
											default:
												return;
											case 3:
												w_0304_0313.W_03014(StatusText, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3FC89FEE ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09), w_0304_0313.b_0304_0314);
												num11 = 2;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc43730c8c1243539ddcaa4fa538fc77 != 0)
												{
													num11 = 2;
												}
												break;
											case 2:
												UpdateWizardUI();
												num11 = 1;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
												{
													num11 = 1;
												}
												break;
											case 0:
												return;
											case 1:
												WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x71DFDC5F ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187));
												num11 = 0;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0 == 0)
												{
													num11 = 0;
												}
												break;
											}
										}
									});
									num3 = 4;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee != 0)
									{
										num3 = 18;
									}
									continue;
								case 27:
									break;
								case 29:
									_currentStep = WizardStep.WaitingForDevice;
									num3 = 39;
									continue;
								case 53:
									_disconnectionTime = C_03045.W_03014(C_03045.L_03046);
									num4 = 2;
									goto IL_0042;
								case 14:
									if (_appModeReconnectionMessageShown)
									{
										return;
									}
									num3 = 10;
									continue;
								case 8:
								case 34:
								case 35:
									if (!flag)
									{
										num3 = 46;
										continue;
									}
									goto case 63;
								case 7:
								case 43:
									_appModeMessageShown = true;
									num4 = 26;
									goto IL_0042;
								case 24:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(_003C_003Ec__DisplayClass29_._003CDeviceCheckCallback_003Eb__7);
									num3 = 56;
									continue;
								case 54:
									Device = zenLinkDevices.FirstOrDefault();
									num3 = 23;
									continue;
								case 9:
									_003C_003Ec__DisplayClass29_._003C_003E4__this = this;
									num3 = 57;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
									{
										num3 = 24;
									}
									continue;
								default:
									Device.SendCommand(new ZenLinkCommandData(ZenLinkCommandData.ZenLinkCommand.GetStatus));
									num3 = 62;
									continue;
								case 51:
									if (!_deviceDisconnectedForUpdate)
									{
										num4 = 8;
										goto IL_0042;
									}
									goto case 14;
								case 39:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
									{
										int num18 = 1;
										int num19 = num18;
										while (true)
										{
											switch (num19)
											{
											case 2:
												return;
											case 1:
												UpdateWizardUI();
												num19 = 0;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f43509d83f5a4360b41bf11f28723098 == 0)
												{
													num19 = 0;
												}
												break;
											default:
												WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x61CC80D2 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9f387354365c4f5d9b8da71dd7da7847));
												num19 = 1;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0 != 0)
												{
													num19 = 2;
												}
												break;
											}
										}
									});
									num3 = 17;
									continue;
								case 37:
									_currentStep = WizardStep.MonitoringUpdate;
									num4 = 11;
									goto IL_0042;
								case 10:
									_appModeReconnectionMessageShown = true;
									num4 = 16;
									goto IL_0042;
								case 36:
									goto IL_0459;
								case 57:
									_003C_003Ec__DisplayClass29_.foundSerial = Device.Serial;
									num3 = 24;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7 == 0)
									{
										num3 = 0;
									}
									continue;
								case 13:
									_deviceDisconnectedForUpdate = true;
									num3 = 53;
									continue;
								case 15:
									if (_deviceDisconnectedForUpdate)
									{
										num3 = 52;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 == 0)
										{
											num3 = 24;
										}
										continue;
									}
									goto case 33;
								case 63:
									if (!_appModeMessageShown)
									{
										num3 = 25;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fae40d88e3574df5aa9c4dc3b17260d4 != 0)
										{
											num3 = 15;
										}
										continue;
									}
									goto case 46;
								case 2:
									_currentStep = WizardStep.WaitingForReconnection;
									num3 = 38;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fd11df4b554a4857971cbcb3f50852a1 != 0)
									{
										num3 = 37;
									}
									continue;
								case 40:
								case 47:
									Device.SendCommand(new ZenLinkCommandData(ZenLinkCommandData.ZenLinkCommand.GetStatus));
									num3 = 59;
									continue;
								case 33:
									if (_currentStep != 0)
									{
										num3 = 0;
										if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9f387354365c4f5d9b8da71dd7da7847 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 61;
								case 45:
									_003C_003Ec__DisplayClass29_2 = new _003C_003Ec__DisplayClass29_0();
									num3 = 30;
									continue;
								case 58:
									if (zenLinkDevices == null)
									{
										num4 = 42;
										goto IL_0042;
									}
									goto case 50;
								case 30:
									_003C_003Ec__DisplayClass29_2._003C_003E4__this = this;
									num3 = 49;
									continue;
								case 52:
									_deviceDisconnectedForUpdate = false;
									num3 = 37;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f == 0)
									{
										num3 = 3;
									}
									continue;
								case 25:
									if (_currentStep == WizardStep.WaitingForDevice)
									{
										num3 = 7;
										continue;
									}
									goto case 22;
								case 16:
									WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xFA62397 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_95da1571cded41d097dc9e01312a6680));
									num3 = 19;
									continue;
								case 31:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
									{
										int num12 = 1;
										int num13 = num12;
										while (true)
										{
											switch (num13)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												OnPropertyChanged(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x54AF9E3E ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0));
												num13 = 0;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3d919d8db5124a9a868cec92d1e40a53 == 0)
												{
													num13 = 0;
												}
												break;
											}
										}
									});
									num3 = 36;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa != 0)
									{
										num3 = 28;
									}
									continue;
								case 12:
									if (_currentStep == WizardStep.WaitingForReconnection)
									{
										num3 = 51;
										continue;
									}
									goto case 8;
								case 41:
									Device.DataReceived -= Device_DataReceived;
									num3 = 21;
									continue;
								case 22:
									if (_currentStep == WizardStep.SelectFirmware)
									{
										num3 = 43;
										continue;
									}
									goto case 46;
								case 23:
								case 42:
									if (Device == null)
									{
										return;
									}
									num3 = 6;
									continue;
								case 6:
									_003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_1();
									num3 = 7;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b5166be943434fc89f58fe94f4427546 == 0)
									{
										num3 = 9;
									}
									continue;
								case 38:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
									{
										int num14 = 3;
										int num15 = num14;
										while (true)
										{
											switch (num15)
											{
											default:
												return;
											case 1:
												WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xCC6543C ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057));
												num15 = 0;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340 == 0)
												{
													num15 = 0;
												}
												break;
											case 2:
												UpdateWizardUI();
												num15 = 1;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1334650a1fad49d0a3bb740dbd10b979 == 0)
												{
													num15 = 0;
												}
												break;
											case 0:
												return;
											case 3:
												w_0304_0313.W_03014(StatusText, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xF7C8A1B ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1334650a1fad49d0a3bb740dbd10b979), w_0304_0313.b_0304_0314);
												num15 = 2;
												break;
											}
										}
									});
									num3 = 3;
									continue;
								case 50:
									if (zenLinkDevices.Length != 0)
									{
										num3 = 54;
										continue;
									}
									goto case 23;
								case 48:
									if (_currentStep == WizardStep.WaitingForReconnection)
									{
										num4 = 15;
										goto IL_0042;
									}
									goto case 33;
								case 3:
								case 17:
									Device = null;
									num3 = 31;
									continue;
								case 1:
									A_0302h.W_03014(500, A_0302h.f_0302i);
									num3 = 48;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735 == 0)
									{
										num3 = 44;
									}
									continue;
								case 19:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
									{
										int num16 = 1;
										int num17 = num16;
										while (true)
										{
											switch (num17)
											{
											default:
												return;
											case 1:
												Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4F5CC33B ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c4660e063da64e88b525b9eedf46cebf), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x492D1FED ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357), MessageBoxButton.OK, MessageBoxImage.Exclamation, Q_0304_0305.S_0304_0306);
												num17 = 0;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d2338023c8544d0e8649719c51cf0dae != 0)
												{
													num17 = 0;
												}
												break;
											case 0:
												return;
											}
										}
									});
									num3 = 20;
									continue;
								case 26:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
									{
										int num20 = 1;
										int num21 = num20;
										while (true)
										{
											switch (num21)
											{
											case 2:
												return;
											case 1:
												if (Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5B97E78E ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xE51C629 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a), MessageBoxButton.YesNo, MessageBoxImage.Exclamation, Q_0304_0305.S_0304_0306) != MessageBoxResult.Yes)
												{
													return;
												}
												num21 = 0;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0cdd1f18e70e4c1a9df214f750a13103 == 0)
												{
													num21 = 0;
												}
												break;
											default:
												n_0303_0303.W_03014(m_0303_0301.W_03014(m_0303_0301.B_0303_0302), n_0303_0303.O_0303_0304);
												num21 = 2;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_571b725aa29b475a984fdca6db66c6d7 != 0)
												{
													num21 = 1;
												}
												break;
											}
										}
									});
									num3 = 4;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7 == 0)
									{
										num3 = 3;
									}
									continue;
								case 61:
									{
										X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
										{
											int num8 = 1;
											int num9 = num8;
											while (true)
											{
												switch (num9)
												{
												default:
													return;
												case 0:
													return;
												case 1:
													WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x2514172B ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9d36fdf97c024002867cae0bb6aa1fbf));
													num9 = 0;
													if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_38834d0493064add9a2735fdb19406c5 != 0)
													{
														num9 = 0;
													}
													break;
												}
											}
										});
										num3 = 32;
										continue;
									}
									IL_0042:
									num3 = num4;
									continue;
								}
								break;
							}
							goto IL_02a4;
							IL_0459:
							if (Device != null)
							{
								num3 = 40;
								goto IL_0046;
							}
							goto IL_02a4;
						}
						catch (Exception ex)
						{
							_003C_003Ec__DisplayClass29_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass29_2();
							Exception ex2 = ex;
							int num5 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6217a62854984f0aa28397e756233e38 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								case 2:
									return;
								default:
									CS_0024_003C_003E8__locals0.ex = ex2;
									num5 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_304153599072435a82aaecf2f82feedf == 0)
									{
										num5 = 1;
									}
									break;
								case 1:
									X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
									{
										int num6 = 1;
										int num7 = num6;
										while (true)
										{
											switch (num7)
											{
											default:
												return;
											case 0:
												return;
											case 1:
												WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFBE84 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138), o_0304_030B.W_03014(CS_0024_003C_003E8__locals0.ex, o_0304_030B.C_0304_030C));
												num7 = 0;
												if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4c7aa379fe63429c9a5648f0c3a496e7 == 0)
												{
													num7 = 0;
												}
												break;
											}
										}
									});
									num5 = 2;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37ddfbd9b6e3416cb0041f10c1750410 == 0)
									{
										num5 = 0;
									}
									break;
								}
							}
						}
					}
				}, P_0303z.M_0304_0300);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8d0bea1e026846f18f6c34e545f4c26b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Device_DataReceived(object sender, ZenLinkResponseData e)
	{
		int num = 33;
		ZenLinkResponseData.ResponseDataType dataType = default(ZenLinkResponseData.ResponseDataType);
		ZenLinkResponseData.ZenLinkStatus status = default(ZenLinkResponseData.ZenLinkStatus);
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = default(_003C_003Ec__DisplayClass30_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 60:
					if (Device.Status == ZenLinkResponseData.ZenLinkStatus.SuccessIdle)
					{
						num2 = 3;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 14;
				case 56:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x68B01135 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f6b5164885314b7dba3bc5b59f455ef1), _firmwareVersion);
					num2 = 24;
					continue;
				case 6:
					return;
				case 32:
				{
					switch (dataType)
					{
					default:
						num2 = 7;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4c7aa379fe63429c9a5648f0c3a496e7 != 0)
						{
							num2 = 23;
						}
						continue;
					case ZenLinkResponseData.ResponseDataType.SaveSlot:
						if (e.Payload[0] == 0)
						{
							num2 = 21;
							continue;
						}
						return;
					case (ZenLinkResponseData.ResponseDataType)3:
					case (ZenLinkResponseData.ResponseDataType)4:
						return;
					case ZenLinkResponseData.ResponseDataType.FwVersion:
						_firmwareVersion = M_0303b.W_03014(y_0301l.W_03014(y_0301l.t_0301m), e.Payload, M_0303b.C_0303c);
						num2 = 56;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9 == 0)
						{
							num2 = 10;
						}
						continue;
					case ZenLinkResponseData.ResponseDataType.Status:
						break;
					}
					ZenLinkResponseData.ZenLinkStatus status2 = Device.Status;
					Device.Status = (ZenLinkResponseData.ZenLinkStatus)e.Payload[0];
					if (status2 != Device.Status)
					{
						num = 27;
						break;
					}
					goto case 44;
				}
				case 44:
					if (_currentStep == WizardStep.WaitingForDevice)
					{
						num2 = 10;
						continue;
					}
					goto case 22;
				case 40:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3322D759 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_269ca61221264cd4849c6d28d9b13400));
					num2 = 4;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e != 0)
					{
						num2 = 38;
					}
					continue;
				case 16:
					UpdateWizardUI();
					num2 = 4;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0930bb33db454b25a03d860bf5bbc5c2 == 0)
					{
						num2 = 35;
					}
					continue;
				case 29:
					switch (status)
					{
					default:
						num2 = 50;
						break;
					case ZenLinkResponseData.ZenLinkStatus.FailedToConnectToWifi:
						WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x16BEE140 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f));
						num2 = 61;
						break;
					case ZenLinkResponseData.ZenLinkStatus.FailedToLoadSettings:
						return;
					case ZenLinkResponseData.ZenLinkStatus.FailedUpdate:
					case ZenLinkResponseData.ZenLinkStatus.FailedToCheckForUpdate:
						Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x78CDCAC1 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3322D97D ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_269ca61221264cd4849c6d28d9b13400), MessageBoxButton.OK, MessageBoxImage.Hand, Q_0304_0305.S_0304_0306);
						num2 = 42;
						break;
					}
					continue;
				case 4:
					if (status != ZenLinkResponseData.ZenLinkStatus.ActionCheckingForUpdate)
					{
						num2 = 3;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_80fd07eaac7d47cea616de92b005f1c3 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
					{
						int num7 = 1;
						int num8 = num7;
						string result3 = default(string);
						while (true)
						{
							switch (num8)
							{
							default:
								return result3;
							case 1:
								w_0304_0313.W_03014(StatusText, result3 = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x7676AD29 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_04c1f1855e5a47fca8e92911c06137c4), w_0304_0313.b_0304_0314);
								num8 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
								{
									num8 = 0;
								}
								break;
							}
						}
					});
					num2 = 28;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_46b91f02f6784140a9e69ec964155097 != 0)
					{
						num2 = 9;
					}
					continue;
				case 55:
					return;
				case 7:
					UpdateWizardUI();
					num2 = 63;
					continue;
				case 59:
					return;
				case 5:
					if (status == ZenLinkResponseData.ZenLinkStatus.SuccessNoUpdateAvailable)
					{
						_updateCompleted = true;
						num2 = 13;
						continue;
					}
					num2 = 13;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9 != 0)
					{
						num2 = 30;
					}
					continue;
				case 53:
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
					{
						UpdateWizardUI();
					});
					num2 = 52;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddb099dfb02d45f9999d339f0c3264ae == 0)
					{
						num2 = 55;
					}
					continue;
				case 33:
					dataType = e.DataType;
					num2 = 32;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 == 0)
					{
						num2 = 24;
					}
					continue;
				case 14:
					if (Device.Status != ZenLinkResponseData.ZenLinkStatus.ActionCheckingForUpdate)
					{
						num2 = 36;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 == 0)
						{
							num2 = 34;
						}
						continue;
					}
					goto case 65;
				case 50:
					return;
				case 27:
					OnPropertyChanged(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x7DB4F5E3 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175));
					num2 = 51;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 == 0)
					{
						num2 = 17;
					}
					continue;
				case 49:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5C4E8E8A ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65));
					num2 = 47;
					continue;
				case 51:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(-1794563414 ^ -1430149094 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09), Device.Status);
					num2 = 25;
					continue;
				case 36:
					if (Device.Status != ZenLinkResponseData.ZenLinkStatus.SuccessConnectedToNetwork)
					{
						num2 = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddbeca16f1644256a4bb2ccb7a64392a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 65;
				case 19:
					_003C_003Ec__DisplayClass30_._003C_003E4__this = this;
					num2 = 11;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_46b91f02f6784140a9e69ec964155097 == 0)
					{
						num2 = 43;
					}
					continue;
				case 45:
					UpdateProgressBarFromBytes(_003C_003Ec__DisplayClass30_.written, _003C_003Ec__DisplayClass30_.total);
					num2 = 12;
					continue;
				case 11:
					_currentStep = WizardStep.Completed;
					num = 15;
					break;
				case 15:
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
					{
						UpdateWizardUI();
					});
					num2 = 6;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d == 0)
					{
						num2 = 6;
					}
					continue;
				case 43:
					status = Device.Status;
					num2 = 26;
					continue;
				case 48:
					return;
				case 1:
					if (Device.Status != ZenLinkResponseData.ZenLinkStatus.SuccessStartup)
					{
						num2 = 22;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_38834d0493064add9a2735fdb19406c5 != 0)
						{
							num2 = 54;
						}
						continue;
					}
					goto case 65;
				case 47:
					Device.SendCommand(new ZenLinkCommandData(ZenLinkCommandData.ZenLinkCommand.Restart));
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6217a62854984f0aa28397e756233e38 != 0)
					{
						num2 = 0;
					}
					continue;
				case 58:
					if (Device.Status != ZenLinkResponseData.ZenLinkStatus.FailedToLoadSettings)
					{
						num2 = 34;
						continue;
					}
					goto case 40;
				case 12:
					return;
				case 9:
					UpdateWizardUI();
					num2 = 20;
					continue;
				case 10:
					if (Device.Status != ZenLinkResponseData.ZenLinkStatus.Unknown)
					{
						num2 = 58;
						continue;
					}
					goto case 22;
				case 24:
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
					{
						int num3 = 1;
						int num4 = num3;
						string result = default(string);
						while (true)
						{
							switch (num4)
							{
							default:
								return result;
							case 1:
								w_0304_0313.W_03014(CurrentFwVersion, result = I_0301f.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5B97E1EC ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab), _firmwareVersion, I_0301f.G_0301g), w_0304_0313.b_0304_0314);
								num4 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num = 48;
					break;
				case 30:
					if (status == ZenLinkResponseData.ZenLinkStatus.SuccessUpdateDone)
					{
						_updateCompleted = true;
						num2 = 11;
					}
					else
					{
						num2 = 4;
					}
					continue;
				case 2:
					return;
				case 42:
					_currentStep = WizardStep.Completed;
					num = 9;
					break;
				case 34:
					if (Device.Status == ZenLinkResponseData.ZenLinkStatus.FailedToConnectToWifi)
					{
						num2 = 40;
						continue;
					}
					goto case 60;
				case 62:
					return;
				case 57:
					_003C_003Ec__DisplayClass30_.total = P_0304_0303.W_03014(e.Payload, 5, P_0304_0303.O_0304_0304);
					num2 = 12;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 != 0)
					{
						num2 = 52;
					}
					continue;
				case 31:
					_003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
					num2 = 19;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a == 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 52:
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke((Func<string>)_003C_003Ec__DisplayClass30_._003CDevice_DataReceived_003Eb__3);
					num = 45;
					break;
				case 26:
					if (status > ZenLinkResponseData.ZenLinkStatus.ActionCheckingForUpdate)
					{
						num2 = 41;
						continue;
					}
					goto case 5;
				case 21:
					if (e.Payload[1] != 0)
					{
						Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4F5CD8B9 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c4660e063da64e88b525b9eedf46cebf), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x62BB06C1 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2681649985b54e79aaedb58d7dca3197), MessageBoxButton.OK, MessageBoxImage.Hand, Q_0304_0305.S_0304_0306);
						num2 = 2;
						continue;
					}
					num2 = 12;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa == 0)
					{
						num2 = 37;
					}
					continue;
				case 64:
					UpdateWizardUI();
					num2 = 22;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ea170ccda6ba48c3a6de60fbf9a6bd3c != 0)
					{
						num2 = 4;
					}
					continue;
				case 54:
					if (Device.Status == ZenLinkResponseData.ZenLinkStatus.SuccessHeartBeat)
					{
						num2 = 65;
						continue;
					}
					goto case 22;
				case 65:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(-1794563414 ^ -1267390189 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4c7aa379fe63429c9a5648f0c3a496e7));
					num2 = 66;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0042670e6f54a62abe3949793fdea70 != 0)
					{
						num2 = 11;
					}
					continue;
				case 67:
					if (status == ZenLinkResponseData.ZenLinkStatus.ActionApplyFirmwareUpdate)
					{
						_003C_003Ec__DisplayClass30_.written = P_0304_0303.W_03014(e.Payload, 1, P_0304_0303.O_0304_0304);
						num2 = 33;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa == 0)
						{
							num2 = 57;
						}
					}
					else
					{
						num2 = 29;
					}
					continue;
				case 3:
					return;
				case 41:
					if (status != ZenLinkResponseData.ZenLinkStatus.ActionDownloadingFirmwareUpdate)
					{
						num2 = 67;
						continue;
					}
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
					{
						int num5 = 1;
						int num6 = num5;
						string result2 = default(string);
						while (true)
						{
							switch (num6)
							{
							default:
								return result2;
							case 1:
								w_0304_0313.W_03014(StatusText, result2 = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xE51C27B ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a), w_0304_0313.b_0304_0314);
								num6 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 == 0)
								{
									num6 = 0;
								}
								break;
							}
						}
					});
					num2 = 46;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 == 0)
					{
						num2 = 39;
					}
					continue;
				case 18:
					_currentStep = WizardStep.SelectFirmware;
					num2 = 7;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddb099dfb02d45f9999d339f0c3264ae != 0)
					{
						num2 = 3;
					}
					continue;
				case 20:
					return;
				case 13:
					_currentStep = WizardStep.Completed;
					num2 = 53;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63a4f0b908574a1c90af34305f576357 == 0)
					{
						num2 = 53;
					}
					continue;
				case 37:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xC120234 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340));
					num = 49;
					break;
				case 61:
					_currentStep = WizardStep.SelectFirmware;
					num2 = 17;
					continue;
				case 25:
					if (Device.Status == ZenLinkResponseData.ZenLinkStatus.SuccessIdle)
					{
						num2 = 8;
						continue;
					}
					goto case 44;
				case 28:
					SetProgressBarIndeterminate();
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057 != 0)
					{
						num2 = 39;
					}
					continue;
				case 66:
					_currentStep = WizardStep.MonitoringUpdate;
					num = 16;
					break;
				case 39:
					return;
				case 22:
				case 35:
				case 63:
					if (_currentStep != WizardStep.MonitoringUpdate)
					{
						return;
					}
					num2 = 31;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee == 0)
					{
						num2 = 29;
					}
					continue;
				case 8:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xF7C807F ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1334650a1fad49d0a3bb740dbd10b979));
					num2 = 44;
					continue;
				case 46:
					SetProgressBarIndeterminate();
					num2 = 59;
					continue;
				case 17:
					UpdateWizardUI();
					num2 = 62;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a == 0)
					{
						num2 = 25;
					}
					continue;
				case 23:
					return;
				case 38:
					_currentStep = WizardStep.SelectFirmware;
					num2 = 64;
					continue;
				}
				break;
			}
		}
	}

	private void UpdateWizardUI()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
				{
					int num3 = 20;
					WizardStep currentStep = default(WizardStep);
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 18:
								return;
							case 25:
								a_03049.W_03014(BackButton, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xC121838 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340), a_03049.k_0304a);
								num4 = 5;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fd11df4b554a4857971cbcb3f50852a1 != 0)
								{
									num4 = 5;
								}
								continue;
							case 10:
								a_03049.W_03014(BackButton, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x61116DD3 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735), a_03049.k_0304a);
								num3 = 3;
								break;
							case 4:
								return;
							case 22:
								return;
							case 2:
								w_0304_0313.W_03014(WaitingText, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x61116DC3 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735), w_0304_0313.b_0304_0314);
								num4 = 17;
								continue;
							case 13:
								return;
							case 24:
								U_03047.W_03014(BackButton, Visibility.Collapsed, U_03047.h_03048);
								num4 = 6;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c2c3ce1f4ddb4007ac8aee3f7aa00fdb != 0)
								{
									num4 = 5;
								}
								continue;
							case 20:
								U_03047.W_03014(WaitingPanel, Visibility.Collapsed, U_03047.h_03048);
								num4 = 19;
								continue;
							default:
								if (_currentStep == WizardStep.ConfigureConsole)
								{
									num3 = 26;
									break;
								}
								goto case 24;
							case 15:
								U_03047.W_03014(WifiCredentialsPanel, Visibility.Collapsed, U_03047.h_03048);
								num4 = 8;
								continue;
							case 27:
								return;
							case 19:
								U_03047.W_03014(FirmwareSelectionPanel, Visibility.Collapsed, U_03047.h_03048);
								num4 = 8;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 != 0)
								{
									num4 = 15;
								}
								continue;
							case 7:
								switch (currentStep)
								{
								case WizardStep.Completed:
									U_03047.W_03014(CompletedPanel, Visibility.Visible, U_03047.h_03048);
									num4 = 12;
									continue;
								case WizardStep.WaitingForDevice:
									U_03047.W_03014(WaitingPanel, Visibility.Visible, U_03047.h_03048);
									num4 = 2;
									continue;
								case WizardStep.EnterWifiCredentials:
									U_03047.W_03014(WifiCredentialsPanel, Visibility.Visible, U_03047.h_03048);
									num4 = 27;
									continue;
								case WizardStep.ConfigureConsole:
									U_03047.W_03014(ConsoleConfigPanel, Visibility.Visible, U_03047.h_03048);
									num4 = 1;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340 == 0)
									{
										num4 = 1;
									}
									continue;
								case WizardStep.SelectFirmware:
									U_03047.W_03014(FirmwareSelectionPanel, Visibility.Visible, U_03047.h_03048);
									num4 = 11;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee != 0)
									{
										num4 = 13;
									}
									continue;
								case WizardStep.SavingAndRestarting:
								case WizardStep.WaitingForReconnection:
								case WizardStep.MonitoringUpdate:
									U_03047.W_03014(ProgressPanel, Visibility.Visible, U_03047.h_03048);
									num4 = 4;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b927bd6dd7724fcda22eb4eea5c191bf == 0)
									{
										num4 = 3;
									}
									continue;
								}
								num3 = 22;
								break;
							case 8:
								U_03047.W_03014(ConsoleConfigPanel, Visibility.Collapsed, U_03047.h_03048);
								num3 = 11;
								break;
							case 3:
							case 5:
							case 6:
								currentStep = _currentStep;
								num4 = 7;
								continue;
							case 23:
								if (_currentStep != WizardStep.SelectFirmware)
								{
									num4 = 14;
									continue;
								}
								goto case 26;
							case 11:
								U_03047.W_03014(ProgressPanel, Visibility.Collapsed, U_03047.h_03048);
								num3 = 21;
								break;
							case 12:
								X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
								{
									int num5 = 1;
									int num6 = num5;
									string result = default(string);
									while (true)
									{
										switch (num6)
										{
										default:
											return result;
										case 1:
											w_0304_0313.W_03014(CurrentFwVersion, result = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x1C1C5BD1 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_dfbb6ae721cb49e3bfde5dcf23244f73), w_0304_0313.b_0304_0314);
											num6 = 0;
											if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e853f2c5493844b58b596283dba83a5c == 0)
											{
												num6 = 0;
											}
											break;
										}
									}
								});
								num4 = 18;
								continue;
							case 9:
								U_03047.W_03014(BackButton, Visibility.Visible, U_03047.h_03048);
								num4 = 25;
								continue;
							case 17:
								return;
							case 14:
								if (_currentStep != WizardStep.EnterWifiCredentials)
								{
									num4 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_46b91f02f6784140a9e69ec964155097 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 26;
							case 16:
								if (_currentStep == WizardStep.Completed)
								{
									num4 = 9;
									continue;
								}
								goto case 23;
							case 21:
								U_03047.W_03014(CompletedPanel, Visibility.Collapsed, U_03047.h_03048);
								num4 = 16;
								continue;
							case 1:
								return;
							case 26:
								U_03047.W_03014(BackButton, Visibility.Visible, U_03047.h_03048);
								num4 = 1;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f43509d83f5a4360b41bf11f28723098 == 0)
								{
									num4 = 10;
								}
								continue;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0042670e6f54a62abe3949793fdea70 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void RegularFirmware_Click(object sender, RoutedEventArgs e)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				_isRegularFirmware = true;
				num2 = 2;
				break;
			case 4:
				_selectedUpdateUrl = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x52C056D ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcfd4456535940d28c81b9e4f3883ae7);
				num2 = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_571b725aa29b475a984fdca6db66c6d7 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x68B0109D ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f6b5164885314b7dba3bc5b59f455ef1));
				num2 = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0b947f42d424e71aa93063b3ccbbc7b != 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				return;
			case 5:
				_currentStep = WizardStep.EnterWifiCredentials;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddb099dfb02d45f9999d339f0c3264ae == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UpdateWizardUI();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void BetaFirmware_Click(object sender, RoutedEventArgs e)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_currentStep = WizardStep.EnterWifiCredentials;
					num2 = 4;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1484f461dcb6411c82ea18afb2b3970d != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4FFE8738 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_530ab5bcc68f44bc8b037d082ca03f8c));
					num2 = 5;
					continue;
				default:
					_isRegularFirmware = false;
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc43730c8c1243539ddcaa4fa538fc77 == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					return;
				case 4:
					break;
				case 1:
					_selectedUpdateUrl = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x61CC999E ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9f387354365c4f5d9b8da71dd7da7847);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d769c23d75ca410a8de1c9751309e9f8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			UpdateWizardUI();
			num = 3;
		}
	}

	private void ReadWifiFromWindows_Click(object sender, RoutedEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		switch (1)
		{
		case 1:
			try
			{
				WlanInterface val = new WlanClient().Interfaces.FirstOrDefault((WlanInterface i) => (int)i.InterfaceState == 1);
				int num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3d919d8db5124a9a868cec92d1e40a53 != 0)
				{
					num = 0;
				}
				WLANProfile wLANProfile = default(WLANProfile);
				while (true)
				{
					switch (num)
					{
					case 5:
					case 7:
						Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xCAFDEAB ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63a4f0b908574a1c90af34305f576357), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xFA62621 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_95da1571cded41d097dc9e01312a6680), MessageBoxButton.OK, MessageBoxImage.Hand, Q_0304_0305.S_0304_0306);
						num = 8;
						break;
					case 4:
						return;
					case 6:
						E_0304_0309.W_03014(WifiPasswordBox, wLANProfile.MSM.security.sharedKey.keyMaterial, E_0304_0309.t_0304_030A);
						num = 2;
						break;
					default:
						if (val == null)
						{
							num = 7;
							break;
						}
						goto case 1;
					case 2:
						WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5C4E8CA2 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65));
						num = 4;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c4660e063da64e88b525b9eedf46cebf == 0)
						{
							num = 2;
						}
						break;
					case 1:
						wLANProfile = WLANProfileParser.Parse(u_0304_0307.W_03014(val, val.CurrentConnection.profileName, u_0304_0307.h_0304_0308));
						num = 3;
						break;
					case 3:
						x_0301h.W_03014(WifiSsidBox, wLANProfile.name, x_0301h.G_0301i);
						num = 6;
						break;
					case 8:
						return;
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a6ca1cf379084c8db91608538d84a1fe == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					Q_0304_0305.W_03014(I_0301f.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x60214DC4 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e), o_0304_030B.W_03014(ex, o_0304_030B.C_0304_030C), I_0301f.G_0301g), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x582838C2 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_353cc89a97134b3dab46f13c2f0d5345), MessageBoxButton.OK, MessageBoxImage.Hand, Q_0304_0305.S_0304_0306);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddb099dfb02d45f9999d339f0c3264ae == 0)
					{
						num2 = 1;
					}
				}
			}
		case 0:
			break;
		}
	}

	private void SaveAndContinue_Click(object sender, RoutedEventArgs e)
	{
		int num = 11;
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 9:
					Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xF3BF32 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37ddfbd9b6e3416cb0041f10c1750410), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFAD3A ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138), MessageBoxButton.OK, MessageBoxImage.Exclamation, Q_0304_0305.S_0304_0306);
					num2 = 12;
					continue;
				case 3:
					return;
				case 13:
					return;
				case 8:
					SaveAllAndRestart();
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (!d_0304_030F.W_03014(text2, d_0304_030F.r_0304_0310))
					{
						num2 = 14;
						continue;
					}
					goto case 7;
				case 14:
					if (e_0301p.W_03014(text2, e_0301p.C_0301q) >= 2)
					{
						num2 = 15;
						continue;
					}
					goto case 7;
				default:
					if (e_0301p.W_03014(text, e_0301p.C_0301q) < 8)
					{
						num2 = 2;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_04c1f1855e5a47fca8e92911c06137c4 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					if (!_isRegularFirmware)
					{
						num2 = 8;
						continue;
					}
					break;
				case 7:
					Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFADC6 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x54AF9004 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0), MessageBoxButton.OK, MessageBoxImage.Exclamation, Q_0304_0305.S_0304_0306);
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 == 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					text = r_0304_030D.W_03014(WifiPasswordBox, r_0304_030D.D_0304_030E);
					num2 = 4;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					text2 = N_0301d.W_03014(WifiSsidBox, N_0301d.D_0301e);
					num2 = 10;
					continue;
				case 1:
					UpdateWizardUI();
					num2 = 13;
					continue;
				case 12:
					return;
				case 6:
					break;
				case 2:
					return;
				case 15:
					if (d_0304_030F.W_03014(text, d_0304_030F.r_0304_0310))
					{
						goto end_IL_0019;
					}
					goto default;
				}
				_currentStep = WizardStep.ConfigureConsole;
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63a4f0b908574a1c90af34305f576357 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0019:
				break;
			}
			num = 5;
		}
	}

	private void LoadConsoleData_Click(object sender, RoutedEventArgs e)
	{
		switch (1)
		{
		case 1:
			try
			{
				ConsoleData consoleData = new ConsoleData(_flashOnlyMode);
				int num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2923e1fba9ce47718eb61931cc552b1b != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						if (!consoleData.IsValid)
						{
							num = 1;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_304153599072435a82aaecf2f82feedf == 0)
							{
								num = 1;
							}
							break;
						}
						goto case 2;
					case 6:
						_rpKey = consoleData.RpKey;
						num = 3;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e == 0)
						{
							num = 3;
						}
						break;
					case 3:
						X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(-632601858 ^ -1143505915 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_21e98ef4eaf84e4d8faaaec3a382e068), _consoleName);
									num6 = 2;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc39b631b368415480c3e5d2234e1cc4 == 0)
									{
										num6 = 2;
									}
									break;
								case 1:
									w_0304_0313.W_03014(ConsoleNameText, _consoleName, w_0304_0313.b_0304_0314);
									num6 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee != 0)
									{
										num6 = 0;
									}
									break;
								case 2:
									return;
								}
							}
						});
						num = 5;
						break;
					case 2:
						_consoleName = consoleData.ConsoleName;
						num = 4;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddb099dfb02d45f9999d339f0c3264ae != 0)
						{
							num = 4;
						}
						break;
					case 5:
						return;
					case 4:
						_registKey = consoleData.RegistKey;
						num = 6;
						break;
					case 1:
					case 7:
						throw new Exception(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3322DD47 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_269ca61221264cd4849c6d28d9b13400));
					}
				}
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0cdd1f18e70e4c1a9df214f750a13103 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x7DB4E65B ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175));
								num4 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_48459cd067ec4aa3905b09f7715edba4 == 0)
								{
									num4 = 0;
								}
								break;
							case 2:
								return;
							default:
								Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFB070 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x55C0F1EF ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_80fd07eaac7d47cea616de92b005f1c3), MessageBoxButton.OK, MessageBoxImage.Hand, Q_0304_0305.S_0304_0306);
								num4 = 2;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340 == 0)
								{
									num4 = 2;
								}
								break;
							}
						}
					});
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc39b631b368415480c3e5d2234e1cc4 == 0)
					{
						num2 = 1;
					}
				}
			}
		case 0:
			break;
		}
	}

	private void FlashOnlyMode_Checked(object sender, RoutedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		ConsoleData consoleData = default(ConsoleData);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_registKey = consoleData.RegistKey;
				num2 = 7;
				break;
			default:
				consoleData = new ConsoleData(bogusData: true);
				num2 = 5;
				break;
			case 5:
				if (consoleData.IsValid)
				{
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ce3991d1f51e4f6e8568482226882025 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 7:
				_rpKey = consoleData.RpKey;
				num2 = 4;
				break;
			case 4:
				X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							w_0304_0313.W_03014(ConsoleNameText, _consoleName, w_0304_0313.b_0304_0314);
							num4 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_530ab5bcc68f44bc8b037d082ca03f8c == 0)
							{
								num4 = 0;
							}
							break;
						case 2:
							return;
						default:
							L_0304b.W_03014(LoadConsoleDataButton, false, L_0304b.K_0304c);
							num4 = 2;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fae40d88e3574df5aa9c4dc3b17260d4 != 0)
							{
								num4 = 2;
							}
							break;
						}
					}
				});
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_consoleName = consoleData.ConsoleName;
				num2 = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3e215a13c22c4f16bcf7e0731bd65bb5 == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				_flashOnlyMode = true;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c4660e063da64e88b525b9eedf46cebf != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private void FlashOnlyMode_Unchecked(object sender, RoutedEventArgs e)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 4:
					_registKey = "";
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37ddfbd9b6e3416cb0041f10c1750410 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_rpKey = new byte[16];
					num2 = 5;
					continue;
				case 5:
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 1:
								w_0304_0313.W_03014(ConsoleNameText, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x4997D2A1 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_38834d0493064add9a2735fdb19406c5), w_0304_0313.b_0304_0314);
								num4 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f6b5164885314b7dba3bc5b59f455ef1 == 0)
								{
									num4 = 0;
								}
								break;
							case 2:
								return;
							default:
								L_0304b.W_03014(LoadConsoleDataButton, true, L_0304b.K_0304c);
								num4 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a3176810913847dc8f013a25168768ce != 0)
								{
									num4 = 2;
								}
								break;
							}
						}
					});
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1484f461dcb6411c82ea18afb2b3970d == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					_flashOnlyMode = false;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0930bb33db454b25a03d860bf5bbc5c2 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_consoleName = "";
			num = 4;
		}
	}

	private void SaveAllConfiguration_Click(object sender, RoutedEventArgs e)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!d_0304_030F.W_03014(_consoleName, d_0304_030F.r_0304_0310))
				{
					num2 = 6;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b5166be943434fc89f58fe94f4427546 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 3;
			case 9:
				if (!d_0304_030F.W_03014(_consoleProfileName, d_0304_030F.r_0304_0310))
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d237449883474436883d608365fc7581 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 7:
				return;
			case 5:
				return;
			case 6:
				_consoleProfileName = N_0301d.W_03014(ConsoleProfileNameBox, N_0301d.D_0301e);
				num2 = 9;
				continue;
			case 2:
				if (!_flashOnlyMode)
				{
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_110dd0634ced4db38ad8dea1cfc7c098 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			default:
				SaveAllAndRestart();
				num2 = 7;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 == 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
				Q_0304_0305.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x39AD9B08 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17b46b885ec745258b175acf5f6dfbd7), Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x20ADF8D5 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743), MessageBoxButton.OK, MessageBoxImage.Exclamation, Q_0304_0305.S_0304_0306);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c2c3ce1f4ddb4007ac8aee3f7aa00fdb == 0)
				{
					num2 = 5;
				}
				continue;
			case 8:
				break;
			}
			_consoleProfileName = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x78CDC8AF ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c);
			num2 = 4;
		}
	}

	private void SaveAllAndRestart()
	{
		int num = 7;
		int num2 = num;
		ConsoleProfileSlotFile file2 = default(ConsoleProfileSlotFile);
		NetworkSlot file = default(NetworkSlot);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				if (_isRegularFirmware)
				{
					num2 = 4;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357 != 0)
					{
						num2 = 4;
					}
					break;
				}
				return;
			case 0:
				return;
			case 2:
				file2 = new ConsoleProfileSlotFile(_consoleProfileName, _consoleName, _registKey, _rpKey);
				num2 = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_721633b9b564440aa7f1c60c8a9fb44f != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Device.SendCommand(new ZenLinkSettingsSaveFileCommandPacket(1, file2));
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (_flashOnlyMode)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340 != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				Device.SendCommand(new ZenLinkSettingsSaveFileCommandPacket(0, file));
				num2 = 5;
				break;
			case 1:
				WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x2FCF739B ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5fec22e42f8747a0a7b3f3ff8e20460a));
				num2 = 2;
				break;
			case 7:
			{
				string ssid = N_0301d.W_03014(WifiSsidBox, N_0301d.D_0301e);
				string password = r_0304_030D.W_03014(WifiPasswordBox, r_0304_030D.D_0304_030E);
				bool valueOrDefault = O_0304_0311.W_03014(Use40MhzCheckBox, O_0304_0311.g_0304_0312).GetValueOrDefault();
				_currentStep = WizardStep.SavingAndRestarting;
				UpdateWizardUI();
				w_0304_0313.W_03014(StatusText, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xF7C897F ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1334650a1fad49d0a3bb740dbd10b979), w_0304_0313.b_0304_0314);
				WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(--1866528964 ^ 0x2237802C ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c9a32eeeb3884a54899eeffd5f76bd12));
				file = new NetworkSlot(ssid, password, valueOrDefault, _selectedUpdateUrl);
				num2 = 6;
				break;
			}
			}
		}
	}

	private void CloseApp_Click(object sender, RoutedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				n_0303_0303.W_03014(m_0303_0301.W_03014(m_0303_0301.B_0303_0302), n_0303_0303.O_0303_0304);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37a350e2f116426ea9e4894743d91f8b == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void BackButton_Click(object sender, RoutedEventArgs e)
	{
		int num = 3;
		int num2 = num;
		WizardStep currentStep = default(WizardStep);
		while (true)
		{
			switch (num2)
			{
			case 3:
				currentStep = _currentStep;
				num2 = 2;
				break;
			case 4:
				return;
			case 1:
				UpdateWizardUI();
				num2 = 4;
				break;
			case 5:
				return;
			default:
				UpdateWizardUI();
				num2 = 7;
				break;
			case 2:
				switch (currentStep)
				{
				case WizardStep.ConfigureConsole:
					_currentStep = WizardStep.EnterWifiCredentials;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa == 0)
					{
						num2 = 0;
					}
					break;
				case WizardStep.EnterWifiCredentials:
					_currentStep = WizardStep.SelectFirmware;
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_29c1b67922dd42ff81ee0e8b6fa89f38 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_571b725aa29b475a984fdca6db66c6d7 == 0)
					{
						num2 = 5;
					}
					break;
				case WizardStep.SelectFirmware:
				case WizardStep.SavingAndRestarting:
				case WizardStep.WaitingForReconnection:
				case WizardStep.MonitoringUpdate:
					return;
				case WizardStep.Completed:
					RestartWizard();
					num2 = 6;
					break;
				}
				break;
			case 6:
				return;
			case 7:
				return;
			}
		}
	}

	private void RestartWizard()
	{
		int num = 20;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 12:
					if (Device.IsConnected)
					{
						num2 = 16;
						continue;
					}
					goto case 6;
				case 1:
					_updateCompleted = false;
					num2 = 18;
					continue;
				case 19:
					_deviceDisconnectedForUpdate = false;
					num2 = 10;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_9d36fdf97c024002867cae0bb6aa1fbf == 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
					{
						int num3 = 9;
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 5:
									L_0304b.W_03014(LoadConsoleDataButton, true, L_0304b.K_0304c);
									num4 = 3;
									continue;
								case 3:
									w_0304_0313.W_03014(CurrentFwVersion, "", w_0304_0313.b_0304_0314);
									num4 = 4;
									continue;
								default:
									x_0301h.W_03014(ConsoleProfileNameBox, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xC120F72 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340), x_0301h.G_0301i);
									num4 = 7;
									continue;
								case 6:
									return;
								case 7:
									w_0304_0313.W_03014(ConsoleNameText, Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x1B06EA0F ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a3176810913847dc8f013a25168768ce), w_0304_0313.b_0304_0314);
									num4 = 2;
									continue;
								case 9:
									x_0301h.W_03014(WifiSsidBox, "", x_0301h.G_0301i);
									num4 = 2;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2681649985b54e79aaedb58d7dca3197 != 0)
									{
										num4 = 8;
									}
									continue;
								case 8:
									E_0304_0309.W_03014(WifiPasswordBox, "", E_0304_0309.t_0304_030A);
									num4 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									n_0304d.W_03014(Use40MhzCheckBox, false, n_0304d.T_0304e);
									num4 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138 != 0)
									{
										num4 = 0;
									}
									continue;
								case 4:
									v_0304f.W_03014(OutputConsoleBox, v_0304f.F_0304g);
									num3 = 6;
									break;
								case 2:
									n_0304d.W_03014(FlashOnlyModeCheckBox, false, n_0304d.T_0304e);
									num3 = 5;
									break;
								}
								break;
							}
						}
					});
					num2 = 11;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c2c3ce1f4ddb4007ac8aee3f7aa00fdb != 0)
					{
						num2 = 6;
					}
					continue;
				case 14:
					_consoleProfileName = Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x5C4E8332 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65);
					num2 = 2;
					continue;
				case 13:
					_appModeMessageShown = false;
					num2 = 5;
					continue;
				case 15:
					_flashOnlyMode = false;
					num = 8;
					break;
				case 20:
					_selectedUpdateUrl = "";
					num2 = 19;
					continue;
				case 11:
					if (Device != null)
					{
						num = 12;
						break;
					}
					goto case 6;
				case 18:
					_consoleName = "";
					num2 = 14;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ae8a0323f82846e89753ed5b0e72253a != 0)
					{
						num2 = 10;
					}
					continue;
				case 16:
					_currentStep = WizardStep.SelectFirmware;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f43509d83f5a4360b41bf11f28723098 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_registKey = "";
					num2 = 7;
					continue;
				case 5:
					_appModeReconnectionMessageShown = false;
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0cdd1f18e70e4c1a9df214f750a13103 != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					_currentStep = WizardStep.WaitingForDevice;
					num2 = 9;
					continue;
				case 7:
					_rpKey = new byte[16];
					num2 = 15;
					continue;
				case 10:
					_isRegularFirmware = true;
					num2 = 13;
					continue;
				default:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFAB04 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138));
					num = 4;
					break;
				case 4:
				case 17:
					UpdateWizardUI();
					num2 = 3;
					continue;
				case 9:
					WriteMessageToConsole(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xF3B912 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37ddfbd9b6e3416cb0041f10c1750410));
					num2 = 16;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc39b631b368415480c3e5d2234e1cc4 == 0)
					{
						num2 = 17;
					}
					continue;
				}
				break;
			}
		}
	}

	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
				if (propertyChanged == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_530ab5bcc68f44bc8b037d082ca03f8c == 0)
					{
						num2 = 0;
					}
					break;
				}
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50ef17754b8e46a78dfbd80f4754fc09 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	private static void WriteMessageToConsole(object msg, params object[] args)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (e_0301p.W_03014(msg, e_0301p.C_0301q) == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					n_0304_0317.W_03014(I_0301f.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xE51DDCD ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a), (string)msg, I_0301f.G_0301g), args, n_0304_0317.m_0304_0318);
					num2 = 3;
				}
				break;
			default:
				z_0304_0315.W_03014(z_0304_0315.I_0304_0316);
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b4649f51030640eca6eac6ca3e38bbd9 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 3:
				return;
			}
		}
	}

	private void SetProgressBarIndeterminate()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(delegate
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 1:
							X_0304h.W_03014(UpdateProgressBar, true, X_0304h.j_0304i);
							num4 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_f43509d83f5a4360b41bf11f28723098 == 0)
							{
								num4 = 0;
							}
							break;
						case 2:
							return;
						default:
							d_0304j.W_03014(UpdateProgressBar, 0.0, d_0304j.C_0304k);
							num4 = 1;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ad3c95b1bcd243c6b435f3029315c447 == 0)
							{
								num4 = 2;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ceeda0ea077b44688035585c5ac00938 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void UpdateProgressBarFromBytes(int bytesWritten, int totalBytes)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = default(_003C_003Ec__DisplayClass47_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass47_.bytesWritten = bytesWritten;
				num2 = 8;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057 == 0)
				{
					num2 = 8;
				}
				continue;
			default:
				_003C_003Ec__DisplayClass47_._003C_003E4__this = this;
				num2 = 6;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65 == 0)
				{
					num2 = 2;
				}
				continue;
			case 5:
				return;
			case 3:
				SetProgressBarIndeterminate();
				num2 = 7;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b3394823ff04450b19a69e1030f474c == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8d0bea1e026846f18f6c34e545f4c26b == 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				return;
			case 6:
				_003C_003Ec__DisplayClass47_.totalBytes = totalBytes;
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c1be1b45dbbd4f769f36fd21d36e7f59 != 0)
				{
					num2 = 2;
				}
				continue;
			case 8:
				if (_003C_003Ec__DisplayClass47_.totalBytes <= 0)
				{
					num2 = 3;
					continue;
				}
				break;
			case 4:
				break;
			}
			X_0304_0301.W_03014(this, X_0304_0301.w_0304_0302).Invoke(_003C_003Ec__DisplayClass47_._003CUpdateProgressBarFromBytes_003Eb__0);
			num2 = 4;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc39b631b368415480c3e5d2234e1cc4 == 0)
			{
				num2 = 5;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		int num = 3;
		int num2 = num;
		Uri uri = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 1:
				uri = new Uri(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x3BFFA8DA ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138), UriKind.Relative);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_cc39b631b368415480c3e5d2234e1cc4 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 4:
				return;
			default:
				F_0303_0309.W_03014(this, uri, F_0303_0309.P_0303_030A);
				num2 = 4;
				break;
			case 3:
				if (!_contentLoaded)
				{
					_contentLoaded = true;
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 28;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					return;
				case 2:
					return;
				case 20:
					N_0304_0319.W_03014(BackButton, BackButton_Click, N_0304_0319.w_03040);
					num2 = 2;
					continue;
				case 22:
					goto IL_0129;
				case 3:
					return;
				case 30:
					return;
				case 14:
					return;
				case 18:
					return;
				default:
					M_03041.W_03014(FlashOnlyModeCheckBox, FlashOnlyMode_Checked, M_03041.G_03042);
					num2 = 23;
					continue;
				case 7:
					return;
				case 10:
					return;
				case 31:
					return;
				case 13:
					return;
				case 19:
					return;
				case 8:
					return;
				case 17:
					return;
				case 21:
					return;
				case 27:
					_contentLoaded = true;
					num2 = 26;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0b947f42d424e71aa93063b3ccbbc7b == 0)
					{
						num2 = 0;
					}
					continue;
				case 25:
					return;
				case 9:
					return;
				case 28:
					switch (connectionId)
					{
					case 10:
						break;
					case 3:
						goto IL_00d8;
					case 1:
						goto IL_0129;
					case 12:
						goto IL_0155;
					case 16:
						goto IL_0191;
					case 11:
						goto IL_01ac;
					case 18:
						goto IL_01c3;
					case 24:
						goto IL_0215;
					case 19:
						goto IL_0251;
					case 21:
						goto IL_0278;
					case 15:
						goto IL_0293;
					case 25:
						goto IL_02aa;
					case 20:
						goto IL_02c1;
					case 26:
						goto IL_02d8;
					case 5:
						goto IL_0316;
					case 4:
						goto IL_0342;
					default:
						goto IL_03f0;
					case 13:
						goto IL_0410;
					case 8:
						goto IL_0437;
					case 2:
						goto IL_044e;
					case 22:
						goto IL_048b;
					case 6:
						goto IL_04f2;
					case 7:
						goto IL_052e;
					case 14:
						goto IL_056b;
					case 23:
						goto IL_0582;
					case 17:
						goto IL_0599;
					case 9:
						goto IL_05c5;
					}
					WifiPasswordBox = (PasswordBox)target;
					num2 = 14;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4692ba88c62f41e2a2f6335b85dab018 == 0)
					{
						num2 = 12;
					}
					continue;
				case 1:
					return;
				case 32:
					return;
				case 29:
					return;
				case 23:
					B_03043.W_03014(FlashOnlyModeCheckBox, FlashOnlyMode_Unchecked, B_03043.E_03044);
					num2 = 10;
					continue;
				case 4:
					return;
				case 33:
					N_0304_0319.W_03014(LoadConsoleDataButton, LoadConsoleData_Click, N_0304_0319.w_03040);
					num2 = 18;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_353cc89a97134b3dab46f13c2f0d5345 == 0)
					{
						num2 = 16;
					}
					continue;
				case 6:
					return;
				case 12:
					return;
				case 26:
					return;
				case 5:
					return;
				case 16:
					return;
				case 24:
					return;
				case 15:
					return;
					IL_01c3:
					FlashOnlyModeCheckBox = (CheckBox)target;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_09ed5e366e9c41e18eb15204e0fe2813 == 0)
					{
						num2 = 0;
					}
					continue;
					IL_05c5:
					WifiSsidBox = (TextBox)target;
					num2 = 11;
					continue;
					IL_0599:
					LoadConsoleDataButton = (Button)target;
					num2 = 33;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_17bdd5e9b19440178af8d2e028175743 == 0)
					{
						num2 = 22;
					}
					continue;
					IL_0191:
					ConsoleNameText = (TextBlock)target;
					num = 24;
					break;
					IL_0582:
					CompletedPanel = (Border)target;
					num2 = 7;
					continue;
					IL_056b:
					ConsoleConfigPanel = (Border)target;
					num2 = 13;
					continue;
					IL_052e:
					N_0304_0319.W_03014((Button)target, BetaFirmware_Click, N_0304_0319.w_03040);
					num2 = 28;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_225ba267fe26452a859963d16a9c6edd == 0)
					{
						num2 = 32;
					}
					continue;
					IL_0155:
					N_0304_0319.W_03014((Button)target, ReadWifiFromWindows_Click, N_0304_0319.w_03040);
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138 != 0)
					{
						num2 = 1;
					}
					continue;
					IL_04f2:
					N_0304_0319.W_03014((Button)target, RegularFirmware_Click, N_0304_0319.w_03040);
					num2 = 12;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_792cdec50f8f497e897fa820072e64b5 == 0)
					{
						num2 = 12;
					}
					continue;
					IL_048b:
					UpdateProgressBar = (ProgressBar)target;
					num2 = 16;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2681649985b54e79aaedb58d7dca3197 == 0)
					{
						num2 = 16;
					}
					continue;
					IL_00d8:
					WaitingPanel = (Border)target;
					num2 = 9;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f == 0)
					{
						num2 = 1;
					}
					continue;
					IL_044e:
					BackButton = (Button)target;
					num2 = 20;
					continue;
					IL_0437:
					WifiCredentialsPanel = (Border)target;
					num2 = 15;
					continue;
					IL_0410:
					N_0304_0319.W_03014((Button)target, SaveAndContinue_Click, N_0304_0319.w_03040);
					num2 = 5;
					continue;
					IL_03f0:
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ad3c95b1bcd243c6b435f3029315c447 == 0)
					{
						num2 = 27;
					}
					continue;
					IL_0129:
					Root = (MainWindow)target;
					num2 = 29;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa != 0)
					{
						num2 = 22;
					}
					continue;
					IL_0342:
					WaitingText = (TextBlock)target;
					num2 = 25;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d2338023c8544d0e8649719c51cf0dae != 0)
					{
						num2 = 6;
					}
					continue;
					IL_0316:
					FirmwareSelectionPanel = (Border)target;
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fd11df4b554a4857971cbcb3f50852a1 == 0)
					{
						num2 = 6;
					}
					continue;
					IL_01ac:
					Use40MhzCheckBox = (CheckBox)target;
					num2 = 3;
					continue;
					IL_02d8:
					CurrentFwVersion = (TextBlock)target;
					num2 = 21;
					continue;
					IL_02c1:
					ProgressPanel = (Border)target;
					num2 = 31;
					continue;
					IL_02aa:
					OutputConsoleBox = (TextBox)target;
					num2 = 17;
					continue;
					IL_0293:
					ConsoleProfileNameBox = (TextBox)target;
					num2 = 30;
					continue;
					IL_0278:
					StatusText = (TextBlock)target;
					num = 4;
					break;
					IL_0251:
					N_0304_0319.W_03014((Button)target, SaveAllConfiguration_Click, N_0304_0319.w_03040);
					num2 = 8;
					continue;
					IL_0215:
					N_0304_0319.W_03014((Button)target, CloseApp_Click, N_0304_0319.w_03040);
					num2 = 19;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_51c9cfdb5bfa42a1845d8a789257871e == 0)
					{
						num2 = 16;
					}
					continue;
				}
				break;
			}
		}
	}

	static MainWindow()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool xVY()
	{
		return vVo == null;
	}

	internal static MainWindow sVk()
	{
		return vVo;
	}
}

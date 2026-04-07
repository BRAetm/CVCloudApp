using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ZenLinkConfigurator.HidLibrary;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class ZenLinkHidDevice
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public ZenLinkCommandData cmd;

		internal static _003C_003Ec__DisplayClass17_0 HV5;

		public _003C_003Ec__DisplayClass17_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ea170ccda6ba48c3a6de60fbf9a6bd3c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal bool _003CSendCommand_003Eb__0(ZenLinkCommandData c)
		{
			return c.Command == cmd.Command;
		}

		static _003C_003Ec__DisplayClass17_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool KVT()
		{
			return HV5 == null;
		}

		internal static _003C_003Ec__DisplayClass17_0 cVG()
		{
			return HV5;
		}
	}

	public readonly HidDevice Device;

	[CompilerGenerated]
	private EventHandler<ZenLinkResponseData> m_DataReceived;

	private readonly BackgroundWorker _readerBw;

	private readonly BackgroundWorker _writerBw;

	private bool _shouldRun;

	public readonly string Serial;

	private readonly ConcurrentQueue<ZenLinkCommandData> _cmdQueue;

	[CompilerGenerated]
	private ZenLinkResponseData.ZenLinkStatus _003CStatus_003Ek__BackingField;

	private readonly List<byte> _payloadBuf;

	private ZenLinkResponseData.ResponseDataType? _lastCmd;

	private ushort _lastPayloadSize;

	internal static ZenLinkHidDevice mVL;

	public ZenLinkResponseData.ZenLinkStatus Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a28d539b0bdc47718b8aff0889ca780f != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool IsConnected => Device.IsConnected;

	public event EventHandler<ZenLinkResponseData> DataReceived
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			EventHandler<ZenLinkResponseData> eventHandler = default(EventHandler<ZenLinkResponseData>);
			EventHandler<ZenLinkResponseData> value2 = default(EventHandler<ZenLinkResponseData>);
			EventHandler<ZenLinkResponseData> eventHandler2 = default(EventHandler<ZenLinkResponseData>);
			while (true)
			{
				switch (num2)
				{
				case 5:
					eventHandler = Interlocked.CompareExchange(ref this.m_DataReceived, value2, eventHandler2);
					num2 = 4;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_dfbb6ae721cb49e3bfde5dcf23244f73 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				default:
					value2 = (EventHandler<ZenLinkResponseData>)y_03023.W_03014(eventHandler2, value, y_03023.T_03024);
					num2 = 5;
					break;
				case 1:
					eventHandler2 = eventHandler;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63437542ddb44ee998bc517d0ffb9193 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					eventHandler = this.m_DataReceived;
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddbeca16f1644256a4bb2ccb7a64392a == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 5;
			EventHandler<ZenLinkResponseData> eventHandler = default(EventHandler<ZenLinkResponseData>);
			EventHandler<ZenLinkResponseData> value2 = default(EventHandler<ZenLinkResponseData>);
			EventHandler<ZenLinkResponseData> eventHandler2 = default(EventHandler<ZenLinkResponseData>);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						eventHandler = this.m_DataReceived;
						num2 = 4;
						continue;
					case 1:
						return;
					default:
						value2 = (EventHandler<ZenLinkResponseData>)X_03025.W_03014(eventHandler2, value, X_03025.m_03026);
						num2 = 2;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3d919d8db5124a9a868cec92d1e40a53 != 0)
						{
							num2 = 2;
						}
						continue;
					case 3:
						if ((object)eventHandler == eventHandler2)
						{
							num2 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a3176810913847dc8f013a25168768ce != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 4:
						break;
					case 2:
						goto end_IL_0019;
					}
					eventHandler2 = eventHandler;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2923e1fba9ce47718eb61931cc552b1b == 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0019:
					break;
				}
				eventHandler = Interlocked.CompareExchange(ref this.m_DataReceived, value2, eventHandler2);
				num = 3;
			}
		}
	}

	public ZenLinkHidDevice(HidDevice device)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		_readerBw = new BackgroundWorker();
		_writerBw = new BackgroundWorker();
		_shouldRun = true;
		_cmdQueue = new ConcurrentQueue<ZenLinkCommandData>();
		_payloadBuf = new List<byte>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b0f933cb8e74f28a93d65045ddbfd34 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
				G_03029.W_03014(_writerBw, true, G_03029.S_0302a);
				num = 3;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3e215a13c22c4f16bcf7e0731bd65bb5 == 0)
				{
					num = 4;
				}
				break;
			case 6:
				U_0302b.W_03014(_writerBw, U_0302b.H_0302c);
				num = 3;
				break;
			case 4:
				U_0302b.W_03014(_readerBw, U_0302b.H_0302c);
				num = 6;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a != 0)
				{
					num = 4;
				}
				break;
			case 5:
				G_03029.W_03014(_readerBw, true, G_03029.S_0302a);
				num = 6;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de == 0)
				{
					num = 7;
				}
				break;
			default:
				Device = device;
				num = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e853f2c5493844b58b596283dba83a5c != 0)
				{
					num = 0;
				}
				break;
			case 7:
				Y_03027.W_03014(_writerBw, WriterBwOnDoWork, Y_03027.q_03028);
				num = 2;
				break;
			case 8:
				Y_03027.W_03014(_readerBw, ReaderBwOnDoWork, Y_03027.q_03028);
				num = 5;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a == 0)
				{
					num = 5;
				}
				break;
			case 1:
				Serial = device.ReadHidSerialNumber();
				num = 6;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8966fddcc2944e33aa877e4b4636c357 != 0)
				{
					num = 8;
				}
				break;
			}
		}
	}

	~ZenLinkHidDevice()
	{
		switch (1)
		{
		case 1:
			try
			{
				_shouldRun = false;
				int num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2681649985b54e79aaedb58d7dca3197 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						h_0302d.W_03014(_writerBw, h_0302d.f_0302e);
						num = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a == 0)
						{
							num = 0;
						}
						break;
					default:
						h_0302d.W_03014(_readerBw, h_0302d.f_0302e);
						num = 2;
						break;
					case 1:
						return;
					}
				}
			}
			finally
			{
				U_0302f.W_03014(this, U_0302f.F_0302g);
				int num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		case 0:
			break;
		}
	}

	public void SendCommand(ZenLinkCommandData cmd)
	{
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				_cmdQueue.Enqueue(_003C_003Ec__DisplayClass17_.cmd);
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (_cmdQueue.Any(_003C_003Ec__DisplayClass17_._003CSendCommand_003Eb__0))
				{
					return;
				}
				num2 = 2;
				break;
			case 5:
				_003C_003Ec__DisplayClass17_.cmd = cmd;
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4692ba88c62f41e2a2f6335b85dab018 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (_003C_003Ec__DisplayClass17_.cmd.Command == ZenLinkCommandData.ZenLinkCommand.GetStatus)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 1:
				return;
			case 6:
				_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e71fba288c4c48909df3df3820f5029f != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return I_0301f.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0x7676BFFF ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_04c1f1855e5a47fca8e92911c06137c4), Serial, I_0301f.G_0301g);
	}

	private void WriterBwOnDoWork(object sender, DoWorkEventArgs e)
	{
		int num = 4;
		int num2 = num;
		IEnumerator<byte[]> enumerator = default(IEnumerator<byte[]>);
		byte[] current = default(byte[]);
		byte[] array = default(byte[]);
		ZenLinkCommandData result = default(ZenLinkCommandData);
		while (true)
		{
			switch (num2)
			{
			case 9:
				try
				{
					while (true)
					{
						IL_00d4:
						int num3;
						if (!h_0302_0319.W_03014(enumerator, h_0302_0319.L_03020))
						{
							num3 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_095d4529c37f4d109f2a65566cdf36aa == 0)
							{
								num3 = 0;
							}
							goto IL_005f;
						}
						goto IL_015e;
						IL_015e:
						current = enumerator.Current;
						num3 = 5;
						goto IL_005f;
						IL_005f:
						while (true)
						{
							switch (num3)
							{
							case 6:
								f_0302_0315.W_03014(current, 0, array, 1, current.Length, f_0302_0315.R_0302_0316);
								num3 = 4;
								continue;
							case 4:
								if (!Device.WriteOutputReportViaInterrupt(array))
								{
									num3 = 1;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_147b19224f51416ba0dbea4e3de8e15d == 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto IL_00d4;
							case 1:
								goto IL_00d4;
							case 3:
								U_0302j.W_03014(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xCC64720 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057), U_0302j.Y_0302k);
								num3 = 1;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_80fd07eaac7d47cea616de92b005f1c3 != 0)
								{
									num3 = 1;
								}
								continue;
							case 5:
								A_0302h.W_03014(10, A_0302h.f_0302i);
								num3 = 6;
								continue;
							case 2:
								goto IL_015e;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37ddfbd9b6e3416cb0041f10c1750410 == 0)
						{
							num4 = 0;
						}
						goto IL_01a0;
					}
					goto IL_01b6;
					IL_01a0:
					switch (num4)
					{
					default:
						goto end_IL_0176;
					case 2:
						break;
					case 0:
						goto end_IL_0176;
					case 1:
						goto end_IL_0176;
					}
					goto IL_01b6;
					IL_01b6:
					n_0302_0303.W_03014(enumerator, n_0302_0303.d_0302_0304);
					num4 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_af8a7dcc1dc649ceb2b23b2857510138 != 0)
					{
						num4 = 1;
					}
					goto IL_01a0;
					end_IL_0176:;
				}
				break;
			case 8:
				if (!d_0302l.W_03014(_writerBw, d_0302l.z_0302m))
				{
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcca45ccf28e43a5a3ac373bef495f4a != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 4:
				array = new byte[Device.Capabilities.OutputReportByteLength];
				num2 = 3;
				continue;
			default:
				if (_cmdQueue.TryDequeue(out result))
				{
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_21e98ef4eaf84e4d8faaaec3a382e068 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 7;
			case 7:
				SendCommand(new ZenLinkCommandData(ZenLinkCommandData.ZenLinkCommand.GetStatus));
				num2 = 5;
				continue;
			case 6:
				return;
			case 2:
				enumerator = result.GetPackets((short)(array.Length - 1)).GetEnumerator();
				num2 = 9;
				continue;
			case 3:
			case 5:
				break;
			}
			if (!_shouldRun)
			{
				break;
			}
			num2 = 8;
		}
	}

	private void ReaderBwOnDoWork(object sender, DoWorkEventArgs e)
	{
		int num = 1;
		int num2 = num;
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 8:
				array2 = new byte[array.Length - 1];
				num2 = 10;
				break;
			case 1:
				array = new byte[Device.Capabilities.InputReportByteLength];
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!_shouldRun)
				{
					num2 = 7;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_5b0f933cb8e74f28a93d65045ddbfd34 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 5;
			case 4:
				HandleResponse(new ZenLinkResponseData(array2));
				num2 = 9;
				break;
			case 10:
				f_0302_0315.W_03014(array, 1, array2, 0, array2.Length, f_0302_0315.R_0302_0316);
				num2 = 4;
				break;
			case 6:
				if (Device.ReadFile(array) == HidDevice.ReadStatus.Success)
				{
					num2 = 8;
					break;
				}
				goto case 9;
			case 7:
				return;
			case 9:
				A_0302h.W_03014(1, A_0302h.f_0302i);
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63437542ddb44ee998bc517d0ffb9193 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				if (d_0302l.W_03014(_readerBw, d_0302l.z_0302m))
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 3:
				return;
			}
		}
	}

	private void HandleResponse(ZenLinkResponseData response)
	{
		int num = 7;
		ZenLinkResponseData.ResponseDataType? lastCmd = default(ZenLinkResponseData.ResponseDataType?);
		ZenLinkResponseData.ResponseDataType dataType = default(ZenLinkResponseData.ResponseDataType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 22:
					_payloadBuf.Clear();
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d769c23d75ca410a8de1c9751309e9f8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 13:
					HandleResponse(response);
					num2 = 9;
					continue;
				case 6:
				case 21:
					lastCmd = _lastCmd;
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d23cf11f77694826a0477b590ab4c340 == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					if (_payloadBuf.Count == _lastPayloadSize)
					{
						num2 = 5;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_50a77b94ed45479dbe8d46063da46bd1 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					return;
				case 15:
					_payloadBuf.AddRange(response.Payload);
					num2 = 16;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee != 0)
					{
						num2 = 18;
					}
					continue;
				case 11:
					goto end_IL_0019;
				case 16:
					if (response.Payload != null)
					{
						num2 = 15;
						continue;
					}
					break;
				case 14:
					if (lastCmd != dataType)
					{
						num2 = 10;
						continue;
					}
					goto case 16;
				case 2:
					_lastCmd = response.DataType;
					num2 = 18;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37a350e2f116426ea9e4894743d91f8b == 0)
					{
						num2 = 20;
					}
					continue;
				case 5:
					response = new ZenLinkResponseData(response.DataType, _payloadBuf.ToArray());
					num2 = 19;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4692ba88c62f41e2a2f6335b85dab018 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_lastCmd = null;
					num2 = 13;
					continue;
				case 1:
					dataType = response.DataType;
					num2 = 14;
					continue;
				case 19:
					_payloadBuf.Clear();
					num2 = 11;
					continue;
				case 7:
					if (_lastCmd.HasValue)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 20:
				{
					byte[] payload = response.Payload;
					_lastPayloadSize = (ushort)((payload != null) ? ((uint)payload.Length) : 0u);
					num2 = 21;
					continue;
				}
				case 17:
					return;
				case 10:
				{
					EventHandler<ZenLinkResponseData> dataReceived = this.DataReceived;
					if (dataReceived == null)
					{
						num2 = 22;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e853f2c5493844b58b596283dba83a5c == 0)
						{
							num2 = 22;
						}
					}
					else
					{
						dataReceived(this, new ZenLinkResponseData(_lastCmd.Value, _payloadBuf.ToArray()));
						num2 = 4;
					}
					continue;
				}
				case 9:
					return;
				case 8:
					break;
				case 12:
					return;
				}
				EventHandler<ZenLinkResponseData> dataReceived2 = this.DataReceived;
				if (dataReceived2 == null)
				{
					num2 = 12;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_c9a32eeeb3884a54899eeffd5f76bd12 == 0)
					{
						num2 = 8;
					}
				}
				else
				{
					dataReceived2(this, response);
					num2 = 3;
				}
				continue;
				end_IL_0019:
				break;
			}
			_lastCmd = null;
			num = 8;
		}
	}

	static ZenLinkHidDevice()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool GVy()
	{
		return mVL == null;
	}

	internal static ZenLinkHidDevice TVf()
	{
		return mVL;
	}
}

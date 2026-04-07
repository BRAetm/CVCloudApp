using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class ZenLinkCommandData
{
	public enum ZenLinkCommand : byte
	{
		GetFwVersion = 1,
		Restart = 3,
		GetStatus = 4,
		SaveSlot = 5,
		LoadSlot = 6,
		IsProVersion = 7
	}

	[CompilerGenerated]
	private sealed class _003CGetPackets_003Ed__11 : IEnumerable<byte[]>, IEnumerable, IEnumerator<byte[]>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private byte[] _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private short packetSize;

		public short _003C_003E3__packetSize;

		public ZenLinkCommandData _003C_003E4__this;

		private int _003CpacketPayloadSize_003E5__2;

		private byte[] _003Cbuf_003E5__3;

		private int _003Ci_003E5__4;

		private static _003CGetPackets_003Ed__11 gNE;

		byte[] IEnumerator<byte[]>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetPackets_003Ed__11(int _003C_003E1__state)
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e10335e8d8834d45acf6fc5563de2057 != 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003El__initialThreadId = i_0302_0313.W_03014(i_0302_0313.q_0302_0314);
					num = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ea170ccda6ba48c3a6de60fbf9a6bd3c != 0)
					{
						num = 0;
					}
					break;
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					num = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ae8a0323f82846e89753ed5b0e72253a == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					_003Cbuf_003E5__3 = null;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ce3991d1f51e4f6e8568482226882025 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					_003C_003E1__state = -2;
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_dfbb6ae721cb49e3bfde5dcf23244f73 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private bool MoveNext()
		{
			int num = 4;
			byte[] array2 = default(byte[]);
			ZenLinkCommandData zenLinkCommandData = default(ZenLinkCommandData);
			byte[] array = default(byte[]);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 15:
						f_0302_0315.W_03014(_003Cbuf_003E5__3, 0, array2, 0, 3, f_0302_0315.R_0302_0316);
						num2 = 21;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcfd4456535940d28c81b9e4f3883ae7 == 0)
						{
							num2 = 19;
						}
						continue;
					case 7:
					case 24:
						if (_003Ci_003E5__4 >= zenLinkCommandData.Payload.Length)
						{
							num2 = 10;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f == 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 11;
					case 8:
						_003Ci_003E5__4 += _003CpacketPayloadSize_003E5__2;
						num2 = 20;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_225ba267fe26452a859963d16a9c6edd == 0)
						{
							num2 = 24;
						}
						continue;
					case 1:
					case 13:
						_003Ci_003E5__4 = 0;
						num2 = 7;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b61530b19e204a7ca50c6928bca4fa26 != 0)
						{
							num2 = 0;
						}
						continue;
					case 22:
						_003C_003E2__current = array2;
						num2 = 12;
						continue;
					default:
						return true;
					case 21:
						break;
					case 6:
						if (zenLinkCommandData.Payload != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fcdc61b3071144baaeced77594757cab == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 23;
					case 18:
						_003C_003E1__state = 1;
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_327d25deb5ac44ada715c7ead1c1918d != 0)
						{
							num2 = 0;
						}
						continue;
					case 23:
						array = new byte[packetSize];
						num2 = 5;
						continue;
					case 5:
						f_0302_0315.W_03014(_003Cbuf_003E5__3, 0, array, 0, 3, f_0302_0315.R_0302_0316);
						num2 = 2;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_8811260fbfd74f03b6a14d879c810aa0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 16:
						_003Cbuf_003E5__3 = zenLinkCommandData.GetBuffer();
						num2 = 6;
						continue;
					case 9:
						_003CpacketPayloadSize_003E5__2 = packetSize - 3;
						num2 = 16;
						continue;
					case 3:
						zenLinkCommandData = _003C_003E4__this;
						num2 = 20;
						continue;
					case 20:
						switch (num3)
						{
						case 1:
							_003C_003E1__state = -1;
							num2 = 19;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d2338023c8544d0e8649719c51cf0dae != 0)
							{
								num2 = 9;
							}
							break;
						default:
							num2 = 3;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b5166be943434fc89f58fe94f4427546 == 0)
							{
								num2 = 17;
							}
							break;
						case 0:
							_003C_003E1__state = -1;
							num2 = 9;
							break;
						case 2:
							_003C_003E1__state = -1;
							num2 = 8;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63437542ddb44ee998bc517d0ffb9193 == 0)
							{
								num2 = 1;
							}
							break;
						}
						continue;
					case 10:
					case 19:
						return false;
					case 17:
						return false;
					case 4:
						num3 = _003C_003E1__state;
						num2 = 3;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a23db8df5e5e4cbc8c565f713e98488e == 0)
						{
							num2 = 3;
						}
						continue;
					case 11:
						array2 = new byte[packetSize];
						num2 = 15;
						continue;
					case 2:
						_003C_003E2__current = array;
						num2 = 4;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_57215dd6f94b429b9470736b4e9904ee != 0)
						{
							num2 = 18;
						}
						continue;
					case 14:
						return true;
					case 12:
						_003C_003E1__state = 2;
						num2 = 14;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_29c1b67922dd42ff81ee0e8b6fa89f38 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				f_0302_0315.W_03014(zenLinkCommandData.Payload, _003Ci_003E5__4, array2, 3, Y_0301r.W_03014(zenLinkCommandData.Payload.Length - _003Ci_003E5__4, _003CpacketPayloadSize_003E5__2, Y_0301r.F_0301s), f_0302_0315.R_0302_0316);
				num = 22;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<byte[]> IEnumerable<byte[]>.GetEnumerator()
		{
			int num = 4;
			int num2 = num;
			_003CGetPackets_003Ed__11 _003CGetPackets_003Ed__ = default(_003CGetPackets_003Ed__11);
			while (true)
			{
				switch (num2)
				{
				case 7:
					return _003CGetPackets_003Ed__;
				case 8:
					_003CGetPackets_003Ed__._003C_003E4__this = _003C_003E4__this;
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_a2d963c26f8c4c829af0c831cff2aa1a == 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					if (_003C_003E1__state == -2)
					{
						num2 = 3;
						break;
					}
					goto default;
				case 2:
					_003C_003E1__state = 0;
					num2 = 6;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_fd11df4b554a4857971cbcb3f50852a1 == 0)
					{
						num2 = 6;
					}
					break;
				case 1:
				case 5:
					_003CGetPackets_003Ed__.packetSize = _003C_003E3__packetSize;
					num2 = 3;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6f65c91937e2415fb1996d0b941086de == 0)
					{
						num2 = 7;
					}
					break;
				default:
					_003CGetPackets_003Ed__ = new _003CGetPackets_003Ed__11(0);
					num2 = 8;
					break;
				case 6:
					_003CGetPackets_003Ed__ = this;
					num2 = 1;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (_003C_003El__initialThreadId == i_0302_0313.W_03014(i_0302_0313.q_0302_0314))
					{
						num2 = 2;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_3432cae45099490abdf855bc991d6c65 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<byte[]>)this).GetEnumerator();
		}

		static _003CGetPackets_003Ed__11()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool qNd()
		{
			return gNE == null;
		}

		internal static _003CGetPackets_003Ed__11 rNz()
		{
			return gNE;
		}
	}

	[CompilerGenerated]
	private byte[] _003CPayload_003Ek__BackingField;

	private static ZenLinkCommandData qNP;

	public ZenLinkCommand Command { get; }

	public byte[] Payload
	{
		[CompilerGenerated]
		get
		{
			return _003CPayload_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CPayload_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_792cdec50f8f497e897fa820072e64b5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ZenLinkCommandData(ZenLinkCommand command)
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		UyPJuK1DPTsW8eYFCR.D_030Fk();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_d6c8dc85820d455cb8ad380962a8c081 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Command = command;
				num = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_110dd0634ced4db38ad8dea1cfc7c098 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void SetPayload(byte[] payload)
	{
		int num = 6;
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
					if (payload.Length <= 4097)
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_e0042670e6f54a62abe3949793fdea70 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 1:
					throw new Exception(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xF3B614 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_37ddfbd9b6e3416cb0041f10c1750410));
				case 2:
					return;
				case 5:
					Payload = Array.Empty<byte>();
					num2 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_0930bb33db454b25a03d860bf5bbc5c2 == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					if (payload == null)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				}
				break;
			}
			Payload = payload;
			num = 2;
		}
	}

	public virtual byte[] GetBuffer()
	{
		int num = 2;
		int num2 = num;
		byte[] result = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 2:
				memoryStream = new MemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							M_0301x.W_03014(binaryWriter, (byte)Command, M_0301x.X_0301y);
							int num4 = 1;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_577024c9b9304ef0a1869ca375c2d204 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 4:
									P_0301v.W_03014(binaryWriter, Payload, P_0301v.F_0301w);
									num4 = 2;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_09ed5e366e9c41e18eb15204e0fe2813 != 0)
									{
										num4 = 0;
									}
									continue;
								default:
									if (Payload != null)
									{
										num4 = 4;
										continue;
									}
									goto case 2;
								case 2:
									result = C_0302_0305.W_03014(memoryStream, C_0302_0305.J_0302_0306);
									num4 = 3;
									continue;
								case 1:
								{
									byte[] payload = Payload;
									u_0302_0311.W_03014(binaryWriter, q_0302_030F.W_03014((payload != null) ? payload.Length : 0, q_0302_030F.j_0302_0310), u_0302_0311.L_0302_0312);
									num4 = 0;
									if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_b927bd6dd7724fcda22eb4eea5c191bf == 0)
									{
										num4 = 0;
									}
									continue;
								}
								case 3:
									break;
								}
								break;
							}
						}
						finally
						{
							int num5;
							if (binaryWriter == null)
							{
								num5 = 2;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63a4f0b908574a1c90af34305f576357 != 0)
								{
									num5 = 2;
								}
								goto IL_01c3;
							}
							goto IL_01d9;
							IL_01c3:
							switch (num5)
							{
							default:
								goto end_IL_0199;
							case 1:
								break;
							case 2:
								goto end_IL_0199;
							case 0:
								goto end_IL_0199;
							}
							goto IL_01d9;
							IL_01d9:
							n_0302_0303.W_03014(binaryWriter, n_0302_0303.d_0302_0304);
							num5 = 0;
							if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_4b85136335df4d5f9682f2572f684b0d == 0)
							{
								num5 = 0;
							}
							goto IL_01c3;
							end_IL_0199:;
						}
						break;
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num6 = 1;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_77fbea5f65494269909d3446604c9187 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								n_0302_0303.W_03014(memoryStream, n_0302_0303.d_0302_0304);
								num6 = 0;
								if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e == 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto default;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetPackets_003Ed__11))]
	public IEnumerable<byte[]> GetPackets(short packetSize)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetPackets_003Ed__11(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__packetSize = packetSize
		};
	}

	static ZenLinkCommandData()
	{
		Kusbq8F7xd8hvTfPmi.nx94wV2kA();
	}

	internal static bool WN3()
	{
		return qNP == null;
	}

	internal static ZenLinkCommandData WNW()
	{
		return qNP;
	}
}

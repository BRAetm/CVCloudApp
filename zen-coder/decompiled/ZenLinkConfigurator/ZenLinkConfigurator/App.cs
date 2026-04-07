using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using K4Aujk4PycyVkeur9W;
using mjldbepFpfgR2sirhk;
using z19o06TNsQe4BE3gP9;

namespace ZenLinkConfigurator;

public class App : Application
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public Process currentProcess;

		private static _003C_003Ec__DisplayClass1_0 PV0;

		public _003C_003Ec__DisplayClass1_0()
		{
			Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
			UyPJuK1DPTsW8eYFCR.D_030Fk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ddbeca16f1644256a4bb2ccb7a64392a != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal bool _003CApplication_Startup_003Eb__0(Process process)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (y_0303_030D.W_03014(process, y_0303_030D.r_0303_030E) != y_0303_030D.W_03014(currentProcess, y_0303_030D.r_0303_030E))
					{
						num2 = 0;
						if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_63a4f0b908574a1c90af34305f576357 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return false;
				default:
					return j_0303_0311.W_03014(A_0303_030F.W_03014(process, A_0303_030F.w_0303_0310), A_0303_030F.W_03014(currentProcess, A_0303_030F.w_0303_0310), StringComparison.Ordinal, j_0303_0311.M_0303_0312);
				}
			}
		}

		static _003C_003Ec__DisplayClass1_0()
		{
			Kusbq8F7xd8hvTfPmi.nx94wV2kA();
		}

		internal static bool DVa()
		{
			return PV0 == null;
		}

		internal static _003C_003Ec__DisplayClass1_0 yVK()
		{
			return PV0;
		}
	}

	private bool _contentLoaded;

	internal static App vVr;

	[DllImport("user32.dll")]
	private static extern int SetForegroundWindow(IntPtr hWnd);

	private void Application_Startup(object sender, StartupEventArgs e)
	{
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		Process process = default(Process);
		while (true)
		{
			switch (num2)
			{
			case 5:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 4;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_1c6866491f454f778c1c1a3ecec1a175 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (process == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ce3991d1f51e4f6e8568482226882025 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 6:
				return;
			case 2:
				SetForegroundWindow(X_0302z.W_03014(process, X_0302z.u_0303_0300));
				num2 = 8;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_bcca45ccf28e43a5a3ac373bef495f4a != 0)
				{
					num2 = 1;
				}
				break;
			default:
				M_0303_0305.W_03014(new MainWindow(), M_0303_0305.j_0303_0306);
				num2 = 6;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_225ba267fe26452a859963d16a9c6edd != 0)
				{
					num2 = 5;
				}
				break;
			case 8:
				n_0303_0303.W_03014(m_0303_0301.W_03014(m_0303_0301.B_0303_0302), n_0303_0303.O_0303_0304);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_269ca61221264cd4849c6d28d9b13400 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				process = K_0302x.W_03014(K_0302x.J_0302y).Where(_003C_003Ec__DisplayClass1_._003CApplication_Startup_003Eb__0).FirstOrDefault();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass1_.currentProcess = m_0302v.W_03014(m_0302v.k_0302w);
				num2 = 7;
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		int num = 4;
		int num2 = num;
		Uri uri = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 3:
				_contentLoaded = true;
				num2 = 2;
				break;
			case 4:
				if (_contentLoaded)
				{
					return;
				}
				num2 = 3;
				break;
			case 2:
				i_0303_0307.W_03014(this, Application_Startup, i_0303_0307.r_0303_0308);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_29c1b67922dd42ff81ee0e8b6fa89f38 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				uri = new Uri(Kusbq8F7xd8hvTfPmi.grulUC7Fy(0xE51D0E3 ^ _003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_2b19b3edd0a34bc6a3ef61c56820737a), UriKind.Relative);
				num2 = 5;
				break;
			case 5:
				F_0303_0309.W_03014(this, uri, F_0303_0309.P_0303_030A);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[STAThread]
	public static void Main()
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
				wBA5NyaIhjsioVwpBE.kLjw4iIsCLsZtxc4lksN0j();
				num2 = 1;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_883dd4d316c34e4387df760dd870112e != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				App app = new App();
				app.InitializeComponent();
				r_0303_030B.W_03014(app, r_0303_030B.Q_0303_030C);
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_6b1b22e30f1540c0876b87d6ad2e8735 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public App()
	{
		Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_ad3c95b1bcd243c6b435f3029315c447 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static App()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Kusbq8F7xd8hvTfPmi.nx94wV2kA();
				num2 = 3;
				break;
			case 1:
				Kusbq8F7xd8hvTfPmi.nx94wV2kA();
				num2 = 0;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_577024c9b9304ef0a1869ca375c2d204 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				wBA5NyaIhjsioVwpBE.kLjw4iIsCLsZtxc4lksN0j();
				num2 = 2;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_01ca8030dce2403abb9e8caf3744483f == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Kusbq8F7xd8hvTfPmi.A2Q917Z8b();
				num2 = 4;
				if (_003CModule_003E_007B4e5f3898_002D0a07_002D455d_002D98fb_002D0591d9786ea3_007D.m_1ba5b6080d2144e9954fdf1929aaafe4.m_353cc89a97134b3dab46f13c2f0d5345 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool SV9()
	{
		return vVr == null;
	}

	internal static App aV4()
	{
		return vVr;
	}
}

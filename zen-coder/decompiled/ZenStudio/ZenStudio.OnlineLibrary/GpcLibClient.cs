using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using mjldbepFpfgR2sirhk;

namespace ZenStudio.OnlineLibrary;

public class GpcLibClient
{
	private readonly object A_0092_008C_0090_008C_008F_008F_0098_008E_0095_008B;

	private static object A_009A_0097_009E_008B_0087_0092_009E_008B_009B_0095;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GpcLibClient()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ListScriptsResponse GetScripts(int? page = null, int? category = null, int? product = null, int? author = null, string sort = null, string searchTerm = null)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DownloadScript(int scriptId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LastUpdateResponse GetLastUpdate()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetCategoriesResponse GetCategories()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GetProductsResponse GetProducts()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string VoteOnScript(int scriptId, bool up)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UploadScript(string script)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserStatsResponse GetUserStats()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetScriptLink(int scriptId)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRegisterLink()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetUnregisterLink()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TResponse MakeGetRequest<TResponse>(string endpoint, List<string> queryParameters, out string responseJson)
	{
		return (TResponse)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private TResponse MakePostRequest<TRequest, TResponse>(TRequest request, string endpoint, out string responseJson)
	{
		return (TResponse)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeviceStatusChanged(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GpcLibClient()
	{
		Kusbq8F7xd8hvTfPmi.pisPySPZ7();
		A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_0095_0095_009B_0097_0095_008F_0093_008E_0089_008A(A_0090_008E_0089_008D_009A_0086_0087_008B_0090_008A.A_009D_0088_008F_0086_0094_008A_0094_008E_0091_008B);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A_008A_0098_009D_008F_008D_009E_008A_008B_0092_0088()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GpcLibClient A_0099_009C_008B_008B_0095_0089_0092_0087_008B_0095()
	{
		return null;
	}
}

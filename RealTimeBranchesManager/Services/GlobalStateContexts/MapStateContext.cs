using System.Collections.Generic;

namespace RealTimeBranchesManager.Services.GlobalStateContexts;

public static class MapStateContext
{
	public static IEnumerable<> Branches { get; set; } = new List<>();
}
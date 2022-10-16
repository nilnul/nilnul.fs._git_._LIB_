using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_
{

	public static class _AzureX
	{

		public static string GetNewestKey()
		{
			return GetKeys().Last();
		}


		public static IEnumerable<string> GetKeys()
		{
			return nilnul.fs.git.Properties.Settings.Default.moduleRemote_azure.Cast<string>();
		}
	}
}

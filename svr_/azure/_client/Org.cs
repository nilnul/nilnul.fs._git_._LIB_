using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure._client
{
	static public class _OrgX
	{
		/// <summary>
		/// note the scheme is https, not "http"
		/// </summary>
		/// <param name="org"></param>
		/// <returns></returns>
		static public string Spear(string org) {
			return $"https://dev.azure.com/{org}";
		}

		static public string Stem(string org) {
			return $"{Spear(org)}/";
		}

		/// <summary>
		/// used in vault for win
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		static public string Rsc_assumeUrl(string url) {
			return $"git:{url}";
		}
		static public string Rsc(string org) {
			return Rsc_assumeUrl(Spear(org));
		}

	}
}

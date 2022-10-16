using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.client.prjs
{
	/// <summary>
	/// recorded or recommended
	/// </summary>
	public class Rec
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="account"></param>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="prjName"></param>
		/// <param name="version"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>

		static public string GenerateUrl(
				string account, string prjName, string version
			)
		{
		/*
		 GET https://{instance}/DefaultCollection/_apis/projects/{project}?api-version={version}[&includeCapabilities={boolean}&includeHistory={boolean}]

		 */
			return $"{nilnul.fs.git.svr_.VisualStudio.GenerateUrl(account, $"projects/{prjName}", version)}";
		}
	}
}

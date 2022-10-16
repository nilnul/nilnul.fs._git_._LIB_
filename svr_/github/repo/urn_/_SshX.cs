using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.repo.urn_
{
	/// <summary>
	/// </summary>
	///
	static public class _SshX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="username">must be proper when in urn</param>
		/// <param name="repo">must be proper when in urn</param>
		/// <returns></returns>
		static public string _Urn_assumesUsrRepo( string username, string repo)
		{
			return $"git@github.com:{username}/{repo}.git";
		}
	}
}

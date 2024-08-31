using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.commits
{
	/// <summary>

	/// </summary>
	public class _VwX
	{
		static public string VwRecentFirst(nilnul.win.prog_.Git git, string _module) {
			return git.runCmd__retResult_throwErr(_module, "log");

		}


		static public string VwRecentFirst(nilnul.win.prog_.Git git, nilnul.fs.Folder _module) {
			return git.runCmd__retResult_throwErr(_module, "log");

		}


		static public string VwRecentFirst( nilnul.fs.Folder _module) {
			return VwRecentFirst(nilnul.win.prog_.Git.StaticInstance, _module); ;

		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.repo.commits
{
	/// <summary>

	/// </summary>
	public class _VwX
	{
		static public string VwRecentFirst(nilnul.win.prog_.Git git, string _module) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(_module, "log");

		}


		static public string VwRecentFirst(nilnul.win.prog_.Git git, nilnul.fs.Folder _module) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(_module, "log");

		}


		static public string VwRecentFirst( nilnul.fs.Folder _module) {
			return VwRecentFirst(nilnul.win.prog_.Git.StaticInstance, _module); ;

		}


	}
}

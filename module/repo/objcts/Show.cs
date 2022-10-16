using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.objcts
{
	static public class _ShowX
	{


		/// <summary>
		/// git-show - Show various types of objects
		/// git show[options] {object}…​
		/// Shows one or more objects(blobs, trees, tags and commits).
		/// </summary>
		/// <returns></returns>
		static public string _Show(nilnul.win.prog_.Git git, string _module, params string[] objcts)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module
				,
				$"show {nilnul.txts.accumulate_.Spaced.Singleton.accumulate(objcts)}"
			);
		}

	}
}

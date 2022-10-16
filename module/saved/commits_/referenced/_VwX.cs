using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.saved.commits_.referenced
{
	/// <summary>
	/// Let's say that I have a graph like this:
	///A---B---C---D(master)
	///     \
	///      \-E---F(HEAD)
	///If I do git log --all --oneline, I will get all six of my commits.
	///But if the graph is
	///A---B---C---D (master, HEAD)
	///     \
	///      \-E---F
	///I will not see E and F.Can I get git to tell me all the commits, including those on branches which are not named?
	/// </summary>
	public class _VwX
	{
		static public string LogAllOneline(string _module, nilnul.win.prog_.Git git = null)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module,

				"log --all --oneline"
			);
		}




	}
}

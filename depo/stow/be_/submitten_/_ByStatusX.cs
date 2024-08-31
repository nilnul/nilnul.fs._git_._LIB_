using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow.be_.submitten_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// 
	static public class _ByStatusX
	{
		static public bool _Be_0depo(string gitTop, nilnul.os.prog_.Git git = null)
		{
			


			var results = nilnul.win.prog_.git.run.result.msg._TrimmedX._Txt_0address_1argument(
				gitTop
				,
				"status --porcelain"
				,git
			);///The option --porcelain gives a machine-parseable output: a list of files, including untracked.The option specification --porcelain=v1 fixes the output version of the machine-parseable output, so that your script will never break under a future git update. As of my writing, you can check https://git-scm.com/docs/git-status for information about other version options, like --porcelain=v2. You may be able to do more advanced scripting with versions beyond v1.The 2>/dev/null is there so that git status will fail silently, if at all (i.e., if run outside of a git repository).
				///the command git status ... will return exit code 128 if it is not inside a git repository. You can check explicitly for this exit code if you want a third option besides "uncommitted changes" or "no uncommitted changes".
				///, somebody might use "2>", where 2 means standard error.
			if (results == "")
			{
				return true;
			}
			else
			{
				return false;
			}


		}
		static public bool Be(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_0depo(gitTop.en.address.en.ToString(), git);



		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.pier.be_._dry_.by_
{
	/// <summary>
	/// index is same as current; nothing is added to index;
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// 
	[Obsolete(nameof(by_._ByDryRunX) + " is preferred, as this would throw when head is unborn;",true)]
	static public class _ByDiffIndexX
	{
		static public bool _Be_0depo(string gitTop, nilnul.win.prog_.Git git = null)
		{
			var result = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(    //note: errCode is 1.
				gitTop,
				"diff-index --quiet --cached HEAD --"		//exit code is not 0 if head_.branch is unborn // fatal: bad revision HEAD

				, git
			);

			if (result.exitCode == 0)
			{
				return true;
			}



			/// no exception is thrown;

			return false;



		}
		static public bool Be(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_0depo(gitTop.en.address.en.ToString(), git);



		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.tracked_.revised_
{
	static class _ByDiffX
	{
		///git-scm.com/docs/git-diff
		///
		/// git diff [<options>] [--] [<path>…]
		///This form is to view the changes you made relative to the index (staging area for the next commit). In other words, the differences are what you could tell Git to further add to the index but you still haven’t. You can stage these changes by using git-add[1].
		///
		///
		/// <summary>
		/// </summary>
		/// <remarks>
		///
		/// </remarks>
		/// <param name="depo"></param>
		/// <returns></returns>
		static public os.proc_.finished._result.CodMsgErr Get4documents(string depo){
			return nilnul.os.prog_.git.run_.exit._ResultX.Result_ofAddress(
				depo
				,
				$"diff --name-only --diff-filter=MAD" //  default filter is MAD

			);
		}
	}
}

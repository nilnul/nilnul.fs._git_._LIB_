using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.history
{
	/// <summary>
	/// git log {someBranch}
	/// note when branch is <see cref="module.repo.refer_.branch.be_.Noreified"/>
	/// </summary>
	/// <see cref="repo.branch.history._VwX"/>
	internal class _VwX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_depo"></param>
		/// <param name="snap"></param>
		/// <param name="git"></param>
		/// <returns>
		/// eg:
		///		e6a0004 (tag: bak240605-werk-batch-end, tag: bak247-werk-batch-5, nilnulBak_all/bak2406-werk-o, Gitlab/bak27-werk-o, Azure/bak2407-werk-o, Amazon/bak240607-werk-o, bak240697-werk-o) batch5 commited
		///		3c000e(tag: bak2407-werk-batch-4) batch4 commited
		///		9c0008(tag: bak2407-werk-batch-3) batch3 commited
		///	, newest first.
		/// </returns>
		static public string _Msg_0depo_1snap(string _depo, string snap, nilnul.os.prog_.Git git = null)
		{
			return nilnul.win.prog_.git.run.result._MsgX._Msg_0address(
				_depo,
				$"log --oneline {snap}"
				,
				git
			);
		}


	}
}

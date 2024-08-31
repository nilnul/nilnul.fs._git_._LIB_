using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.history._vw_.by_
{
	/// <summary>
	/// </summary>
	/// <see cref="repo.branch.history._VwX"/>
	internal class _RevListX
	{

		
		static public string _Msg_0depo_1snap(string _depo, string snap, nilnul.os.prog_.Git git = null)
		{
			return nilnul.win.prog_.git.run.result._MsgX._Msg_0address(
				_depo,
				$"rev-list {snap}"
				,
				git
			);
		}


	}
}

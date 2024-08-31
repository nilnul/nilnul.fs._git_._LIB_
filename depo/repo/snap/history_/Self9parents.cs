using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.history_
{
	static public class _Self9parentsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// 
		/// <param name="_depo"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<string> _Self9parents_0depo(string _depo, nilnul.os.prog_.Git git=null) {

			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.win.prog_.git.run.result._MsgX._Msg_0address(_depo,
					" rev-list --parents -1 @"      // "-n 1" can be "-1"; also note, the '@' cannot be omitted
					, git
				)
			);

		}
	}
}

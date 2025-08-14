using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap_.current.parents
{
	static public class _VwX
	{
		/// <summary>
		/// 
		/// </summary>
		/// 
		/// <param name="_depo"></param>
		/// <param name="git"></param>
		/// <returns>
		/// parents that are separated by space; self will not be shown
		/// </returns>
		static public IEnumerable<string> _Parents_0depo(string _depo, nilnul.os.prog_.Git git = null)
		{

			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.win.prog_.git.run.result._MsgX._Msg_0address(_depo,
					"log --pretty=%P -1"      // "-n 1" can be "-1"
					, git
				)
			);

		}
	}
}

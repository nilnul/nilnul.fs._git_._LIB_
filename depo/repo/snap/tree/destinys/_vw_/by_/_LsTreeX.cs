using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.tree.destinys._vw_.by_
{
	static public class _LsTreeX
		

	{
		/// <summary>
		/// </summary>
		/// <param name="_depo"></param>
		/// <param name="git"></param>
		/// <returns>
		/// </returns>
		/// <exception cref="">
		/// </exception>
		static public string _Msg_0depo(string _depo, string snap, nilnul.os.prog_.Git git = null)
		{

			return nilnul.win.prog_.git.run.result._MsgX._Msg_0address(
				_depo
				,
				$"ls-tree -r --name-only {snap}"	/// " --" can be appended
				,
				git
			);

		}

		static public IEnumerable<string> _Paths_0depo(string _depo,string snap, nilnul.os.prog_.Git git = null)
		{

			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty( _Msg_0depo(_depo,snap,git));

		}



		

	}
}

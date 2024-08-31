using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.branchs
{
	static public class _VwX
	{
		static public IEnumerable<string> _Nonblanks_0depo_1snap(
			string _depo
			,
			string snap
			,
			nilnul.os.prog_.Git git=null
		) {
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				_Msg_0depo_1snap(
					_depo,
					snap
					, git
				)
			);
		}

		static public IEnumerable<string> _Nonblanks_0depo_1branch(
			string _depo
			,
			string snap
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				_Msg_0depo_1branch(
					_depo,
					snap
					, git
				)
			);
		}


		/// <summary>
		/// 
		/// </summary>
		/// 
		/// <param name="_depo"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string _Msg_0depo_1snap(string _depo, string snap, nilnul.os.prog_.Git git=null) {
			return nilnul.win.prog_.git.run.result._MsgX._Msg_0address(
				_depo
				,
				$"branch --points-at {snap}"     
				, git
			);
		}

		static public string _Msg_0depo_1branch(string _depo, string snap, nilnul.os.prog_.Git git = null)
		{
			return _Msg_0depo_1snap(_depo, $"refs/heads/{snap}", git);
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap_.current.tree.destinys._vw_.by_
{
	public class LsTree
		:
		nilnul.os.prog_.git.run_.end.result._msg_.AssumeDepoI

	{
		/// <summary>
		/// </summary>
		/// <param name="_depo"></param>
		/// <param name="git"></param>
		/// <returns>
		/// the hash only
		/// </returns>
		/// <exception cref="">
		/// </exception>
		public string _msg_0depo(string _depo, nilnul.os.prog_.Git git = null)
		{

			return nilnul.win.prog_.git.run.result._MsgX._Msg_0address(
				_depo
				,
				"ls-tree -r --name-only @"	/// " --" can be appended
				,
				git
			);

		}

		public IEnumerable<string> _paths_0depo(string _depo, nilnul.os.prog_.Git git = null)
		{

			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty( _msg_0depo(_depo,git));

		}



		static public LsTree Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<LsTree>.Unison;
			}
		}

	}
}

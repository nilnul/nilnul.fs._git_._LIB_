using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snaps._vw_.by_
{
	/// <summary>
	/// The output is given in reverse chronological order by default.
	/// </summary>
	static public class _LogX
	{

		/// <summary>
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="snapId"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string _Msg_0depo(
			string depo,  nilnul.os.prog_.Git git = default
		)
		{
			return nilnul.fs.git.repo.snaps._vw_.by_._LogX._Msg_0module(
				depo,git
			);

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,

				//$"log --pretty=%H"
				$"log --all --pretty=%H"
						/// --all: Pretend as if all the refs in refs/, along with HEAD, are listed on the command line as <commit>.
						///  danglings are not included

				, git
			);
		}

		static public string[] _Hashs_0depo(
			string depo, nilnul.os.prog_.Git git = default
		)
		{

			return (_Msg_0depo(depo,git)??"").Split(
				[.. nilnul.character.set_.ascii_.Blank.IN_TXT], StringSplitOptions.RemoveEmptyEntries
			);
		}



	}
}

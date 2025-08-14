using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snaps_.mem._vw_.by_
{
	/// <summary>
	/// The output is given in reverse chronological order by default.
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _LogX
	{

		/// <summary>
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string _Msg_0depo_1snap(
			string depo,  nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,

				$"log --reflog --pretty=%H"
						/// --reflog: Pretend as if all objects mentioned by reflogs are listed on the command line as <commit>.

				, git
			);
		}

		static public string[] _Hashs_0depo_1snap(
			string depo, nilnul.os.prog_.Git git = default
		)
		{

			return (_Msg_0depo_1snap(depo,git)??"").Split(
				[.. nilnul.character.set_.ascii_.Blank.IN_TXT], StringSplitOptions.RemoveEmptyEntries
			);
		}



	}
}

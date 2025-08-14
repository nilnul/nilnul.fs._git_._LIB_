using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snaps_.mem._vw_.by_.log_
{
	/// <summary>
	/// The output is given in reverse chronological order by default.
	/// </summary>
	/// <remarks>
	///-g
	///--walk-reflogs
	///Instead of walking the commit ancestry chain, walk reflog entries from the most recent one to older ones. 
	/// </remarks>
	static public class _RecentX
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

				$"log -g --pretty=%H"
						/// 
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.parents._vw_.by_
{
	static public class _LogX
	{

		/// <summary>
		/// all parents, spaced separated
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="snapId"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string _Msg_0depo_1snap(
			string depo, string snapId, nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,

				$"log --pretty=%P -1 {snapId}"

				, git
			);
		}

		static public IEnumerable<string> _Hashs_0depo_1snap(
			string depo, string snapId, nilnul.os.prog_.Git git = default
		)
		{

			return (_Msg_0depo_1snap(depo,snapId,git)??"").Split(
				[.. nilnul.character.set_.ascii_.Blank.IN_TXT], StringSplitOptions.RemoveEmptyEntries
			);
		}



	}
}

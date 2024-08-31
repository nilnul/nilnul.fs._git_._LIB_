using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.parents._vw_.by_
{
	internal class _RevParseX
	{

		/// <summary>
		/// all parents
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
				depo, $"rev-parse ${snapId}^@", git
			);
		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.head.snaps._vw_.by_
{
	internal class _LogX
	{
		static public string  _Msg_0depo(
			string depo, nilnul.os.prog_.Git git = default
		)
		{
			/// git-scm.com/docs/git-log
			/// 
			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					depo,

					$"log"		///List commits that are reachable

					, git
			);
		}

	}
}

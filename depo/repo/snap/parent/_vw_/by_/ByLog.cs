using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.parent._vw_.by_
{
	static public class _ByLogX
	{
		static public string _Msg_0depo_1snap(
	string depo
			,
	string snap
			,
	nilnul.os.prog_.Git git = default
)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,
				$"log --pretty=%P -1 {snap}"
					/// where -1 can be: -n 1
				,
				git
			);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.snaps_.dangling
{
	internal class _DeleteX
	{
		static public (string reflog,string gc) _Msg_0depo(
			string depo, nilnul.os.prog_.Git git = default
		)
		{
			/// https://stackoverflow.com/questions/18514659/what-is-a-dangling-commit-and-a-blob-in-a-git-repository-and-where-do-they-come

			return (
				nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					depo,

					$"reflog expire --expire=now --all"		/// dereference the dangling snaps from reflog

					, git
				)
				,
				nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					depo,

					$"gc --prune=now"		/// force gc to prune all rather than those older than 14days=2weeks;

					, git
				)

			);
		}

	}
}

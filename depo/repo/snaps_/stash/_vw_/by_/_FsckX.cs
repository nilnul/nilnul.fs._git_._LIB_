using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snaps_.stash._vw_.by_
{
	/// <summary>
	/// 
	/// </summary>
	
	internal class _FsckX
	{
		static public string _Msg_0depo(
	string depo, nilnul.os.prog_.Git git = default
)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,

				$"fsck --no-reflog"   /*
				                       https://stackoverflow.com/questions/21903972/search-for-string-in-dangling-commits-in-git

				git fsck is the right way for accessing dangling commits.

				                       */

				, git
			);
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snaps_.min._vw_.by_
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
		/// <returns>
		/// each line is a revision;
		/// </returns>
		static public string _Msg_0depo(
			string depo,  nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,

				$"log --all --max-parents=0 --pretty=%H"    /// --all: Pretend as if all the refs in refs/, along with HEAD, are listed on the command line as <commit>.
															/// it doesn't mean it takes all commits;
															/// /// if you have a commit that can't be reached by --all, then it's a matter of time before gc pulls the carpet out from under that commit - because as far as it can tell, such commits are unused.
															/// Most git commands make the same assumption log does: that useful commits are reachable from refs (branches, tags, etc.), so even if you disabled gc to avoid such commits being deleted (not a good idea) you would still be forever trying to convince git to work with them.
															/// To find lost (dangling) commits, use fsck (assuming they haven't already been cleaned up by gc):
															/// git fsck --lost-found
															/// 

				, git
			);
		}

		static public string[] _Hashs_0depo_1snap(
			string depo, nilnul.os.prog_.Git git = default
		)
		{

			return (_Msg_0depo(depo,git)??"").Split(
				[.. nilnul.character.set_.ascii_.Blank.IN_TXT], StringSplitOptions.RemoveEmptyEntries
			);
		}



	}
}

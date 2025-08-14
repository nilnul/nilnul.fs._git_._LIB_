using Microsoft.VisualStudio.Services.Common.CommandLine;

namespace nilnul.fs.git.depo.repo.snaps._vw_.by_
{
	/// Basicly git git log is the same like git rev-list, but with a special format. in both git log and git rev-list you can specify the format.
	/// 
	/// <summary>
	/// output from git rev-list is (by default at least) just the commit hashes;
	/// vs: git log, this must be provided with a revision as arg.
	/// </summary>
	static public class _RevListX
	{

		/// <summary>
		/// List[s] commits that are reachable by following the parent links from the given commit(s)
		/// ,Thus it does not list commits that are on another branch and it does not list commits that are not reachable by any branch (perhaps they were created because of some rebase and/or detached-head actions).
		/// </summary>
		/// <param name="depo">the address of the depo.</param>
		/// <param name="git"></param>
		/// <returns>
		/// eg: 
		///c594..6b batch5 commited
		///30b8..32 batch4 commited
		/// ,that is, the id, and the msg;
		/// </returns>
		static public string _Msg_0depo(
			string depo,  nilnul.os.prog_.Git git = default
		) {

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo, $"rev-list --all --pretty=oneline", git
			);
		}
	}


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.snaps._vw_.by_
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="fs.git.depo.repo.snaps._vw_.by_._LogX"/>
	static public class _LogX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="git"></param>
		/// <returns>
		/// By default, the commits are shown in reverse chronological order.
		/// </returns>
		static public string  _Msg_0module(
			string depo, nilnul.os.prog_.Git git = default
		)
		{
			/// git-scm.com/docs/git-log
			/// List commits that are reachable
			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
					depo,

					$"log {
						"--pretty=%H"		/// H:full hash; P: parents separated by space
					} {
						"--all"	///--all: Pretend as if all the refs in refs/, along with HEAD, are listed on the command line as <commit>.
					} {
						"--tags"	///Pretend as if all the refs in refs/tags are listed on the command line as <commit> (the snaps listed on the command line are taken as the starting point of the history to be listed).
					} {
						"--remotes"		///Pretend as if all the refs in refs/remotes are listed on the command line as <commit>.
					} {
						"--reflog"		///Pretend as if all objects mentioned by reflogs are listed on the command line as <commit>
					}"	

					, git
			);
		}

	}
}

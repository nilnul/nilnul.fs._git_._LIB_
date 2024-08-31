using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo
{
	/// <summary>
	/// as depo is the main worktree at ../ of the repo, here the worktree is linked worktree outside the depo like "../hotfix/"
	/// </summary>
	/// <remarks>
	/// Each linked worktree has a private sub-directory in the repository’s $GIT_DIR/worktrees directory.
	/// The private sub-directory’s name is usually the base name of the linked worktree’s path, possibly appended with a number to make it unique.
	/// </remarks>
	/// Within a linked worktree, $GIT_DIR is set to point to this private directory (e.g. /path/main/.git/worktrees/test-next in the example) and $GIT_COMMON_DIR is set to point back to the main worktree’s $GIT_DIR (e.g. /path/main/.git). These settings are made in a .git file located at the top directory of the linked worktree.
	internal class IWorktreeLinked
	{
	}

	static public class _WorktreeLinkedX
	{
		/// git-scm.com/docs/git-worktree
		/// <summary>
		/// To instead work on an existing branch in a new worktree, use git worktree add <path> <branch>. 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="path"></param>
		/// <param name="commitish">
		///<commit-ish> may be a bare "-", which is synonymous with @{-1}
		/// </param>
		static void _Add_0depo_1path_2branch(string depo, string path, string commitish) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(depo,"worktree","add", path, commitish);
		}

		static void _Detached_0depo_1path(string depo, string path) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(depo,"worktree","add", "-d", path);
		}


		static void _Lock_0worktree(string _worktree) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(_worktree,"worktree","lock");
		}
		static void _UnLock_0worktree(string _worktree) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(_worktree,"worktree","unlock");
		}

		static void _Lock_0worktree_1reason(string _worktree,string reason) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(_worktree,"worktree","lock", "-reason", reason);
		}

		/// <summary>
		/// git worktree repair command, however, can reestablish the connection with linked worktrees if you move the main worktree manually.
		/// </summary>
		/// <param name="_worktree"></param>
		static void _Repair_0worktree(string _worktree) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(_worktree,"worktree","repair");
		}

		/// <summary>
		/// Remove a worktree. Only clean worktrees (no untracked files and no modification in tracked files) can be removed. 
		/// </summary>
		/// <param name="_worktree"></param>
		static void _Remove_0worktree(string _worktree) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(_worktree,"worktree","remove");
		}

		/// <summary>
		/// Unclean worktrees or ones with submodules can be removed with --force. The main worktree cannot be removed.
		/// </summary>
		/// <param name="_worktree"></param>
		static void _Remove8force_0worktree(string _worktree) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(_worktree,"worktree","remove", "-force");
		}


	}

	static public class _WorktreesX
	{

		///If a working tree is deleted without using git worktree remove, then its associated administrative files, which reside in the repository (see "DETAILS" below), will eventually be removed automatically (see gc.worktreePruneExpire in git-config[1]), or you can run git worktree prune in the main or any linked worktree to clean up any stale administrative files.
		///
		static void _Prune_0worktree(string worktree) {
			nilnul.os.prog_.git._RunX._Vod_dirOfAddress_ofArgs(worktree,"worktree","prune");
		}

		static os.proc_.finished._result.CodMsgErr _List_0worktree(string worktree) {
			return nilnul.os.prog_.git.run_.exit._ResultX._Result_0address_1args(worktree,"worktree","list");
		}


	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.git._run.arg_._sub
{
	/// subcmd
	/// <summary>
	/// Run merge conflict resolution tools to resolve merge conflicts
	/// </summary>
	/// <remarks>
	/// about 145 of them;
	/// </remarks>
	public enum Li_
	{
		Add
			,
		/// <summary>
		/// apply mailbox
		/// </summary>
		Am
			,
		Archive
			,
		Bisect
			,
		Branch
			,
		CatFile
			,
		/// <summary>
		/// Copy files from the index to the working tree
		/// </summary>
		[Description("checkout-index")]
		CheckoutIndex
			,
		Clone
			,
		Commit
			,
		CommitTree
			,
		Config
			,
		CountObjects
			,
		Describe
			,
		Diff,
		DiffTree
			,
		Fsck
			,
		Fetch
			,
		FormatPatch
			,
		Gc
,
		/// <summary>
		/// $ git grep "foo()"	    # search working directory for "foo()"
		/// $ git grep v2.6.15 "foo()"  # search old tree for "foo()"
		/// </summary>
		Grep
			,
		HashObject
			,
		Help
			,
		Init
			,

		InstaWeb
			,
		Log
			,
		LsFiles
			,
		LsTree
			,
		/// <summary>
		/// eg:
		///		git maintainance start
		/// </summary>
		Maintainance
			,
		MkTag
			,
		Merge
			,
		MergeBase
			,
		MergeIndex
			,
		/// <summary>
		/// meregetool
		/// </summary>
		///
		[Description("mergetool")]
		MergeTool
			,
		NameRev
			,
		Prune
			,
		Pull
			,
		Push
			,
		ReadTree
			,
		Remote
			,
		Repack
			,
		Reset
			,
		/// <summary>
		/// eg:
		///		If you’ve messed up the working tree, but haven’t yet committed your mistake, you can return the entire working tree to the last committed state with
		///		$ git restore --staged --worktree :/
		/// </summary>
		Restore
			,
		Revert
			,
		RevList
			,
		/// git-scm.com/docs/git-rev-parse
		/// <summary>
		/// Many Git porcelainish commands take a mixture of flags (i.e. parameters that begin with a dash -) and parameters meant for the underlying git rev-list command they use internally and flags and parameters for the other commands they use downstream of git rev-list. This command is used to distinguish between them.
		/// </summary>
		RevParse
			,
		Rm
			,
		Show
			,
		ShowBranch
			,
		ShowRef
			,
		Stash
			,
		Status
			,
		Switch
			,
		Submodule
			,
		Tag
			,
		UpdateIndex
			,
		/// <summary>
		/// $ git --bare update-server-info
		/// </summary>
		UpdateServerInfo
			,
		VerifyTag

			,
		WriteTree
	}
}

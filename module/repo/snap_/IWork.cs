using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap_
{
	/// <summary>
	/// the imaginery snap(commit) if we take the workspace (excluding ignored ) as next commit.
	/// note: there might be difference between staged and workspace. We only consider workspace here; the staged will be neglected.
	/// </summary>
	/// <remarks>
	/// we can dry-run the commit.
	/// according to git doc:
	/// --------------------
	/// --dry-run
	/// Do not create a commit, but show a list of paths that are to be committed, paths with local changes that will be left uncommitted and paths that are untracked.
	/// --------------------
	/// </remarks>
	interface IWork
	{
	}
}

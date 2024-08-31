using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.dossier_
{
	/// <summary>
	/// git add --intent-to-add (or git add -N).
	///
	/// Record only the fact that the path will be added later. An entry for the path is placed in the index with no content. This is useful for, among other things, showing the unstaged content of such files with git diff and committing them with git commit -a
	/// </summary>
	/// <remarks>
	///don't use it to include the new files in a stash (I just tried, won't work currently)
	///
	/// diff-files: treat "intend-to-add" files as "not-in-index"
	/// </remarks>
	///
	/// git add -N works is to make a special index entry
	///
	/// 
	/// stackoverflow.com/questions/72931533/git-stash-seems-not-to-work-when-new-files-have-been-added
	/// 
	/// Don't use git add -N.
	/// The way git add -N works is to make a special index entry, that Git is supposed to know what to do with.For a long time, it was badly broken.A number of corner cases have been fixed over the last five or so years, and it now works for a lot of cases—but it's still broken for git stash, even in Git 2.37:
	///
	internal class Intend
	{
	}
}

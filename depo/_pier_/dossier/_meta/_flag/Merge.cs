using nilnul.txt.stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier_.dossier._meta._flag
{
	/// <summary>
	/// If you git add, then a stage 0 is added to the index for the path, and Git will know that the conflict has been marked as solved.
	/// </summary>
	/// <remarks>
	///it's usually zero;
	/// During a merge, the index can store multiple versions of a single file (called "stages"). The third column in the git ls-files output:
	/// 100644 63c918c667fa005ff12ad89437f2fdc80926e21c 0   .gitignore
	///
	/// ,is the stage number, and will take on values other than 0 for files with merge conflicts. if it's resolved, then 0 is set.
	///
	/// Git can now write, into the index / staging-area, all three versions, using the stage number
	///$ git ls-files --stage
	///100644 56a073d1bdc0307f357a407b50bee4324bb55873 0       README
	///100644 4bbeee7f6db44d17c38abd3031fcb84a97192459 1       file
	///100644 66c11225b90f34558b8ace8c5eb203ec47b55c38 2       file
	///100644 7502e0fdd9ef370b5eee377ceeee4b1605d88336 3       file
	///
	/// During a merge, stage 1 is the common ancestor, stage 2 is the target branch’s version (typically the current branch), and stage 3 is the version from the branch which is being merged.
	/// </remarks>
	/// The different stage numbers are not really used during git-add command. The stage number (slots), useful during merge conflict handling.
	///
	///
	///
	///github.com/git/git/blob/3a2ebaebc76b302629a5789696d67a0ce2c4378e/Documentation/gitformat-index.txt#L86-L92
	///
	///  this value is retrieved from 'flags':
	///		
	/// alias:
	///		mode


	internal enum Merge
	{
		Regular
			,

		/// <summary>
		/// 
		/// </summary>
		Base
			,
		Ours
			,
		Theirs
	}
}

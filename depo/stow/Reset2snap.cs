using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow
{
	/// <summary>
	/// # Decide to scrap the feature and remove the associated commits
	/// git reset --hard HEAD~2
	/// </summary>
	/// <remarks>
	/// copy files from commits, through the index, to the work-tree;
	///
	/// It's somewhat difficult to copy a file out of a commit without first writing it into the index. Thus, the commands that copy from commits—including git reset—first overwrite the index version.
	/// </remarks>
	internal class Reset2snap
	{
		
	}
}

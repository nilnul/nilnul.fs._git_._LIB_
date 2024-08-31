using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier.file._blob
{
	///https://github.com/git/git/blob/3a2ebaebc76b302629a5789696d67a0ce2c4378e/Documentation/gitformat-index.txt#L86-L92
	/// During a merge, the index can store multiple versions of a single file (called "stages"). The third column in the git ls-files output:
	/// 100644 63c918c667fa005ff12ad89437f2fdc80926e21c 0   .gitignore
	///
	/// ,is the stage number, and will take on values other than 0 for files with merge conflicts. if it's resolved, then 0 is set.
	/// 
	/// <summary>
	/// 
	/// </summary>
	/// 
	/// <seealso cref="_pier_.dossier.IMeta"/>
	internal class ITemplate
	{
	}
}

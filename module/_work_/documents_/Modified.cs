using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.files_
{
	/*git ls-files --modified*/
	/// <summary>
	/// modified
	///		excluding
	///			deleted
	///			inserted
	/// </summary>
	class Modified
	{
		/// git diff-files  --diff-filter=M --name-only
		/// only the modified files, but not the new files or the deletions.

	}
}

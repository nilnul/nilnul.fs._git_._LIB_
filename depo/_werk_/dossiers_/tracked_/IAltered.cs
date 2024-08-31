using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.tracked_
{
	/// <summary>
	/// modified
	///		excluding
	///			deleted
	///			inserted
	/// </summary>
	/// alias:
	///		tempered
	class IAltered:IRevised
	{
		/// git diff-files  --diff-filter=M --name-only
		/// only the modified files, but not the new files or the deletions.

	}
}

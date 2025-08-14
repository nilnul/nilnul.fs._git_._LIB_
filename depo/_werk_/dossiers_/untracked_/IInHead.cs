using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.untracked_
{
	/// <summary>
	/// note files in current revision are inherently staged; 
	/// to exclude a file , even if it's tracked:
	///		git rm --cached <file>
	/// ;
	/// 
	/// if a file is in head, but not in index, then it's not tracked.
	/// 
	/// </summary>
	/// alias:
	///		minded
	///		held
	class IInHead
    {
    }
}

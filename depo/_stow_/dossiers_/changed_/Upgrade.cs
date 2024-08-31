using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.dossiers_.changed_
{
	/// <summary>
	/// modified0new, no removed.
	/// </summary>
	internal class Upgrade
	{
		///use git ls-files -m -d -t (which can be compressed to git ls-files -mdt) and interpret its output. (t means newbie)
		///, where in the result:
		///		C means modified(changed)
		///		R means removed
		///		H means newbie
		///Note some document maybe appears twice, once as Removed, and once as Changed (modified). It is just a small matter of programming to have the R status override the C status when you read the results.

	}
}

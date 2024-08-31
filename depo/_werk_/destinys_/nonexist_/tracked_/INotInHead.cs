using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.xpn_.nonexist_.tracked_
{
	/// <summary>
	/// it's not in head, in pier, but not in werk.
	/// this would be shown in "git status" as:
	///		added.
	///		,
	///		unstaged deleted.
	///	,that is shown twice;
	/// </summary>
	internal class INotInHead:ITracked
	{
	}

}

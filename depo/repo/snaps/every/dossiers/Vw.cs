using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snaps.every.dossiers
{
	/// <summary>
	/// git log --pretty=format: --name-only --diff-filter=A | sort -u
	///		,where "| sort -u" might not work on windows.
	///		,where --diff-filter=A option (list only added files). without that, the cmd would fail if you have enabled rename detection and have renames in history. use --name-only instead of --name-status. This ignores files that were created by copying an already existing file, so adding it may not always be what you want.
	///		
	/// </summary>
	internal class Vw
	{
	}
}

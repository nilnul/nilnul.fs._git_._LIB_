using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.destinations_
{
	/// <summary>
	/// if it's ignored by settings.
	/// even it's in index;
	/// </summary>
	/// <remarks>
	/// <see cref="werk._BakX"/>, where index is reset, hence only the settings, not the index, would take effect.
	/// </remarks>
	/// alias:
	///		ignoredBySettings
	///		Incandidate
	///		unlist
	///		uncandidate
	///		ignored
	///			,vs include: as <see cref="_werk_.dossiers_.IIncluded"/> means indexed with untracked1unignored.
	///		unrecommend
	///		
	internal class IgnoredBySettings
	{
		/*
		 to debug,
		git check-ignore -v --no-index {some path}
		 */

		
	}
}

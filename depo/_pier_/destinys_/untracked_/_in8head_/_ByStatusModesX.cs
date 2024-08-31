using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.depo._pier_.destinys_.untracked_._in8head_
{
	/// <summary>
	/// assume the depo is not in unmerged status. If it's in unmerged status, see the documentation at: git-scm.com/docs/git-status;
	/// </summary>
	/// <remarks>
	/// no matter the file is deleted from werk or not;
	/// </remarks>
	///
	//[Obsolete("git think some is renamed if a new file with the same content shows up, and wont list it as deleted mode;")]
	static public class _ByStatusModesX
	{
		public static IEnumerable<string> GetDossiers(string depo, os.prog_.Git git = null)
		{
			return GetDossiers(
				fs.git.depo.dossiers.vw_._StatusPorcelainX._GetModes_0depo(depo,git)
			);
		}

		static public IEnumerable<string> GetDossiers(
				
IEnumerable<(string mode, string dossier)> enumerable
			)
		{
			/*
D  deletedStaged
 D unstagedDeleted

,# note the space in the beginning; space means unmodified;

git-scm.com/docs/git-status
			
XY ORIG_PATH -> PATH

where ORIG_PATH is where the renamed/copied contents came from. ORIG_PATH is only shown when the entry is renamed or copied. The fields (including the ->) are separated from each other by a single space. If a filename contains whitespace or other nonprintable characters
			 */
			return enumerable.Where(t=>t.mode=="D ").Select(t=>t.dossier);
		}
	}
}

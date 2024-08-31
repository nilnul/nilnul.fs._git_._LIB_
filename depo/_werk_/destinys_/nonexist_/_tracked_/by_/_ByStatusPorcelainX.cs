using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.depo._werk_.destinys_.nonexist_._tracked_.by_
{
	/// <summary>
	/// assume the depo is not in unmerged status. If it's in unmerged status, see the documentation at: git-scm.com/docs/git-status;
	/// </summary>
	static  class _ByStatusPorcelainX
	{
		static public IEnumerable<string> GetDossiers(
				string depo
				,
				nilnul.os.prog_.Git git = null
			)
		{
			/*
D  deletedStaged
 D unstagedDeleted

,# note the space in the beginning; space means unmodified;


			
XY ORIG_PATH -> PATH

where ORIG_PATH is where the renamed/copied contents came from. ORIG_PATH is only shown when the entry is renamed or copied. The fields (including the ->) are separated from each other by a single space. If a filename contains whitespace or other nonprintable characters
			 */
			return nilnul.txt.split_._LineX.Line_removeWhite(
				nilnul.os.prog_.git.run_.exit.result._MsgX.OfAddress(
					depo
					,
					"status --porcelain=v1" 

					,
					git
				)
			).Select(
				l=> (mode: l.Substring(0,2), dossier: l.Substring(3))
			).Where(t=>t.mode==" D").Select(t=>t.dossier);
		}
	}
}

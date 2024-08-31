using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.depo._pier_.destinys_.untracked_.in8head_._in8werk_
{
	/// <summary>
	///  for a single dossier, if it's deleted from stage, but not from werk, it will show twice in "git status":
	///  first show up as "D "
	///  then show up as "??"
	///		
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _ByStatusX
	{
		static public IEnumerable<string> GetDossiers(
				string depo
				,
				nilnul.os.prog_.Git git = null
			)
		{

			var modes = fs.git.depo.dossiers.vw_._StatusPorcelainX._GetModes_0depo(
				depo, git
			);

			return destinys_.untracked_._in8head_._ByStatusModesX.GetDossiers(modes).Except(
_Untracked(modes)
			);


		}

		private static IEnumerable<string> _Untracked(IEnumerable<(string mode, string dossier)> modes) => modes.Where(t => t.mode == "??").Select(t => t.dossier);
	}
}

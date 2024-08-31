using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.depo._stow_.dossiers_
{
	/// <summary>
	/// add all werk to pier, except <see cref="_werk_.dossiers_.untracked_.IIgnored"/>.
	/// 
	/// for <see cref="_werk_.destinys_.INonexistInWerk"/>, remove it from stage;
	/// for <see cref="_werk_.dossiers_.IUntracked"/>, add it.
	/// </summary>
	/// <remarks>
	/// the stow merged is taken as a commin commit;
	/// </remarks>
	/// for <see cref="_werk_.dossiers_.ITracked"/>, update it using werk.
	/// 
	interface IAddAllAsComingCommit { }

	/// <summary>
	/// as a commit by submitting all werk.
	/// excluding:
	///		tracked but missing (deleted from werk); <see cref="_werk_.destinys_.tracked_.revised_.IDropped"/>
	///	including:
	///		<see cref="_werk_.dossiers_.untracked_.IUnignored"/>
	/// </summary>
	/// <remarks>
	/// add -all
	/// </remarks>
	static public class _AddAllX
	{
		static public IEnumerable<string> _GetDossiers_0depo(
				string depo
				,
				nilnul.os.prog_.Git git = null
			)
		{

			return 	_werk_.destinys_.tracked_.revised_._AlteredX._Destinies_0depo
				(depo, git).Union(
				_werk_.dossiers_.untracked_._UnignoredX._GetDossiers_0depo(depo,git)
			);

		}



	}
}

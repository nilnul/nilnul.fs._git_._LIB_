using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.depo._werk_.destinys_.tracked_.revised_
{
	

	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _AlteredX
	{
		static public IEnumerable<string> _Destinies_0depo(
				string depo
				,
				nilnul.os.prog_.Git git = null
			)
		{

			return nilnul.fs.git.depo._pier_._DossiersX._GetDossiers_0depo(depo, git).Except(
				_werk_.destinys_.nonexist_._TrackedX._Destinies_0depo
				(depo, git)
			);

		}



	}
}

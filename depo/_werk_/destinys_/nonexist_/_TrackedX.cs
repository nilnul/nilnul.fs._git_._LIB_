using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.destinys_.nonexist_
{
	/// <summary>
	/// the file is in stage.
	/// 
	/// git ls-files -d
	/// , Show files with an unstaged deletion --- nonexist in werk, but still in pier;
	/// </summary>
	/// <remarks>
	/// <see cref="_pier_.dossiers_.xpn_.beyond_.INotInWerk"/><see cref="depo._stow_.destinys_.INotInWerk"/>
	/// </remarks>
	/// to delete from both werk and pier, <see cref="depo._stow_.destinys_.no8pier_.INotInWerk"/>
	/// alias:
	///		missing
	///		Still8pier
	static public class _TrackedX
	{
		static public IEnumerable<string> _Destinies_0depo(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var arg = "ls-files -d"; /// Show files with an unstaged deletion -nonexist in werk, but still in pier;

			var result = nilnul.win.prog_.git.run._ResultX1._Result_0address_1argument(
				module
				,
				 arg  /* git config --global core.quotePath false
												must be set
										*/
				, git
			);
			if (result.beErr)
			{
				throw new Exception(
					$"git arg @ {module}:cod: {result.exitCode}; err: {result.err}."

				);
			}

			return (
				nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(result.msg)
			);
		}

	
	}
}

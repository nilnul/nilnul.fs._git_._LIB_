using System.Collections.Generic;
using System;

namespace nilnul.fs.git.depo._werk_.destinys_.tracked_
{

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		ruin
	///		downplay
	///		downgrade
	///		dehance
	///		
	static public class _RedactedVsPierX
	{
		static public IEnumerable<string> _GetDosssiers_0depo(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var arg = "ls-files -m"; 
			var result = nilnul.win.prog_.git.run._ResultX1._Result_assumeAddress(
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

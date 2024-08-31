using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_.upsert_
{
	/// <summary>
	/// todo:
	///		issue: for sub folder, returned is the directory, not inner files.
	/// </summary>
	static public class _ByStatusX
	{
		/// git add --ignore-removal -n .
		///		note: the "." at the end;
		///		and we must run this at the base, not a sub directory, of the module


		/// git add -An
		///		seems leaking files already added.
		///	git diff HEAD --name-only
		///		doesnot work either, if there is no commit or the head is empty
		///	
		///
		static public IEnumerable<string> Upsert(
			string module
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var arg = "status --porcelain";
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

			return divisions(
				nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(result.msg)
			);

			IEnumerable<string> divisions(IEnumerable<string> lines)
			{
				foreach (var l in lines)
				{
					var index = l.IndexOfAny(new[] { '\t', ' ' });
					var split = l.TrimStart().Split(new[] { '\t', ' ' }, 2);
					if (split.Length == 2)
					{
						var firstTrimmed = split[0].Trim();
						if (
							!(
								split[0].EndsWith("D")
								&&
								(firstTrimmed != "UD") ///unmerged, deleted by them
						 )

						)
						{
							yield return
								split[1].Trim('\'', '\"', '\t', ' ')
							;

						}
					}
				}
			};







		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.division.be_._ignored.rules_.dotnet0nilnul.ovFile_
{
	/// <summary>
	/// patch the ignore file to reflect dotnet ignores
	/// </summary>
	static public class _PatchX
	{
		static public void OfSpear(string spear)
		{
			//those already in files
			var allLines = System.IO.File.ReadAllLines(spear);

			///those not exist
			var lines2patch = _Dotnet0nilnulX.MergeWithDotNetIgnore().Where(
					x => nilnul.obj.str_.enumerable.be_._NoneX.None(
					allLines
					,
					already => nilnul.txt.eq_.TrimEnd.Singleton.Equals(already, x)
				)
			);

			if (lines2patch.Any())
			{
				System.IO.File.AppendAllLines(
					spear
					,
					new[] { "" }
				);

				System.IO.File.AppendAllLines(
					spear
					,
					lines2patch

				);
			}
		}
	}
}
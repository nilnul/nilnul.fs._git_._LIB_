using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.div._ignore._doc.file.upd_
{
	/// <summary>
	/// patch the ignore file to reflect dotnet ignores
	/// </summary>
	static public class _DotNetX
	{
		static public void OfSpear(string spear)
		{
			var allLines = System.IO.File.ReadAllLines(spear);

			var lines2patch = _module.work._ignore.div.doc.patch_._nilnul._RulesX.Enumerate().Where(
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_.div.doc.file.patch_.dotnet
{
	/// <summary>
	/// patch the ignore file to reflect dotnet ignores
	/// </summary>
	/// 
	[Obsolete()]
	static public class _EnsureRulesX
	{
		static public void OfSpear(string spear)
		{
			//those already in files
			var allLines = System.IO.File.ReadAllLines(spear);

			///those not exist
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
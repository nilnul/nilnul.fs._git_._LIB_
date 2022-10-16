using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.fs.git.module._ignore_.div.doc._patch
{
	/// <summary>
	/// patch the ignore file to reflect dotnet ignores
	/// </summary>
	static public class _FileX
	{
		static public void _OfSpear(nilnul.fs.FileI spear1, IEnumerable<string> lines)
		{
			var spear = spear1.ToString();
			var allLines = System.IO.File.ReadAllLines(spear);

			var lines2patch = lines.Where(
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
		static public void _OfSpear(string spear, IEnumerable<string> lines)
		{
			_OfSpear(new nilnul.fs.File(spear),lines);
		}


		static public void _OfFolder(nilnul.fs.FolderI spear, IEnumerable<string> lines)
		{
			_OfSpear(
				_ignore_.div._DocX.Spear(spear)
				,
				
				lines
			);
		}

		public static void _OfSpear(SpearI spearI1, IEnumerable<string> lines)
		{
			 _OfSpear(new nilnul.fs.File(spearI1),lines);
		}
	}
}
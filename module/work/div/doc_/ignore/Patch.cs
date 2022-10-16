using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.div.doc_.ignore
{
	/// <summary>
	/// patch the ignore file
	/// </summary>
	static public class _PatchX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="spear"></param>
		/// <param name="lines"></param>
		/// todo: lines be split into blocks, each block is led by a few of comment lines
		static public void _OfSpear(
			string spear
			,
			 IEnumerable<string> lines
		)
		{
			var allLines = System.IO.File.ReadAllLines(spear);

			var lines2patch = _module._ignore.rules._DehydrateX.Dehydrate(lines).Where(
				x => nilnul.txt.set.be_.has._NoX.Be_ofEqTrim(allLines, x) 
			);

			if (lines2patch.Any())
			{
				System.IO.File.AppendAllLines(
					spear
					,
					new[] { "" }.Concat(lines2patch)
				);

				
			}
		}

		static public void OfSpear(
			nilnul.fs.address_.SpearI spear
			,
			 IEnumerable<string> lines
		)
		{
			_OfSpear(
				spear.ToString()
				,
				lines
			);

		}

		static public void OfFolderAddress(
			string folder
			,
			 IEnumerable<string> lines
		)
		{
			OfSpear(
				div.doc_.Ignore.Spear_ofFolderAddress(folder)
				,
				lines
			);
		}

		public static void Vod(FolderI en, IEnumerable<string> lines)
		{
			
			OfSpear(
				div.doc_.Ignore.Spear(en)
				,
				lines
			);

		}
	}
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.directories_.noDotLed_
{
	/// <summary>
	/// </summary>
	static public class _NontopX
	{

		static public IEnumerable<DirectoryInfo> _Infos_assumeNontop(
			DirectoryInfo workDirectoryUnLink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var item 
				in
				fs.folder_.giT_.work_.nontop.dirs_.notDotLed_._NontopX._Infos_assumeNontop(
					workDirectoryUnLink, git
				)
			)
			{
				foreach (var item1 in divs_.noDotLed_._NontopX._Infos_assumeNontop(item))
				{
					yield return item1;
				}

			} 
		}

		static public IEnumerable<DirectoryInfo> _Infos_addressAssumeNontop(
			string workDirectoryUnLink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Infos_assumeNontop(
				new DirectoryInfo(workDirectoryUnLink)
				,
				git
			);
		}
	}
}

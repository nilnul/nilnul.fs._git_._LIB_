using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.fs.folder.doc_.git_.ignore
{
	/// <summary>
	/// patch the ignore file to reflect dotnet ignores
	/// </summary>
	static public class _PatchX
	{
		

		static public void _OfFolder(nilnul.fs.FolderI spear, IEnumerable<string> lines)
		{
			nilnul.fs.file_.git_.ignore._PatchX._OfSpear(
				doc_.git_._IgnoreX.Spear(spear)
				,
				
				lines
			);
		}

		
	}
}
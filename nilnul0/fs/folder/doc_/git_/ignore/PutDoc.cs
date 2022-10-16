using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.doc_.git_.ignore
{
	/// <summary>
	/// create the file if not exist;
	/// patch the ignore file to reflect dotnet ignores if exists
	/// </summary>
	static public class _PutX
	{
		
		static public void Exe(nilnul.fs.FolderI top, IEnumerable<string> lines)
		{
			if (nilnul.fs.folder.doc_.git_.ignore.be_.ExistsDoc.Be(top))
			{
				_PatchX._OfFolder(top, lines);

			}
			else
			{
				ignore._EnforceX.Make(top, lines);
			}
			

		}


	}
}

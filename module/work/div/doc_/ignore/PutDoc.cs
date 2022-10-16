using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_.div
{
	/// <summary>
	/// create the file if not exist;
	/// patch the ignore file to reflect dotnet ignores if exists
	/// </summary>
	static public class PutDocX
	{
		
		static public void Exe(nilnul.fs.FolderI top, IEnumerable<string> lines)
		{
			if (nilnul.fs.git.module._ignore_.div.be_.ExistsDoc.Be(top))
			{
				nilnul.fs.git.module._ignore_.div.doc._patch._FileX._OfFolder(top, lines);

			}
			else
			{
				div.doc._create._ForceX.Force(top, lines);
			}
			

		}

	}
}

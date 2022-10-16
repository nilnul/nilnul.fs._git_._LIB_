using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.workspace_
{
	/// <summary>
	/// folder that is descedents of a work, but is not the root of a work
	/// </summary>
	public class Descendents
	{
		

		static public bool IsRoot(string dir)
		{

			return nilnul.dev.git.Folder.IsRoot (dir);


		}

	}
}

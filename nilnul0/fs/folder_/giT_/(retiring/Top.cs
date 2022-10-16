using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;

namespace nilnul.fs.folder_.git_
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete()]
	public class Top
		:
		nilnul.fs.folder_.git_.work_.Top

	{

		public Top(string module) : this(
			 Folder.FroAddress(module)
		)
		{
		}

		public Top(Folder folder) : base(folder)
		{
		}

		public Top(FolderI folder) : base(folder)
		{
		}

		
	}
}

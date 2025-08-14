using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;

namespace nilnul.fs.folder_
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.fs.folder_.git_.Top))]
	public class GitTop
		:
		nilnul.fs.folder.be_.gitTop.vow.Ed

	{

		public GitTop(string module):this(
			 Folder.CreateFroAddress(module)
		)
		{
		}

		public GitTop(Folder folder) : base(folder)
		{
		}


		public nilnul.fs.Folder folder
		{
			get { return ed; }
		}
	}
}

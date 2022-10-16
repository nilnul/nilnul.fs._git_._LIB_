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
	public class Top1
		:
		nilnul.fs.folder.be_.git_.work_.top.vow.En1

	{
		[Obsolete()]
		public Top1(string module) : this(
			 Folder1.CreateFroAddress(module)
		)
		{
		}

		public Top1(Folder1 folder) : base(folder)
		{
		}

		public Top1(FolderI folder) : base(folder)
		{
		}

		static public Top1 FroAddress(string address) {
			return new Top1( Folder1.CreateFroAddress(address));
		}

		public nilnul.fs.FolderI folder
		{
			get { return en; }
		}
	}
}

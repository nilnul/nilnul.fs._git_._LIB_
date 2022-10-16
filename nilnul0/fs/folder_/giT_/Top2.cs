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
	[Obsolete(nameof(work_.Top))]
	public class Top
		:
		nilnul.fs.folder.be_.git_.work_.top.vow.En
	{
		public Top(Folder folder) : base(folder)
		{
		}

		public Top(FolderI folder) : base(folder)
		{
		}

		public Top(nilnul.fs.address_.ShieldI shield)
			:
			this(
				new nilnul.fs.Folder(shield)
			)
		{
		}

		static public Top FroAddress(string address) {
			return new Top(nilnul.fs.Folder.FroAddress(address));
		}

		public nilnul.fs.FolderI folder
		{
			get { return en; }
		}
	}
}

using System;
using nilnul.fs.address_;

namespace nilnul.fs.folder_.git_.work_
{
	/// <summary>
	/// </summary>
	/// 
	public class Top
		:
		nilnul.fs.folder.be_.git_.work_.top.vow.En

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

		public Top(ShieldI address):this(new Folder(address))
		{
		}

		public nilnul.fs.FolderI folder => en;
	}
}

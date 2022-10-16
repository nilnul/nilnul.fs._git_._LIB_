using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_
{
	/// <summary>
	/// a plain fold is a fold not in any module
	/// </summary>
	public class None
		:
		nilnul.fs.folder.be_.git_.none.vow.En
	{


		public None(string module) : this(
			 Folder.FroAddress(module)
		)
		{
		}

		public None(Folder folder) : base(folder)
		{
		}

		public None(FolderI folder) : base(folder)
		{
		}
	}
}

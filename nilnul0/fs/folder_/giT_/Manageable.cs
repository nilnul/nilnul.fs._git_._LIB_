using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_
{
	/// <summary>
	/// </summary>
	public class Manageable
		:
		nilnul.fs.folder.be_.giT_.manable.vow.Ee
	{

		public Manageable(string module) : this(
			 Folder.FroAddress(module)
		)
		{
		}

		public Manageable(Folder folder) : base(folder)
		{
		}

		public Manageable(FolderI folder) : base(folder)
		{
		}

		public Manageable(ShieldI folder_nonLink):this(new Folder(folder_nonLink))
		{

		}
	}
}

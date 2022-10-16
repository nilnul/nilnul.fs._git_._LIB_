using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_.work_.top.vow
{
	public class En
		: nilnul.fs.folder.vow.En2<Vow1>
	{
		public En(FolderI val) : base(val)
		{
		}

		public static En OfAddress(string a)
		{
			return new En(
				nilnul.fs.Folder.FroAddress(a)
			);
			//throw new NotImplementedException();
		}
	}
}

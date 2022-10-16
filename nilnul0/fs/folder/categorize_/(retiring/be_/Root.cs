using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.location_;

namespace nilnul.fs.git.folder.be_
{
	[Obsolete(nameof(nilnul.fs.folder.be_.GitTop))]
	public class Root:BeOfFsFolderI
	{
		

		public bool be(location_.Folder obj)
		{
			return be_.Work.Singleton.be(obj) && module.div.be_.Root.Singleton._be(obj)
			;
			//throw new NotImplementedException();
		}

		public bool be(string obj) {
			return be(new location_.Folder(obj));
		}

		static public readonly Root Singleton = SingletonByDefault<Root>.Instance;

	}
}

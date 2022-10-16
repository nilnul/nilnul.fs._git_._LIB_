using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git
{
	/// <summary>
	/// folder that is inside the ".git" folder ; bar or nonbare
	/// </summary>
	/// 
	[Obsolete()]
	public  class Repo
	{
		private Folder _folder;

		public Folder folder
		{
			get { return _folder; }
			//set { _folder = value; }
		}

		public Repo(dev.git.workspace.category_.RootOrNot rootOrNot)
		{
			dev.git.workspace.category_.rootOrNot.be.assert_.Root.Singleton.assert(rootOrNot);
			_folder = rootOrNot.workspace.folder;

		}

	}
}

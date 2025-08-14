using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// work or repo
	/// </summary>
	/// 
	[Obsolete()]
	public class GitTop : nilnul.fs.folder.BeI
	{
		public bool be(Folder obj)
		{
			return be_.Work.Singleton.be(obj) && folder_.work.be_.Root.Singleton.be(
				new folder_.Workspace(
					obj
				)
			);
			//throw new NotImplementedException();
		}

		public bool be(string obj)
		{
			return be(new nilnul.fs.Folder(obj));
		}

		static public GitTop Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<GitTop>.Instance;
			}
		}


	}
}

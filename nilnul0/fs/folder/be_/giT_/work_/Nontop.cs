using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_.work_
{
	/// <summary>
	/// work or repo
	/// </summary>
	public class Nontop : nilnul.fs.folder.BeI
	{
		

		public bool be(string obj)
		{
			return be( nilnul.fs.Folder.FroAddress(obj));
		}

		public bool be(FolderI obj)
		{
			return be_.git_.Work.Singleton.be(obj) 
				&& 
				folder_.git_.work.be_.Nontop.Singleton.be(
				new folder_.git_.Work(
					obj
				)
			);
		}


		static public Nontop Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nontop>.Instance;
			}
		}



	}
}

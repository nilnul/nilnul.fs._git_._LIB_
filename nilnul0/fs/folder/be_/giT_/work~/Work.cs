using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_
{
	/// <summary>
	/// git_.work
	/// </summary>
	/// 
	[Obsolete(nameof(git_.Work))]
	public class Work : nilnul.fs.folder.BeI
	{
		public bool be(Folder obj)
		{
			return categorize_.plainWorkRepo.io.be_.Work.Singleton.be(
				categorize_.plainWorkRepo.Io.Eval(obj)
			);
			//throw new NotImplementedException();
		}


		static public Work Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Work>.Instance;
			}
		}



	}
}

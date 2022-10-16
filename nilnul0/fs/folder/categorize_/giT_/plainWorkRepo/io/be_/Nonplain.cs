using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_.plainWorkRepo.io.be_
{
	/// <summary>
	/// work or repo
	/// </summary>
	public class Nonplain :  BeI1
	{
		public bool be(Io obj)
		{
			return obj.type == _plainWorkRepo.Ret.Work || obj.type == _plainWorkRepo.Ret.Repo;

			//throw new NotImplementedException();
		}

		//public bool be(Io obj)
		//{
		//	return obj.type == _plainWorkRepo.Ret.Work || obj.type == _plainWorkRepo.Ret.Repo;

		//	//throw new NotImplementedException();
		//}

		static public Nonplain Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonplain>.Instance;
			}
		}





	}
}

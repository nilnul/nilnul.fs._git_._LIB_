using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_.plainWorkRepo.io.be_
{
	/// <summary>
	/// bare or nonbare
	/// </summary>
	public class Repo : BeI1
	{
		public bool be(Io obj)
		{
			return obj.type == _plainWorkRepo.Ret.Repo;

			//throw new NotImplementedException();
		}





		static public Repo Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Repo>.Instance;
			}
		}



	}
}

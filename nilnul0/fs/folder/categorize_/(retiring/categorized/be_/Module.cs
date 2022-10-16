using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorized.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Module : BeI
	{
		public bool be(Categorized obj)
		{
			return obj.type == _categorized.PlainWorkRepo.Work || obj.type== _categorized.PlainWorkRepo.Repo;

			//throw new NotImplementedException();
		}


		static public readonly Module Singleton = SingletonByDefault<Module>.Instance;



	}
}

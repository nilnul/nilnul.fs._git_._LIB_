using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorize_.plainWorkRepo.call_.ofLocation.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Module : BeI
	{
		public bool be(call_.OfLocation obj)
		{
			return obj.type == _plainWorkRepo.Ret.Work || obj.type== _plainWorkRepo.Ret.Repo;

			//throw new NotImplementedException();
		}


		static public readonly Module Singleton = SingletonByDefault<Module>.Instance;



	}
}

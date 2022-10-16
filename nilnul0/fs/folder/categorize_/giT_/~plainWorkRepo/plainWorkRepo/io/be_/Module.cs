using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.plainWorkRepo.io.be_
{
	/// <summary>
	/// work or repo
	/// </summary>
	public class Module : BeI
	{
		public bool be(Io obj)
		{
			return obj.type == _plainWorkRepo.Ret.Work || obj.type== _plainWorkRepo.Ret.Repo;

			//throw new NotImplementedException();
		}


		static public Module Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Module>.Instance;
			}
		}





	}
}

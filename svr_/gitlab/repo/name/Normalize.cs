using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.repo.name
{
	[Obsolete()]
	public class Normalize
		: nilnul.txt.ConvertI
	{
		public string eval(string arg)
		{
			return _NameX.Encode(arg);
			//return arg.Replace('.', '-');

			//throw new NotImplementedException();
		}


		static public Normalize Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Normalize>.Instance;
			}
		}


	}
}

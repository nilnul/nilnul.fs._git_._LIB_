using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svR_.github.urn.be_
{
	public class Ssh
		: nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return obj.StartsWith("git@github.com:");
			//throw new NotImplementedException();
		}

		static public Ssh Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Ssh>.Instance;
			}
		}

	}
}

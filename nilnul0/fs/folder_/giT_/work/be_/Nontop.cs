using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_.work.be_
{
	
	public class Nontop : BeI1
	{
		
		public bool be(Work obj, nilnul.win.prog_.Git git = null)
		{
			return !be_.Top.Singleton.be(obj, git);
			//throw new NotImplementedException();
		}


		public bool be_ofAddress(string obj, nilnul.win.prog_.Git git = null)
		{
			return be(Work.FroAddress(obj),git);
			//throw new NotImplementedException();
		}

		public bool be_ofShield(string obj, nilnul.win.prog_.Git git = null)
		{
			return be(Work.FroShield(obj),git);
			//throw new NotImplementedException();
		}
		public bool be(nilnul.fs.FolderI obj, nilnul.win.prog_.Git git = null)
		{
			return be(new Work(obj),git);
			//throw new NotImplementedException();
		}

		public bool be(Work obj)
		{
					return be(obj,null);
		}

		static public Nontop Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Nontop>.Instance;
			}
		}

	}
}
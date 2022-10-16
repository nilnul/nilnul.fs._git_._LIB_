using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_.work.be_
{
	public class Top : /*BeI,*/BeI1
	{
		//public bool be(Work obj)
		//{
		//	return be(obj,null);
		//	//throw new NotImplementedException();
		//}
		//public bool be(Work obj, nilnul.win.prog_.Git git = null)
		//{
		//	return nilnul.fs.address_.shield_.address.Eq.Singleton.Equals(obj.getRoot().ToString(), obj.en.address.en.ToString());
		//	//throw new NotImplementedException();
		//}
		public bool be(Work obj, nilnul.win.prog_.Git git = null)
		{
			return _TopX.Be(obj,git);
			//throw new NotImplementedException();
		}

		public bool be(nilnul.fs.address_.ShieldI obj, nilnul.win.prog_.Git git = null)
		{
			return be(new nilnul.fs.Folder(obj), git);
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

		static public Top Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Top>.Instance;
			}
		}

	}
}
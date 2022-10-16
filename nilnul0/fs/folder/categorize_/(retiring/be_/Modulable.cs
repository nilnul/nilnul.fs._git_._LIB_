using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.location_;

namespace nilnul.fs.git.folder.be_
{
	/// <summary>
	/// can create a new module here. the new module may be a submodule or a module that is sub of none.
	/// </summary>
	public class Modulable:BeI
	{

		static public bool Be(string folder)
		{
			return Be( new nilnul.fs.Folder(folder));
		}

		static public bool Be(location_.Folder location)
		{
			var category = nilnul.fs.git.folder.categorize_.PlainWorkRepo._Eval(location);
			switch (category)
			{
				case categorize_._plainWorkRepo.Ret.Plain:
					return true;
					break;
				case categorize_._plainWorkRepo.Ret.Work:
					return nilnul.fs.git.module.div.be_.NonRoot._Be(location);
					break;
				case categorize_._plainWorkRepo.Ret.Repo:
					return false;
					break;
				default:
					throw new UnexpectedReachException();
					break;
			}
		}

		public bool be(location_.Folder obj)
		{
			return Be(obj);
			throw new NotImplementedException();
		}
	}
}

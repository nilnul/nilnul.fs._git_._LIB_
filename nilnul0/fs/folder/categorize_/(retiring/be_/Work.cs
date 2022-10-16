using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.location_;

namespace nilnul.fs.git.folder.be_
{
	public class Work
		:nilnul.fs.git.folder.BeOfFsFolderI
	{


		static public bool Eval(string folder)
		{
			return _categorized.plainWorkRepo.be_.Module.Singleton.be(
				nilnul.fs.git.folder.Categorized._Eval(folder)
			);
		}

		public bool be(location_.Folder obj)
		{

			return categorized.be_.Work1.Singleton.be(
				nilnul.fs.git.folder.CategorizedOfLocation.Eval(obj)
			);
			//throw new NotImplementedException();
		}


		static public readonly Work Singleton = SingletonByDefault<Work>.Instance;

	}
}

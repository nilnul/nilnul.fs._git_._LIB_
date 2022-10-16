using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.location_;

namespace nilnul.fs.git.module.div.be_
{
	public class Root//:nilnul.fs.location_.folder.BeI
	{
		static public bool _IsRoot(string _workspaceSubDir)
		{
			return nilnul.fs.address.Eq.Singleton.Equals(
				nilnul.fs.folder_.git_.work._RtX.__Address_ofAddress(

				_workspaceSubDir),
				(_workspaceSubDir)
			);
		}



		public bool _be(Folder obj)
		{
			return nilnul.fs.address_.folder.Eq.Singleton.Equals(

				Module.GetRoot(obj),
				(obj.avowed)
			);

			//throw new NotImplementedException();
		}




		static public readonly Root Singleton = SingletonByDefault<Root>.Instance;

	}
}

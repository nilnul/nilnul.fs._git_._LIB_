using nilnul.dev.git.module;
using nilnul.fs;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.commit
{
	static public class _AddAllFirstX
	{
		static public void __Void_ofAddress( string module,string commitMsg, nilnul.win.prog_.Git git=null) {

			fs.git.module.index.add_._AllX.Exe_ofAddress( module, git);

			index._CommitX.Exe( module, commitMsg, git);
		}

		public static void _Void(Folder folderGit, string v, Git git=null)
		{

			__Void_ofAddress(folderGit.ToString(),  v,git);
			//throw new NotImplementedException();
		}

		
	}
}

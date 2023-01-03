using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.head.move_.to_
{
	static public class _RefX
	{
		
		static public void ToRef( 
			nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.repo._reference.Name refer, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(gitTop, "symbolic-ref HEAD " + refer, git);

		}

		public static void ToRef(Top gitTop, string v, Git git=null)
		{
			ToRef(gitTop, new fs.git.repo._reference.Name(v),git);
		}

		static public void ToRef_ofAddress( string module, string _ref, nilnul.win.prog_.Git git=null)
		{
			ToRef(
				 nilnul.fs.folder_.git_.Top.FroAddress(module)
				,
				new git.repo._reference.Name(_ref)
				,
				git
			);

		}


		public static void ToRef(nilnul.fs.FolderI gitTop, string v, nilnul.win.prog_.Git git)
		{
			ToRef(new fs.folder_.git_.Top(gitTop) , new git.repo._reference.Name(v), git);
		}
	}
}

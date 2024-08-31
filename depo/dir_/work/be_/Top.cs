using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.dir_.work.be_
{
	/// <summary>
	/// a child of a module top that's not repo. 
	/// aka: non-repo
	/// including:
	///		* sub folder of a parent module
	///		* root of a submodule
	///	excluding:
	///		* .git 
	/// </summary>
	static public class _TopX
	{
		public static bool _Be(ShieldI top, DirI child, win.prog_.Git git)
		{

			return nilnul.fs.folder_.git_.work.be_.Top.Singleton.be(
				new nilnul.fs.folder_.ParentDir(
					top
					,
					child
				)
				,
				git
				);

		}

		public static bool _Be_assumeWork(FolderI en, Git git)
		{
			return nilnul.fs.folder_.git_.work.be_._TopX._Be( en,git);

			

		}

		static public bool _Be(string _location_of__child_notRepo, nilnul.win.prog_.Git git=null)
		{
			return nilnul.fs.folder_.git_.work.be_._TopX._Be( _location_of__child_notRepo,git);
		}

		static public bool _Be(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs._address.DirI workDir
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return _Be(module.top.en.address.en,workDir,git);
		}

	}


}

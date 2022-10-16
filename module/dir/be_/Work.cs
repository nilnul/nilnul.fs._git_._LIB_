using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.dir.be_
{
	/// <summary>
	/// </summary>
	static public class _WorkX
	{

		static public bool _Be( 
			nilnul.fs.FolderI _moduleDir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.fs.folder.be_.git_.Work.Singleton.be(
				_moduleDir
				,
				git
			);
		}
		static public bool _Be( 
			nilnul.fs.Folder _moduleDir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Be((FolderI)_moduleDir,git);
		}


		static public bool _Be_ofAddress( 
			string _moduleDir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Be( nilnul.fs.address_.Shield.FroAddress(_moduleDir),git);
		}
		public static bool _Be_assumeModuleDir(DirectoryInfo child, Git git)
		{

			return _Be_ofAddress(child.FullName,git);
		}

		public static bool _Be(Shield shield, Git git)
		{
			return _Be(new nilnul.fs.Folder(shield),git);
		}

		static public bool Be( 
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs._address.DirI dir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Be(
				new nilnul.fs.folder_.ParentDir(
					module.top.folder.address.en
					,
					dir
				)
				//,git
			);
		}


		static public bool _Be( 
			nilnul.fs.address_.ShieldI _module
			,
			nilnul.fs._address.DirI dir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Be( new nilnul.fs.git.Module(_module),dir,git);
		}



	}
}

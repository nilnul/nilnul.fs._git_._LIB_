using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.div.be_
{
	/// <summary>
	/// </summary>
	static public class _WorkX
	{

		static public bool _Be( 
			nilnul.fs.FolderI _moduleDiv
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.fs.folder.be_.git_.Work.Singleton.be(
				_moduleDiv
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

		static public bool _Be( 
			nilnul.fs.address_.ShieldI _moduleDir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Be((FolderI)_moduleDir,git);
		}

		static public bool Be( 
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs._address.DivI dir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Be(

				 new nilnul.fs.address_.shield_.BaseDiv(
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
			nilnul.fs._address.DivI div
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Be( new nilnul.fs.git.Module(_module),div,git);
		}



	}
}

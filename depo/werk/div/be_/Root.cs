using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;

namespace nilnul.fs.git.module.work.div.be_
{
	/// <summary>
	///  a folder that's inside a module, but is not inside ".git".
	///  including:
	///		root of a module
	///		subfolder of root that's not .git
	///		descendant folder of a module that's not inside .git.
	///			this must be a descendant folder of a root.
	///		subfolder of root that's the root of another moder
	///	excluding:
	///		.git or its descendants.
	///		
	/// </summary>
	/// 
	public class Root
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_locationOf_folderInModule_NotRepo"></param>
		/// <returns></returns>
		static public bool _IsRoot( string _locationOf_folderInModule_NotRepo, nilnul.win.prog_.Git git=null)
		{
			return nilnul.fs.address_.shield.EqX.Eq_ofAddress( 
				nilnul.fs.address_.shield.Eq.Singleton
				,

				_RootX.Exe_ofAddress(_locationOf_folderInModule_NotRepo, git)
				
				, 
				nilnul.fs.address_.Shield.FroAddress(_locationOf_folderInModule_NotRepo)
			);

		}

		

	}
}

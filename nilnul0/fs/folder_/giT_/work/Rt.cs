using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;

namespace nilnul.fs.folder_.git_.work
{
	/// <summary>
	/// 
	/// the input must be:
	///		a folder that's inside a module, but is not inside ".git".
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
	static public class _RtX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_insideWork_notRepo"></param>
		/// <param name="git"></param>
		/// <returns>the physical, not the symlink, path.
		/// if the "HEAD" file in "/.git" is empty, the returned is the Rt of super module. (If your HEAD file is somehow emptied or corrupted, you’ll start seeing the exact same error, even though you are currently in a correctly initialized repository. If you HEAD file is missing, you'll see the error too.)
		/// </returns>
		static public string __Address_ofAddress(
			string _insideWork_notRepo
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return 
				nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
					_insideWork_notRepo
					,
					"rev-parse --show-toplevel"
				)  ///note: in ".git", whether it's bare or not, the following command returns empty. in submodule, the command returns the root of the submodule.
			;
		}


		static public string _Address(
			nilnul.fs.FolderI _insideWork_notRepo
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return 
				__Address_ofAddress( _insideWork_notRepo.ToString(),git)
			;
		}
		static public nilnul.fs.address_.ShieldI _Shield(
			nilnul.fs.FolderI _insideWork_notRepo
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return 
				nilnul.fs.address_.Shield.FroAddress(_Address(_insideWork_notRepo,git))
			;
		}

		static public nilnul.fs.address_.ShieldI Shield(
		   nilnul.fs.address_.ShieldI _insideWork_notRepo
		   ,
		   nilnul.win.prog_.Git git = null
	   )
		{
			return
				nilnul.fs.address_.Shield.FroAddress(
					Address(_insideWork_notRepo, git)
			);
		}
		static public nilnul.fs.address_.ShieldI Shield_ofAddress(
		   string _insideWork_notRepo
		   ,
		   nilnul.win.prog_.Git git = null
	   )
		{
			return
				nilnul.fs.address_.Shield.FroAddress(
					Address_ofAddress(_insideWork_notRepo, git)
			);
		}

		static public string Address(
			nilnul.fs.folder_.git_.Work _insideWork_notRepo
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return 
				__Address_ofAddress( _insideWork_notRepo.ToString(),git)
			;
		}
		static public string Address(
			nilnul.fs.FolderI _insideWork_notRepo
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return 
				Address( new nilnul.fs.folder_.git_.Work(_insideWork_notRepo) ,git)
			;
		}
		static public string Address(
			nilnul.fs.address_.ShieldI _insideWork_notRepo
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return 
				Address(
					new nilnul.fs.Folder(_insideWork_notRepo)
					,git
				);
		}

		static public string Address_ofAddress(
			string _insideWork_notRepo
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return 
				Address(
					nilnul.fs.address_.Shield.FroAddress(_insideWork_notRepo)
					,git
				);
		}

	}
}

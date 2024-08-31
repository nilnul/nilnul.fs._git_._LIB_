using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// the .git dir, which stores the state of a module
	/// </summary>
	///
	[Obsolete()]
	static public class _DbX
	{
		/*For older versions (before 1.7.x), the other options are listed in "Is there a way to get the git root directory in one command?":
		git rev-parse --git-dir
		That would give the path of the .git directory.

		 .git if at the top
		 or absPath if at any directory
			 */
		/// <summary>
		/// 
		/// </summary>
		static public string _Denote(string _moduleTop, nilnul.win.prog_.Git git=null) {
			return fs.git.module.top._DbX._Denote_ofTopAddress(_moduleTop,git);

		}

		static public nilnul.fs.address_.shield_.BaseDir _OfTopAddress_assumeDbIsDir(string _moduleTop, win.prog_.Git git=null) {
			return  nilnul.fs.address_.shield_.BaseDir.OfContainerAddress_DirDst(
				_moduleTop, 
				_Denote(_moduleTop,git)
			);
		}

		public static BaseDir _OfTop_assumeDbIsDir(FolderI en, Git git)
		{
				return _OfTopAddress_assumeDbIsDir(en.ToString(), git);
		}

		public static BaseDir _AssumeDbIsDir(Top top, Git git)
		{
				return _OfTop_assumeDbIsDir(top.en, git);
		}

		static public nilnul.fs.address_.shield_.BaseDir _AssumeDbIsDir(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git=null
		) {
			return _AssumeDbIsDir(module.top, git);
		}
		static public nilnul.fs.FolderI _Folder_assumeDbIsDir(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git=null
		) {
			return new nilnul.fs.Folder( _AssumeDbIsDir(module, git));
		}

	}

	
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.git_
{
	/// <summary>
	/// 
	/// </summary>
	static public class Init
	{
		static public void Void(nilnul.fs.FolderI folder , nilnul.win.prog_.Git git=null) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(folder,"init", git);
		}
		static public void Void_ofAddress(string folder , nilnul.win.prog_.Git git=null) {
			Void(nilnul.fs.Folder.FroAddress(folder), git);
		}

		public static void Vod(
			DirectoryInfo child4SymModuleSuper
			,
			nilnul.win.prog_.Git git=null
		)
		{
			Void(new nilnul.fs.Folder(child4SymModuleSuper), git);

		}
	}
}

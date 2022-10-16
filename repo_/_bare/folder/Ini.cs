using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo_._bare.folder
{
	public class _IniX
	{
		static public void Ini( nilnul.fs.FolderI folder, nilnul.win.prog_.Git git=null) {

			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				folder, "init --bare"
			);
			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(folder, "init");
		}
		public static void Ini(nilnul.fs.Folder folder)
		{
			Ini((FolderI)folder);
		}

		public static void Ini(DirectoryInfo folder)
		{
			Ini(new nilnul.fs.Folder(folder));
		}



		static public void Ini(string  folder) {
			Ini( 
				nilnul.fs.Folder.FroAddress(folder)
			);
		}

	}
}

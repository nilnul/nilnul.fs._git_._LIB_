using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module
{
	public class _IniX1
	{
		static public void Ini( nilnul.fs.FolderI folder, nilnul.win.prog_.Git git=null) {

			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
			//	folder, "init"
			//);

			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				folder, "init"
			);


			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(folder, "init");
		}


		
		static public void Ini(string  folder) {
			Ini( 
				nilnul.fs.Folder.FroAddress(folder)
			);
		}

	}
}

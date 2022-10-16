using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.git_.init_
{
	/// <summary>
	/// with "-bare"
	/// </summary>
	static public class _BareX
	{
		static public void Void(nilnul.fs.FolderI folder, nilnul.win.prog_.Git git = null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(folder, "init --bare", git);
		}
		static public void Void_ofAddress(string folder, nilnul.win.prog_.Git git = null)
		{
			Void(nilnul.fs.Folder.FroAddress(folder), git);
		}

	}
}

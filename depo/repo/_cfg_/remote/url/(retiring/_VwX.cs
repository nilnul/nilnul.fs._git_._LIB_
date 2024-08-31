using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote.url
{
	[Obsolete(nameof(_VwX1))]
	static public class _VwX
	{
		static public string Exe(nilnul.fs.folder_.git_.Top folder, _remote.Name remote, nilnul.win.prog_.Git git = null) {
			return vw_._RemoteGetUrlX.Exe(folder,remote,git);
		}

		static public string Exe(nilnul.fs.folder_.git_.Top folder, string remote, nilnul.win.prog_.Git git = null) {
			return Exe(folder ,new _remote.Name( remote),git);
		}

		static public string Exe(nilnul.fs.FolderI folder, _remote.Name remote, nilnul.win.prog_.Git git = null) {
			return Exe(new fs.folder_.git_.Top(folder),remote,git);
		}

		static public string Exe(nilnul.fs.FolderI folder, string remote, nilnul.win.prog_.Git git = null) {
			return Exe(new fs.folder_.git_.Top(folder) ,new _remote.Name( remote),git);
		}


		static public string Exe(string folder, string remote, nilnul.win.prog_.Git git = null) {
			return Exe(new fs.folder_.git_.Top(folder) ,new _remote.Name( remote),git);
		}

	}
}

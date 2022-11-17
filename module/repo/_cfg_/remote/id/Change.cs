using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.name
{
	/*git remote rename origin upstream*/
	static public class _ChangeX
	{
		static public void _Vod_addressAssumeModule_assumeValids(
			string module,
			string remote,
			string newName
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.win.prog_.git.run.cod.vow_._NilX.OfAddress(
				module, $"remote rename {remote} {newName}", git
			);
		}
		static public void _Vod_remoteIdEsAssumeValids(
			nilnul.fs.git.ModuleI module,
			string remote,
			string newName
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.win.prog_.git.run.cod.vow_._NilX.Void(
				module, $"remote rename {remote} {newName}", git
			);
		}


	}
}

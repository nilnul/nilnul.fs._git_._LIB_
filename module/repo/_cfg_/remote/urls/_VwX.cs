using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.urls
{
	static public class _VwX
	{
		static public IEnumerable<string> Txts(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name name
			,
			nilnul.win.prog_.Git git = null
		) {
			return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
					module, $"remote get-url --all -- {name}", git			//here "--" will guarantee that weird remote name such "-----csdn" will not bring about errors.
				)
			);
		}



		public static IEnumerable<string> Txts(
			ModuleI module
			, string remote
			,
			nilnul.win.prog_.Git git = null
		)
		=>
			Txts(module, new _remote.Name(remote),git);

		public static IEnumerable<string> Txts_addressAssumeModule(
			string module
			, string remote
			,
			nilnul.win.prog_.Git git = null
		)
		=>
			Txts(nilnul.fs.git.Module.FroAddress(module), remote,git);



	}
}

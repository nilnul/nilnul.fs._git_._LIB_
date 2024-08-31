using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo._cfg_.remote.uris_
{
	static public class _PushX
	{
		static public IEnumerable<string> _Txts_0depo(
			string module
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name name
			,
			nilnul.win.prog_.Git git = null
		) {
			return nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(
				nilnul.win.prog_.git.run.result.msg._TrimmedX._Txt_0address_1argument(
					module, $"remote get-url --push --all {name}", git
				)
			);
		}

		static public IEnumerable<string> Txts(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name name
			,
			nilnul.win.prog_.Git git = null
		) {
			return _Txts_0depo(module.top1.ToString(),name,git);
		}


		static public IEnumerable<string> Txts(
			nilnul.fs.git.ModuleI module
			,
			string name
			,
			nilnul.win.prog_.Git git = null
		) {
			return Txts(module, new module.repo._cfg_._remote.Name(name),git);
		}

	}
}

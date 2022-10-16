using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.all.del_
{
	static public class _ForceX
	{
		static public void Void(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git=null) {
			nilnul.fs.git.module.repo.branches_.local_.all.del_._ForceX.Void(
				module
				//,
				//nilnul.fs.git.module.repo.branches_.all._VwX.Txts(module,git).ToArray()
				,
				git
			);

			nilnul.fs.git.module.repo.branches_.remote_.all.del_._ForceX.Void(
				module
				//,
				//nilnul.fs.git.module.repo.branches_.all._VwX.Txts(module,git).ToArray()
				,
				git
			);


		}

		static public void Void_ofModuleAddress(string module, nilnul.win.prog_.Git git=null) {
			Void(
				nilnul.fs.git.Module.FroAddress(module),git
			);
		}

	}
}

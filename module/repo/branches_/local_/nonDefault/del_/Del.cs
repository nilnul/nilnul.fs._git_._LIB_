using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.local_.nonDefault.del_
{
	static public class _ForceX
	{
		static public void Void(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git=null) {
			nilnul.fs.git.module.repo.branches_.local_.nonDefault._VwX.Txts(module, git).ForEach(
				x =>
				{
					nilnul.fs.git.module.repo.branch_.local_.nonDefault.drop_._ForceX._Drop(
						module, x, git
					);
				}
			)
			;
		}

		static public void Void(string module, nilnul.win.prog_.Git git=null) {
			Void(
				nilnul.fs.git.Module.FroAddress(module),git
			);
		}

	}
}

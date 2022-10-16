using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.modules.each._cfg_.remotes
{
	public class EnsureBitbucketAcc
	{

		static public void Void(IEnumerable<nilnul.fs.git.ModuleI> modules
			,
			nilnul.web._url._origin._authority._credential.Acc acc
			,
			nilnul.win.prog_.Git git = null)
		{


			modules.ForEach(
				module=> {
					nilnul.fs.git.module.repo._cfg_.remotes.EnsureBitbucketAcc.Void(module, acc,git );
				}
			);
		}

		static public void Void(IEnumerable<nilnul.fs.git.ModuleI> modules
			,
			string acc
			,
			nilnul.win.prog_.Git git = null)
		{


			Void(modules, new web._url._origin._authority._credential.Acc(acc), git);
		}


	

	}
}

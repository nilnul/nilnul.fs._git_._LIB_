using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.urls
{
	public class _DelKeyX
	{
		static public void DelKey(nilnul.fs.git.ModuleI module, nilnul.fs.git.module.repo._cfg_._remote.Name remote
			,
			nilnul.win.prog_.Git git=null
			
		) {
			var urls = nilnul.fs.git.module.repo._cfg_.remote.urls._VwX.Txts(module,remote, git);

			urls.ForEach(
				url=>
				{

				}
			);
		}
	}
}

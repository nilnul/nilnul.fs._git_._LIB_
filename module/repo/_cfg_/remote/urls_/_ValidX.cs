using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.urls_
{
	static public class _ValidX
	{
		static public IEnumerable<nilnul.web.UrlI3> Urls(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name name
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.obj.seq.where_._NotNulX.NotNul( 
				urls._VwX.Txts(module, name, null).Select(
					x => nilnul.web.url.nulable._ParseX.Parse(x)
				)
			);
		}

		public static IEnumerable<nilnul.web.UrlI3> Urls(
			ModuleI module
			, string remote
			,
			nilnul.win.prog_.Git git = null
		)
		=>
			Urls(module, new _remote.Name(remote), git);


	}
}

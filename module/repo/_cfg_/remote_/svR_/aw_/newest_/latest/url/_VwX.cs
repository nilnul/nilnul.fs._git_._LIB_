using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.svr_.aw_.newest_.latest.url
{
	static public class _VwX
	{


		public static string Txt(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return nilnul.fs.git.module._cfg_.remote.url.vw_._RemoteGetUrlX.Exe(
				module, 
				svr_.aw_.newest_.latest._VwX.RemoteName(module,git)
				, git
			);
		}

		public static nilnul.web.Url2 Url(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git=null
		)
		{
			return nilnul.fs.git.module._cfg_.remote.url.vw_._RemoteGetUrlX.Url(module, svr_._AmazonX.GetNewestKeyAsName(),git);
		}


	}
}

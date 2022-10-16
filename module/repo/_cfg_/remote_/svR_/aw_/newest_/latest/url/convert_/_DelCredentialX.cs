using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.wellknown_.aw_.newest_.latest.url.convert_
{
	static public class _DelCredentialX
	{
		static public void Void(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.program_.Git git=null
		) {

			var recent = latest._VwX.RemoteName(module,git);
			var url = nilnul.fs.git.module._cfg_.remote.url.vw_._RemoteGetUrlX.Url(
				module,recent, git
			);

			var newUrl = nilnul.web.url.convert_._DelCredentialX.Op(url);




		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.svr_.aw_.newest_.latest
{
	[Obsolete(nameof(svr_.aw_.newest._VwX))]
	static public class _VwX
	{

		static public txt_.NameVer IdNulable(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git = null)
		{
			foreach (var item in _AwX.GetKeys().Reverse())
			{
				var remotes = nilnul.fs.git.module._cfg_.remotes._VwX.Seq(module).Select(x => nilnul.txt_.NameVer.Parse(x)).Where(
								y =>
									 y.name.en == item

				);
				var lastest = nilnul.txt_.nameVer.SetX.GetLatestOrDefault(remotes);
				if (lastest != null)
				{
					return lastest;
				}

			}
			return null;
		}

		static public _remote.Name RemoteName(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git = null)
		{
			return new _remote.Name(IdNulable(module,git).ToString());
		}

		static public txt_.NameVer IdNulable(
	nilnul.fs.git.Module module,
	nilnul.win.prog_.Git git = null
)
		{
			return IdNulable(module as nilnul.fs.git.ModuleI, git);
		}

		static public txt_.NameVer IdNulable(
			nilnul.fs.folder_.git_.Top module,
			nilnul.win.prog_.Git git = null
		)
		{
			return IdNulable(new nilnul.fs.git.Module(module), git);
		}




	}
}

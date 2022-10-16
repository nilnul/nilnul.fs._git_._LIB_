using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bb
{
	static public class _NewestOrDefaultX
	{

			static public txt_.NameVer Id(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git = null)
			{
				foreach (var item in _BbX.GetKeys().Reverse())
				{
					var remotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq(module).Select(x => nilnul.txt_.NameVer.Parse(x)).Where(
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


		static public txt_.NameVer Id(
	nilnul.fs.git.Module module,
	nilnul.win.prog_.Git git = null
)
		{
			return Id(module as nilnul.fs.git.ModuleI, git);
		}

		static public txt_.NameVer Id(
			nilnul.fs.folder_.git_.Top module,
			nilnul.win.prog_.Git git = null
		)
		{
			return Id(new nilnul.fs.git.Module(module), git);
		}




	}
}

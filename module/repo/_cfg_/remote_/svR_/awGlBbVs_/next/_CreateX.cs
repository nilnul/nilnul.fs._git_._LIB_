using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.awGlBbVs_.next
{
	static public class _CreateX
	{
		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.git.ModuleI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{

			try
			{
				///get the urls
				///

				var vs = nilnul.fs.git.module.repo._cfg_.remote_.svr_.vs_._NewestOrDefaultX.Id(gitTop, git);

				var bb = nilnul.fs.git.module.repo._cfg_.remote_.bb._NewestOrDefaultX.Id(gitTop, git);

				var aw = nilnul.fs.git.module.repo._cfg_.remote_.svr_.aw_.newest._VwX.IdNulable(gitTop, git);

				var gl = nilnul.fs.git.module.repo._cfg_.remote_.gl._NewestOrDefaultX.Id(gitTop, git);

				var notNuls = new[] { aw,  gl, bb,vs }.Where(x => x != null);
				var urls = new List<string>();

				if (notNuls.Any())
				{
					var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, notNuls.First().ToString());

					urls.Add(firstUrl);

					nilnul.fs.git.module.repo._cfg_.remote_.awGlBbVs._CreateX.Exe(gitTop, firstUrl);

					///append
					///
					notNuls.Skip(1).ForEach(
						x =>
						{
							var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, x.ToString());

							urls.Add(u);


							nilnul.fs.git.module.repo._cfg_.remote.urls_.push._InsX1.Exe(
								gitTop,
								new _remote.Name(
									_AwGlBbVsX.GetNewestKey()
								)
								,
								u
								,
								git
							);
						}
					);


				}

				return new _op.result_.explain_.RetTxt($"created fro {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls)}");



			}
			catch (Exception e)
			{
				return _op.result_.explain_.RetTxt.FroXpn(e.Message);
				throw;
			}

		}
		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.git.Module gitTop,
			nilnul.win.prog_.Git git = null
		)
		=> Result(gitTop as ModuleI,git);

		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.folder_.git_.Top gitTop,
			nilnul.win.prog_.Git git = null
		)
		=> Result(new nilnul.fs.git.Module(gitTop),git);
	}
}

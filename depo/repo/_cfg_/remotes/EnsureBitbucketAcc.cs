using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes
{
	public class EnsureBitbucketAcc
	{

		static public void Void(nilnul.fs.git.ModuleI module
			,
			nilnul.web._url._origin._authority._credential.Acc acc
			,
			nilnul.win.prog_.Git git = null)
		{



			var remotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq(module);

			remotes.ForEach(
				remote =>
				{
					var urls = nilnul.fs.git.module.repo._cfg_.remote.urls_._ValidX.Urls(module, remote);
					urls.ForEach(
						url =>
						{
							if (
								nilnul.web._url._origin._authority._socket._host.domain.Eq.Singleton.eq(
									
									
									nilnul.web.url._DomainX.Domain(
										url //.origin.authority.socket.host
									)
									,
									nilnul.fs.git.svr_.BitBucket.DOMAIN
								)

							)
							{
								nilnul.fs.git.module.repo._cfg_.remote.url.change_._EnsureAccX.Void(module, remote, url,acc, git);

							}

						}
					);

				}
			);

		}


	

	}
}

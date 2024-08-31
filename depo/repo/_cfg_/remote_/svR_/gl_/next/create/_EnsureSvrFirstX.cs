using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.gl_.next.create
{
	static public class _EnsureSvrFirstX
	{

		/// <summary>
		/// not create on the server for gitlab will create a repo automatically when pushed
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="svrRepoName"></param>
		/// <returns></returns>
		public static string RemoteCreated(
			string acc
			,
			nilnul.fs.folder_.git_.Top gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
		)
		{
			///not need to create; for it will be created automatically when pushed

			var r2 = nilnul.fs.git.module.repo._cfg_.remote_.gl_.next.create_._CfgedUsrX.Id(
				gitTop
					,
				svrRepoName
			);

			return Newtonsoft.Json.JsonConvert.SerializeObject(new { remote = r2 });
		}



		public static string RemoteCreated(string acc, nilnul.fs.folder_.git_.Top gitTop, string remoteCfgKey)
		{
			return RemoteCreated(acc,gitTop, new nilnul.fs.git.svr.repo.Name(remoteCfgKey));
		}

		

		public static string Ensure(string acc, nilnul.fs.FolderI gitTop, string remoteCfgKey)
		{
			return RemoteCreated(
				acc,
				new fs.folder_.git_.Top(gitTop), (remoteCfgKey)
			);
		}

	}
}

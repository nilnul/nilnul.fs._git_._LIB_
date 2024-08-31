using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.gl_.next.create_.usrCfged
{
	static public class _EnsureSvrFirstX
	{

		public static string Json(
			nilnul.fs.folder_.git_.Top2 gitTop,
			nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			///not need to create; for it will be created automatically when pushed

			var r2 = nilnul.fs.git.module._cfg_.remote_.gl_.next.create_._CfgedUsrX.Id(
				gitTop
					,
				svrRepoName
			);

			return Newtonsoft.Json.JsonConvert.SerializeObject(new {  remote = r2 });
		}

		public static string Json(nilnul.fs.folder_.git_.Top2 gitTop, string remoteCfgKey)
		{
			return Json(gitTop, new nilnul.fs.git.svr.repo.Name(remoteCfgKey));
		}
		public static string Json(nilnul.fs.FolderI3 gitTop, string remoteCfgKey)
		{
			return Json(
				new fs.folder_.git_.Top2(gitTop), (remoteCfgKey)
			);
		}

	
	}
}
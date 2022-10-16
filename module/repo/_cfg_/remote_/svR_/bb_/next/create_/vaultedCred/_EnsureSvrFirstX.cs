using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bb_.next.create_.vaultedCred
{
	static public class _EnsureSvrFirstX
	{

		public static string Json(
			nilnul.fs.folder_.git_.Top gitTop,
			nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			var r = nilnul.fs.git.svr_.bb.client_.cfged.repo.create._EnsureX.Ret(
				svrRepoName
			);

			var r2 = nilnul.fs.git.module.repo._cfg_.remote_.bb_.next.create_._CfgedUsrX.Id(
				gitTop
					,
				svrRepoName
			);

			return Newtonsoft.Json.JsonConvert.SerializeObject(new { svr = r, remote = r2 });
		}

		public static string Json(nilnul.fs.folder_.git_.Top gitTop, string remoteCfgKey)
		{
			return Json(gitTop, new nilnul.fs.git.svr.repo.Name(remoteCfgKey));
		}
		public static string Json(nilnul.fs.FolderI gitTop, string remoteCfgKey)
		{
			return Json(
				new fs.folder_.git_.Top(gitTop), (remoteCfgKey)
			);
		}

		public static nilnul._op.result_.explain_.RetTxt Result(nilnul.fs.folder_.git_.Top gitTop, string remoteCfgKey)
		{
			try
			{
				return new _op.result_.explain_.RetTxt( Json(gitTop,remoteCfgKey));
			}
			catch (Exception e)
			{

				return   _op.result_.explain_.RetTxt.FroXpn(e.ToString());
			}
			
		}
	}
}
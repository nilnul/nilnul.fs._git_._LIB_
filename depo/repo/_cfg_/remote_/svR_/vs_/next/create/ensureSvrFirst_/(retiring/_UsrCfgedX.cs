using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vs_.next.create.ensureSvrFirst_
{
	static public class _UsrCfgedX
	{
		static public string Json(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr_.vs.repo.Name repoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var r = nilnul.fs.git.svr_.vs_.prefixed.client_.cfged.repo.create_.prjDefault._EnsureX.Ret(
						repoName
				);


			var remoteKey = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NextX.NameVer(
				module
				,
				new txt_._vered_.Name(
					nilnul.fs.git.Properties.Settings.Default.moduleRemoteKeysVs.Cast<string>().Last()
				)
				,
				git
			);

			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				module
				,

				remoteKey.ToString()
				,

				nilnul.fs.git.svr_.vs_.prefixed_.cfged.repo._UrlX.Gen(repoName)
			);

			return JsonConvert.SerializeObject(new {created=r, remote=remoteKey.ToString() });

		}

		public static string Json(
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.svr_.vs.repo.Name name
			,
			G git = null
		)
		{
			return Json(
				folder as ModuleI,
				name
				, git
			);
			//throw new NotImplementedException();
		}

		public static string Json(
			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			return Json(
				folder as ModuleI,
				  nilnul.fs.git.svr_.vs.repo.Name.ByEncode(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static string Json(string folder, string name, G git = null)
		{
			return Json(
				Module.FroAddress(folder)
				,
				name
				,
				git
			);
		}
	}
}
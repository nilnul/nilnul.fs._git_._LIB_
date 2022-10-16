using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_.vs_.next.create
{
	static public class _EnsureSvrFirstX
	{
		static public string Json(
			nilnul.fs.git.ModuleI module
			,
			txt_._vered_.Name remoteKey1
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
				remoteKey1
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
			txt_._vered_.Name remoteKey1
			,
			nilnul.fs.git.svr_.vs.repo.Name name
			,
			G git = null
		)
		{
			return Json(
				folder as ModuleI
				,
			 remoteKey1
				,
				name
				, git
			);
			//throw new NotImplementedException();
		}

		public static string Json(
			nilnul.fs.git.Module folder
			,
			txt_._vered_.Name remoteKey1
			,
			string name
			,
			G git = null
		)
		{
			return Json(
				folder as ModuleI
								,
			 remoteKey1

				,
				nilnul.fs.git.svr_.vs.repo.Name.ByEncode(name)
				,
				git
			);
			//throw new NotImplementedException();
		}

		public static string Json(
			string folder
			,
			txt_._vered_.Name remoteKey1
			,
			string name, G git = null
		)
		{
			return Json(
				Module.FroAddress(folder)
				,
			 remoteKey1
				,
				name
				,
				git
			);
		}
	}
}
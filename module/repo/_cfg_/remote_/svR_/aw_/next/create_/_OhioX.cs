using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.aw_.next.create_
{
	static public class _OhioX
	{
		static public string Json(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr.repo.Name repoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			

			var remoteKey = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NextX.NameVer(
				module
				,
				new txt_._vered_.Name(
					nilnul.fs.git.Properties.Settings.Default.moduleRemoteKeysAw.Cast<string>().Last()
				)
				,
				git
			);
			var url = nilnul.fs.git.svr_.aw_.ohio.repo._UrlX.Create(repoName);

			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				module
				,

				remoteKey.ToString()
				,

				url
			);

			return JsonConvert.SerializeObject( new { remote = remoteKey , url=url });

		}

		public static string Json(
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.svr.repo.Name name
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
				  new svr.repo.Name(name)
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
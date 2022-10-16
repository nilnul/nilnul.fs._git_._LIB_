using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.aw_.next.create_.ohio
{
	static public class _EnsureSvrFirst4VaultedCredX
	{
		static public string Json(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr.repo.Name repoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var r = nilnul.fs.git.svr_.aw_.ohio.client_.cfged.repo.create._EnsureX.Ret(
				repoName
			);


			;

			return JsonConvert.SerializeObject( 
				new {
					svr =r,
				remote=remote_.aw_.next.create_._OhioX.Json(
				module
				
				,

				repoName
			)

				}
			);

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
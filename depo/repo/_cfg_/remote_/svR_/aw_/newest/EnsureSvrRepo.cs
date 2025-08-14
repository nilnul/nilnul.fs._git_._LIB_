//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_.amazon_.newest
{
	public static class _EnsureOhioRepoX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string Json(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return
				nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._EnsureAmazonOhioRepoX.Json(
					module
					,
					nilnul.fs.git.module.repo._cfg_.remote_.svr_.aw_.newest._VwX.IdNulable(module,git).ToString()
					,
					git

				)
			;



		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string Json(
			nilnul.fs.git.Module folder
			,
			G git = null
		)
		{
			return Json(
				folder as ModuleI
				, git
			);
			//throw new NotImplementedException();
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string Json(string folder,  G git = null)
		{
			return Json(
				Module.FroAddress(folder)
				
				,
				git
			);
		}
	}
}
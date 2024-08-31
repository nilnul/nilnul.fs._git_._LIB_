using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_.vs_.newest
{
	public static class _EnsureSvrRepoX
	{
		public static string Json(
			nilnul.fs.git.ModuleI module
			,
			_cfg_._remote.key_._vered.Name remoteKey
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return
				nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest.ensureSvr_._VsX.Json(
					module
					,
					remoteKey
					,
					git
				)
			;
		}

		public static string Json(
			nilnul.fs.git.Module folder
			,
			_cfg_._remote.key_._vered.Name remoteKey
			,
			G git = null
		)
		{
			return Json(
				folder as ModuleI
				,
				remoteKey
				,
				git
			);
			//throw new NotImplementedException();
		}

	

		public static string Json(
			string folder
			,
			_cfg_._remote.key_._vered.Name remoteKey
			,
			G git = null)
		{
			return Json(
				Module.FroAddress(folder)
				,
				remoteKey
				,
				git
			);
		}
		public static string Json(
			string folder
			,
			string remoteKey
			,
			G git = null)
		{
			return Json(
				Module.FroAddress(folder)
				,
				new _cfg_._remote.key_._vered.Name(remoteKey)
				,
				git
			);
		}


	}
}
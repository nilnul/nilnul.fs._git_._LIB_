using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module._cfg_.remote_.vs_.next
{
	[Obsolete()]
	static public class _CreateX
	{
		static public void Exe(
			string prefix,
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr.repo.Name repoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			

			var remoteKey = nilnul.fs.git.module._cfg_.remote_.vered_._NextX.NameVer(
				module
				,
				new txt_._nameVer_.Name(
					nilnul.fs.git.Properties.Settings.Default.moduleRemoteKeysVs.Cast<string>().Last()
				)
				,
				git
			);

			nilnul.fs.git.module._cfg_._remote._CreateX.RetVoid(
				module
				,

				remoteKey.ToString()
				,

				nilnul.fs.git.svr_.vs_.prefixed.repo._UrlX.Gen(prefix,repoName)
			);

		}

		public static void Exe(
			string prefix,
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.svr.repo.Name name
			,
			G git = null
		)
		{
			Exe(
				prefix,
				folder as ModuleI,
				name
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(
			string prefix,
			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			Exe(
				prefix,
				folder as ModuleI,
				  new svr.repo.Name(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(string prefix,string folder, string name, G git = null)
		{
			Exe(
				prefix,
				Module.FroAddress(folder)
				,
				name
				,
				git
			);
		}
	}
}
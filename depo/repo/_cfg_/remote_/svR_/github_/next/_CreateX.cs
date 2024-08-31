using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_.github_.next
{
	static public class _CreateX
	{
		static public void Exe(
			string remoteBasis,
			string acc,

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
					remoteBasis
				)
				,
				git
			);

			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				module
				,

				remoteKey.ToString()
				,

				nilnul.fs.git.svr_.github.client.repo._UrlX.Url_withCred(acc,repoName)
			);

		}

		public static void Exe(
			string remoteBasis,
			string username,
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.svr.repo.Name name
			,
			G git = null
		)
		{
			Exe(remoteBasis,
				username,
				folder as ModuleI,
				name
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(
			string remoteNameBase,
			string prefix,
			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			Exe(
				remoteNameBase,
				prefix,
				folder as ModuleI,
				  new svr.repo.Name(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(string remoteNameBase,string prefix,string folder, string name, G git = null)
		{
			Exe(
				remoteNameBase,
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
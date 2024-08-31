using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_.github_.next.create_
{
	static public class _AccInRemoteX
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

			_CreateX.Exe(
				remote_.svr_._usr._KeyX.Key(remoteBasis,acc)
				,acc
				,module
				,repoName
				,git
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
			string username,
			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			Exe(
				remoteNameBase,
				username,
				folder as ModuleI,
				  new svr.repo.Name(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(string remoteNameBase,string username,string folder, string repoName, G git = null)
		{
			Exe(
				remoteNameBase,
				username,
				Module.FroAddress(folder)
				,
				repoName
				,
				git
			);
		}
	}
}
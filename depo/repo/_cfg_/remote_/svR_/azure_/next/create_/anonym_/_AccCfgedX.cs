using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.svr_.azure_.next.create_.anonym_
{
	static public class _AccCfgedX
	{
		static public void Exe(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr.repo.Name repoName
			,
			nilnul.win.prog_.Git git = null
		)
		{

			_AnonymX.Exe(nilnul.fs.git.svr_.azure.Acc.Cfged,module,repoName,git);

		}



		public static void Exe(
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.svr.repo.Name name
			,
			G git = null
		)
		{
			Exe(
				folder as ModuleI,
				name
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(
			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			Exe(
				folder as ModuleI,
				  new svr.repo.Name(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static void Exe(
			string folder, string name, G git = null)
		{
			Exe(
				Module.FroAddress(folder)
				,
				name
				,
				git
			);
		}
	}
}
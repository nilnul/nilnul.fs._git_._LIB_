using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.fs.git.module.repo._cfg_.remote_.gl_.next.create_
{
	static public class _CfgedUsrX
	{
		static public nilnul.txt_.Vered Id(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr.repo.Name repoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _CreateX.Exe(
				nilnul.fs.git.svr_.gl.client_._CfgedX.Ensure().UserName
				,
				module
				,
				repoName
				,
				git
				


			);

		}

		public static nilnul.txt_.Vered Id(
			nilnul.fs.git.Module folder
			,
			nilnul.fs.git.svr.repo.Name name
			,
			G git = null
		)
		{
			return Id(
				folder as ModuleI,
				name
				, git
			);
			//throw new NotImplementedException();
		}

		public static nilnul.txt_.Vered Id(
			nilnul.fs.git.Module folder
			,
			string name
			,
			G git = null
		)
		{
			return Id(
				folder as ModuleI,
				  new svr.repo.Name(name)
				, git
			);
			//throw new NotImplementedException();
		}

		public static nilnul.txt_.Vered Id(string folder, string name, G git = null)
		{
			return Id(
				Module.FroAddress(folder)
				,
				name
				,
				git
			);
		}
	}
}
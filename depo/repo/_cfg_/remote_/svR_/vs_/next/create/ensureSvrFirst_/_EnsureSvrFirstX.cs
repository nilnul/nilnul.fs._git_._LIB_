using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.program_.Git;

namespace nilnul.fs.git.module._cfg_.remote_.vs_.next.create.ensureSvrFirst_
{
	static public class _CfgedX
	{
		static public void Exe(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.svr_.vs.repo.Name repoName
			,
			nilnul.win.program_.Git git = null
		)
		{
			var r = nilnul.fs.git.svr_.vs_.prefixed.client_.cfged.repo.create_.prjDefault._EnsureX.Ret(
				repoName
			);


			remote_.aw_.ohio_.next._CreateX.Exe(
				module
				
				,

				repoName
			);

		}

		public static void Create(
			nilnul.fs.git.Module3 folder
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
			nilnul.fs.git.Module3 folder
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

		public static void Exe(string folder, string name, G git = null)
		{
			Exe(
				Module3.FroAddress(folder)
				,
				name
				,
				git
			);
		}
	}
}
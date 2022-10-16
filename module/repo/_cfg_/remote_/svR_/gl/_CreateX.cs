using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt_;

namespace nilnul.fs.git.module.repo._cfg_.remote_.gl
{
	static public class _CreateX
	{
		static public void Exe(string acc,nilnul.fs.git.ModuleI module, nilnul.fs.git.module.repo._cfg_._remote.Name remote, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				module
				,
				remote
				,
				nilnul.fs.git.svr_.gl.acc.repo._UrlX.Gen(acc, svrRepoName)
			);
		}
		public  static void Exe(string acc, ModuleI module, string nameVer,nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			Exe(acc,module,new _remote.Name( nameVer),svrRepoName);
		}

		public  static void Exe(string acc, ModuleI module, NameVer nameVer,nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			Exe(acc,module,nameVer.ToString(),svrRepoName);
		}


		static public void Exe(string acc,nilnul.fs.git.Module _gitTop, nilnul.fs.git.module.repo._cfg_._remote.Name remote, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			Exe(
				acc, 
				_gitTop as ModuleI,
				new nilnul.fs.git.module.repo._cfg_._remote.Name(remote),
				svrRepoName
			);
		}


		static public void Exe(string acc,nilnul.fs.folder_.git_.Top _gitTop, nilnul.fs.git.module.repo._cfg_._remote.Name remote, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			Exe(
				acc, 
				new nilnul.fs.git.Module(_gitTop),
				new nilnul.fs.git.module.repo._cfg_._remote.Name(remote),
				svrRepoName
			);
		}

		static public void Exe(string acc,nilnul.fs.folder_.git_.Top _gitTop, string remote, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			Exe(
				acc, 
				new nilnul.fs.git.Module(_gitTop),
				new nilnul.fs.git.module.repo._cfg_._remote.Name(remote),
				svrRepoName
			);
		}


	}
}
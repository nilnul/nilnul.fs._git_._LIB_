using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.gl_.next
{
	static public class _CreateX
	{
		static public nilnul.txt_.Vered Exe(string acc,nilnul.fs.git.ModuleI module, nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		)
		{
			var remote = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NextX.NameVer(
					module
					,
					new txt_._vered_.Name(
						nilnul.fs.git.Properties.Settings.Default.moduleRemoteKeysGl.Cast<string>().Last()
					)
					,
					git
				)
				;
			gl._CreateX.Exe(
				acc
				, 
				module
				, 
				remote
				,svrRepoName
			);

			return remote;


		}
		static public nilnul.txt_.Vered Exe(string acc,nilnul.fs.git.Module _gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{

			return Exe(acc, _gitTop as nilnul.fs.git.ModuleI, svrRepoName);

		}
		static public nilnul.txt_.Vered Exe(string acc,nilnul.fs.folder_.git_.Top _gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{

			return Exe(acc, new nilnul.fs.git.Module(_gitTop), svrRepoName);

		}


	}
}
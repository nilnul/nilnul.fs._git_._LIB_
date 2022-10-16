using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.act_
{
	static public class _Unlock_repoAssumeDefaultDirX
	{

		public static void _Vod_assumeModuleTop(FolderI en)
		{

			nilnul.fs.git.repo.act_._UnlockX._Vod_assumeRepobase(
				 nilnul.fs.git.module._RepoX.DefaultFolder_assumeModule(en)

			);


		}

		/// <summary>
		///
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// 
		static public void Vod(ModuleI obj)
		{

			nilnul.fs.git.repo.act_._UnlockX._Vod_assumeRepobase(

				 nilnul.fs.git.module._RepoX.DefaultFolder(obj)

			);


		}

		public static void _Vod_assumeModuleTop(ShieldI shield)
		{
			 Vod(Module.OvTop(shield)); ;

		}

		static public void _Vod_addressAssumeModuleTop(string obj)
		{

			 Vod(Module.FroAddress(obj)); ;

		}
	}
}

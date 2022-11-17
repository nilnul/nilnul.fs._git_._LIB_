
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_.plainWorkRepo_
{
	/// <summary>
	/// 
	/// </summary>
	public class Deadlined
	{

		static public _plainWorkRepo.Ret _Trich_assumeFolder(string folder, nilnul.win.prog_.Git git = null
			,int? life=null, int? bye=null
			)
		{

			var result =
			

				win.prog_.git.run_.timeout._ResultX.Result_ofAddress
				(
				folder/*.container.ToString()*/,
				"rev-parse --is-inside-work-tree"
				, git
				,
				life,bye

			);

			if (result.beErr)
			{	/// eg: bad config at last lines filled with nuls; in this case, it's a bad module;
				/// 
				return _plainWorkRepo.Ret.Plain;
			}
			else
			{

				if (result.msg.ToString().Trim().ToLower() == "true")
				{
					return _plainWorkRepo.Ret.Work;
				}
				return _plainWorkRepo.Ret.Repo;

			}
		}


		static public _plainWorkRepo.Ret Category(
			nilnul.fs.FolderI folder, nilnul.win.prog_.Git git=null
			, int? life = null, int? bye = null

			)
		{
			return _Trich_assumeFolder(folder.ToString(),git,life,bye);

		}

		static public _plainWorkRepo.Ret Category(nilnul.fs.Folder folder, nilnul.win.prog_.Git git = null)
		=> Category(folder as nilnul.fs.FolderI, git);


		public static _plainWorkRepo.Ret Category(DirectoryInfo item
			, nilnul.win.prog_.Git git = null
			)
		=>Category( new nilnul.fs.Folder(item) ,git) ;

		public static _plainWorkRepo.Ret Category(nilnul.fs.address_.ShieldI item
			, nilnul.win.prog_.Git git = null
			)
		=>Category( new nilnul.fs.Folder(item) ,git) ;



		static public _plainWorkRepo.Ret Category_ofAddress(string folder, nilnul.win.prog_.Git git = null)
		=> Category(nilnul.fs.Folder.FroAddress(folder), git);




	}
}

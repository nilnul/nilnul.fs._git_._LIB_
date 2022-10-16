
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_
{
	/// <summary>
	/// 
	/// </summary>
	public class PlainWorkRepo
	{

		static public _plainWorkRepo.Ret _Trich_assumeFolder(string folder, nilnul.win.prog_.Git git = null)
		{

			var result = win.prog_.git.run._ResultX1._Result_assumeAddress(
				folder/*.container.ToString()*/,
				"rev-parse --is-inside-work-tree"
				, git

			);

			if (result.beErr)
			{
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


		static public _plainWorkRepo.Ret Category( nilnul.fs.FolderI folder, nilnul.win.prog_.Git git=null)
		{
			//StringWriter output = new StringWriter();

			var result = nilnul.win.prog_.git.run._ResultX.Result(
							folder,
			 "rev-parse --is-inside-work-tree"

			);

			if (result.beErr)
			{
				///"eg: fatal: bad config line 19 in file .git/config. The reason might some nuls are at the end."
				return _plainWorkRepo.Ret.Plain;
			}
			else
			{

				if (result.msg.ToString().Trim().ToLower() == "true")  
				{
					return _plainWorkRepo.Ret.Work;
				}
				return _plainWorkRepo.Ret.Repo;//note: if repo_ is bare, "false" is also returned.

			}
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

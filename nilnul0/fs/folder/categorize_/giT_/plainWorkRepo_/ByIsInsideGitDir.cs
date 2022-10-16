
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.giT_.plainWorkRepo_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ByIsInsideGitDirX
	{

		static public git_._plainWorkRepo.Ret Category( nilnul.fs.FolderI folder, nilnul.win.prog_.Git git=null)
		{
			//StringWriter output = new StringWriter();

			var result = nilnul.win.prog_.git.run_.timeout._ResultX.Result(
							folder,
			 "rev-parse --is-inside-git-dir"

			);

			if (result.beErr)
			{
				return git_._plainWorkRepo.Ret.Plain;
			}
			else
			{

				if (result.msg.ToString().Trim().ToLower() == "true")  
				{
					return git_._plainWorkRepo.Ret.Repo;//note: if repo_ is bare, "true" is also returned.
				}
				return git_._plainWorkRepo.Ret.Work;

			}
		}

		static public git_._plainWorkRepo.Ret Category(nilnul.fs.Folder folder, nilnul.win.prog_.Git git = null)
		=> Category(folder as nilnul.fs.FolderI, git);


		public static git_._plainWorkRepo.Ret Category(DirectoryInfo item
			, nilnul.win.prog_.Git git = null
			)
		=>Category( new nilnul.fs.Folder(item) ,git) ;

		public static git_._plainWorkRepo.Ret Category(nilnul.fs.address_.ShieldI item
			, nilnul.win.prog_.Git git = null
			)
		=>Category( new nilnul.fs.Folder(item) ,git) ;



		static public git_._plainWorkRepo.Ret Category_ofAddress(string folder, nilnul.win.prog_.Git git = null)
		=> Category(nilnul.fs.Folder.FroAddress(folder), git);




	}
}

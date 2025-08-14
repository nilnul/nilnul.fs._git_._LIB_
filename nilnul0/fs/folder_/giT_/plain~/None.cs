using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.folder_
{
	[Obsolete()]
	public class None
		:
		nilnul.dev.git.folder.Categorized< folder.category.be_.None>
	{


		public None(git.folder.Category category):base(category)
		{


		}

		public static void _Init(nilnul.win.prog_.Git git, DirectoryInfo folder_none)
		{
			git.runCmd_throwErr(folder_none, "init");
			//throw new NotImplementedException();
		}
		public static void _Init( DirectoryInfo folder_none)
		{
			_Init(nilnul.win.prog_.Git.StaticInstance, folder_none);
		}


		public None(
			git.Folder folder
			
		):this( git.folder.Category.Eval(folder)  )
		{

		}


		public void init() {
			var r= this.folder.runCmd("init");
			if (r.notBeErr)
			{
				throw new _git.ReportErrException(r.err);

			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_folder__none"></param>
		static public void _Init(
			Git git,

			
			string _folder__none
			
		) {

			var r=Folder.RunCmd(git,_folder__none, "init");

			if (r.beErr)
			{
				throw new _git.ReportErrException(r.err);

			}


		}


		static public void _Init(string folder) {
			_Init(nilnul.win.prog_.Git.StaticInstance, folder);
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder_
{
	/// <summary>
	/// a plain fold is a fold not in any module
	/// </summary>
	public class Plain
		:
		nilnul.fs.git.folder.categorized.En< folder.categorized.be_.Plain>
	{


		public Plain(git.folder.Categorized category):base(category)
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




		public Plain(
			git.Folder folder
			
		):this( git.folder.Categorized.Eval(folder)  )
		{

		}


		public void init() {
			var r= this.avowed.folder.runCmd("init");
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

		static public void _Init(nilnul.win.prog_.Git git, nilnul.fs.Folder folder) {
			_Init(git, folder.ToString());
		}


		static public void _Init(nilnul.fs.Folder folder) {
			_Init(nilnul.win.prog_.Git.StaticInstance, folder);
		}

		static public void _Init(string folder) {
			_Init(nilnul.win.prog_.Git.StaticInstance, folder);
		}
	}
}

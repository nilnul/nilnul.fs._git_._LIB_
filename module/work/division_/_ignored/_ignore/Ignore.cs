using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg
{
	/*
	 .gitignorer 




		 */
	public class Ignore
	{
		public const char Exclamation = '!';    //meaningful

		/*git config --get core.excludesfile*/


		public static string  GetGlobalIgnoreFileAddress(FolderI folder, Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"config --get core.excludesfile",git);

		}







		public static string GetGlobalIgnoreFileAddress(nilnul.fs.Folder  folder, Git git=null)
		{
			return GetGlobalIgnoreFileAddress((FolderI)folder, git);

		}

	

		public static string  GetGlobalIgnoreFileAddress_ofAddress(string folder, Git git=null)
		{
			return GetGlobalIgnoreFileAddress( nilnul.fs.Folder.FroAddress( folder), git);

		}



	}
}

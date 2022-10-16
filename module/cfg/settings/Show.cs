using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.settings
{
	public class Show
	{
		/*
		 			Debug.WriteLine(module.runCmd_retMsg_throwErr("c"));

			 *  */
		public static string List(Folder folder, Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, "config -l", git);
			
		}

		public static string OnlyName(Folder folder,string name, Git git=null)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"config {name}", git);

			
		}




	}
}

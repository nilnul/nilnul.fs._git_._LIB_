using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module.cfg.settings
{
	public class Show
	{
		/*
		 			Debug.WriteLine(module.runCmd_retMsg_throwErr("c"));

			 *  */
		public static string List(Folder folder)
		{
			return folder.runCmd_retMsg_throwErr(
				"config -l"
			);
		}

		public static string OnlyName(Folder folder,string name)
		{
			return folder.runCmd_retMsg_throwErr(
				$"config {name}"
			);
		}




	}
}

using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.git_
{
	static public class _TopX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="module">the parent folder of this folder, which is the root of a module</param>
		/// <param name="_rootChildFolderLocation_notRepo">
		/// a folder that is not ".git"; so this folder is either a plain child folder of the parent folder module, or the root of a submodule itself.
		/// </param>
		/// <returns></returns>
		static public string _GetRoot(
			nilnul.fs.FolderI parentModule
			

			
			,
			Git git=null
		)
		{

			///note: in ".git", the following command returns empty. 
			///		in submodule, the following command returns the root of the submodule.

			var result = nilnul.win.prog_.git.run._ResultX.Result(parentModule,  "rev-parse --show-toplevel", git);

			if (result.notBeErr)
			{

				return new DirectoryInfo(
					 result.msg.ToString().Trim()
					).FullName;
			}
			else
			{
				throw new _git.ReportErrException(
					result.err

				);

			}

		}
	}
}

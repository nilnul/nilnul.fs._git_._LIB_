using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.saved.commit_.current.vsWork
{
	public class _TreeDifX
	{
		public static string TreeDif(fs.Folder folder)
		{
			return TreeDif(folder.ToString());
			throw new NotImplementedException();
		}

		/*-u[<mode>] 

--untracked-files[=<mode>] 
Show untracked files.


The mode parameter is used to specify the handling of untracked files. It is optional: it defaults to all, and if specified, it must be stuck to the option (e.g. -uno, but not -u no).


The possible options are:


•no - Show no untracked files.


•normal - Shows untracked files and directories.


•all - Also shows individual files in untracked directories.



When -u option is not used, untracked files and directories are shown (i.e. the same as specifying normal), to help you avoid forgetting to add newly created files. Because it takes extra work to find untracked files in the filesystem, this mode may take some time in a large working tree. Consider enabling untracked cache and split index if supported (see git update-index --untracked-cache and git update-index --split-index), Otherwise you can use no to have git status return more quickly without showing untracked files.
*/

		static public string TreeDif_notConsiderIgnore( string _module, nilnul.win.prog_.Git git =null) {

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module,

				"status -unormal"
				,
				git
			);
		}


		/// <summary>
		/// git ls-files --others --exclude-standard

		/// </summary>
		/// <param name="_module"></param>
		/// <param name="git"></param>
		/// <returns></returns>

		static public string TreeDif( string _module, nilnul.win.prog_.Git git =null) {

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module,

				"ls-files --others"
				,
				git
			);
		}
	


	}
}

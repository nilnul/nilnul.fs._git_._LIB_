using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.stage
{
	/// <summary>
	/// this will change the stage. so this is a stage concept
	/// </summary>
	static public class _AddX
	{
		/*
git add -A stages All


•git add . stages new and modified, without deleted


•git add -u stages modified and deleted, without new




*/

		/*




		 */


		/// <summary>		/*git add -A*/
		/// -A 
		///--all 
		///--no-ignore-removal 
		///Update the index not only where the working tree has a file matching <pathspec> but also where the index already has an entry. This adds, modifies, and removes index entries to match the working tree.
		///If no <pathspec> is given when -A option is used, all files in the entire working tree are updated (old versions of nilnul.win.prog_.Git used to limit the update to the current directory and its subdirectories).
		/// git add -A is equivalent to git add .; git add -u.
		/// </summary>
		static public void _ExeWholeWork(string _module)
		{
			Git.StaticInstance.runCmd_throwErr(
				_module, "add -A"
			);
		}

		static public void _ExeWholeWork(nilnul.win.prog_.Git git, string _module)
		{
			git.runCmd_throwErr(
				_module, "add -A"
			);
		}

		static public void _ExeWholeWork(nilnul.fs.Folder _module)
		{
			Git.StaticInstance.runCmd_throwErr(
				_module, "add -A"
			);
		}

		static public void _ExeWholeWork(nilnul.win.prog_.Git git ,nilnul.fs.Folder _module)
		{
			git.runCmd_throwErr(
				_module, "add -A"
			);
		}

		/* git add -A .          #  note the dot.*/
		static public void ExeDirectory() { }
		/*
		 git add .   #stages new and modified, without deleted
			 */
		static public void ExeDirectory_newModified_noDeleted() { }
		/*
		 git add -u  #where u stands for update
			 */
		static public void ExeWholeWork_modifiedDeleted_noNew() { }

		/* git add -u .        # note: the dot       */
		static public void ExeDirectory_noNew() { }

		/*git add --ignore-removal .           # note the dot */
		static public void ExeDirecotry_noDeleted() { }
	}
}

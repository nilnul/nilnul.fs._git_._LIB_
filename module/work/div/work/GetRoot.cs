using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;

namespace nilnul.fs.git.module.root.andDirectory_.work
{
	/// <summary>
	///  a folder that's inside a module, but is not inside ".git".
	///  including:
	///		root of a module
	///		subfolder of root that's not .git
	///		descendant folder of a module that's not inside .git.
	///			this must be a descendant folder of a root.
	///		subfolder of root that's the root of another moder
	///	excluding:
	///		.git or its descendants.
	///		
	/// </summary>
	/// 
	public class GetRoot
	{
		public static nilnul.fs.address_.Shield _GetRoot(nilnul.win.prog_.Git git, fs.Folder folder)
		{
			return nilnul.fs.address_.Shield.FroAddress(


					git.runCmd__returnResult(folder, "rev-parse --show-toplevel")  ///note: in ".git", the following command returns empty.  in submodule, the command returns the root of the submodule.
					.msg.ToString().Trim()

				);

			throw new NotImplementedException();
		}

		public static nilnul.fs.address_.Shield _GetRoot( fs.Folder folder)
		{
			return _GetRoot(nilnul.win.prog_.Git.StaticInstance,folder);
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_insideWork_notRepo"></param>
		/// <returns>
		/// "" if in ".git"
		/// moduleTop if in workspace
		/// undefined if not in module
		/// </returns>

		static public nilnul.fs.address_.Shield _GetRoot(nilnul.win.prog_.Git git,  string _insideWork_notRepo)
		{

			

			
				return nilnul.fs.address_.Shield.FroAddress(


					git.runCmd__returnResult(_insideWork_notRepo, "rev-parse --show-toplevel")	///note: in ".git", the following command returns empty.  in submodule, the command returns the root of the submodule.
					.msg.ToString().Trim()
					
				);
			
			


		}


		/*
		To calculate the absolute path of the current git root directory, say for use in a shell script, use this combination of readlink and git rev-parse:
gitroot=$(readlink -f ./$(git rev-parse --show-cdup))


git-rev-parse --show-cdup gives you the right number of ".."s to get to the root from your cwd, or the empty string if you are at the root. Then prepend "./" to deal with the empty string case and use readlink -f to translate to a full path.

You could also create a git-root command in your PATH as a shell script to apply this technique:
cat > ~/bin/git-root << EOF
#!/bin/sh -e
cdup=$(git rev-parse --show-cdup)
exec readlink -f ./$cdup
EOF
chmod 755 ~/bin/git-root


(The above can be pasted into a terminal to create git-root and set execute bits; the actual script is in lines 2, 3 and 4.)

And then you'd be able to run git root to get the root of your current tree. Note that in the shell script, use "-e" to cause the shell to exit if the rev-parse fails so that you can properly get the exit status and error message if you are not in a git directory.

			
			*/

		/*
		git rev-parse --git-dir
		*/



	}
}

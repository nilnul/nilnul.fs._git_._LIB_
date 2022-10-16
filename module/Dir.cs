using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// a folder that is the child of a root. this folder may be:
	/// ".git",
	/// "plain sub folder", 
	/// "subfolder that's the root of a submodule"
	/// 
	/// excluding the child of child.
	/// </summary>
	public class Dir
	{
		/// <summary>
		/// .git or workspace 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="_rootChildFolder_Location"></param>
		/// <returns></returns>
		static public bool _RepoFalse(Module module, string _rootChildFolder_Location)
		{
			return bool.Parse(
				module.git.runCmd__returnResult(
					_rootChildFolder_Location,
					"rev-parse --is-inside-work-tree"
				).msg.ToString().Trim().ToLower()
			);
		}


		static public bool _RepoFalse(nilnul.win.prog_.Git git, string _rootChildFolder_Location)
		{

			
			return bool.Parse(
				git.runCmd__returnResult(
					_rootChildFolder_Location,
					"rev-parse --is-inside-work-tree"
				).msg.ToString().Trim().ToLower()
			);
		}



		static public bool _RepoFalse(
			string _rootChildFolder_Location
			)
		{
			return _RepoFalse(nilnul.win.prog_.Git.StaticInstance, _rootChildFolder_Location);
		}

		static public bool _IsRepo(
			Module module, string _rootChildFolder_Location
			)
		{

			return _RepoFalse(module, _rootChildFolder_Location) == false;

		}


		static public bool _IsNotRepo(
			Module module, string _rootChildFolder_Location
			)
		{

			return _RepoFalse(module, _rootChildFolder_Location) == true;

		}



		static public bool _IsNotRepo(
			string _rootChildFolder_Location
			)
		{

			return _RepoFalse(_rootChildFolder_Location) == true;

		}



	}
}

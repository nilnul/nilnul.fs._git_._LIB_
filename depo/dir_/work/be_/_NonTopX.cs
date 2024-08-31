using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.dir_.work.be_
{
	/// <summary>
	/// a child of a module top that's not repo. 
	/// aka: non-repo
	/// including:
	///		* sub folder of a parent module
	///		* root of a submodule
	///	excluding:
	///		* .git 
	/// </summary>
	static public class _NonTopX
	{

		static public bool _Be(string _location_of__child_notRepo, nilnul.win.prog_.Git git=null)
		{
			return !_TopX._Be(_location_of__child_notRepo, git);
		}

		public static bool _BeNonTop_moduleDirAssumeWork(DirectoryInfo child, Git git)
		{
			return _Be(child.FullName,git);
		}
		public static bool _Be_assumeWork(FolderI en, Git git)
		{
			return !_TopX._Be_assumeWork(en, git);
			
		}

	}


}

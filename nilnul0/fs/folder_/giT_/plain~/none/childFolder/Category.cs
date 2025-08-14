using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.folder_.none.childFolder
{
	public class Category
	{
		


		static public bool _NoneFalse_ModuleRootlTrue(nilnul.win.prog_.Git git, string _location)
		{
			//StringWriter output = new StringWriter();

			return  git.runCmd__returnResult(
							_location,
			 "rev-parse --is-inside-work-tree"

			).notBeErr;

			
		}

		static public bool _IsNone(string _location) {
			return _IsNone(
				Git.StaticInstance
				, _location

			);
		}

		static public bool _IsNone(
			Git git, string _location
			
			) {
			return _NoneFalse_ModuleRootlTrue(git, _location) == false;

		}


		static public bool _IsModuleRoot(
			Git git, string _location
			
			) {
			return _NoneFalse_ModuleRootlTrue(git, _location) == true;

		}



		



	}
}

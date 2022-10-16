using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder_.none.nonRoot
{
	public class Category
	{
		


		static public bool _PlainFalse_ModuleRootTrue(nilnul.win.prog_.Git git, string _location)
		{
			//StringWriter output = new StringWriter();
			return nilnul.win.prog_.git.run._ResultX.Result_ofAddress(
							_location,
			 "rev-parse --is-inside-work-tree"

			).notBeErr;
		}

		static public bool _IsPlain(string _location) {
			return _IsPlain(
				Git.StaticInstance
				, _location

			);
		}

		static public bool _IsPlain(
			Git git, string _location
			
			) {
			return _PlainFalse_ModuleRootTrue(git, _location) == false;

		}


		static public bool _IsModuleRoot(
			Git git, string _location
			
			) {
			return _PlainFalse_ModuleRootTrue(git, _location) == true;

		}



		



	}
}

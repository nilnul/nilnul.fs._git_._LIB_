using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.child_
{
	/// <summary>
	/// a child that's not repo.
	/// including:
	///		* plain sub folder
	///		* root of a submodule
	///	excluding:
	///		* .git 
	/// </summary>
	public class NonRepo
	{

		static public bool _IsRoot(nilnul.win.prog_.Git git, string _location_of__child_notRepo)
		{


			return Workspace._IsRoot(git, _location_of__child_notRepo);


		}

		static public bool _IsRoot(
			string _location_of__child_notRepo
			)
		{

			return _IsRoot(nilnul.win.prog_.Git.StaticInstance, _location_of__child_notRepo);

		}


	}
}

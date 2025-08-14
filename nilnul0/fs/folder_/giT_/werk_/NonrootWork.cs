using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git
{
	/// <summary>
	/// 
	/// work that is not root.
	/// 
	/// a folder that:
	///		* is inside a module
	///		* not inside .git
	///		* not the root of the module
	///	eg:
	///		* child folder that is work( in other words,  not ".git", nor "root of submodule")
	///		* child of a descedent, but is not the root of a module.
	/// </summary>
	/// <remarks>
	///  because it's not the root, so there would be no  ".git", but work folders.
	///  
	/// alias: 
	///		positive generations.
	/// </remarks>
	public class NonrootWork
	{

		/// <summary>
		/// this will init a submodule; 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location__nonrootWork"></param>
		static public void _Init(nilnul.win.prog_.Git git , string _location__nonrootWork) {
			git.init(_location__nonrootWork );
		}



	}
}

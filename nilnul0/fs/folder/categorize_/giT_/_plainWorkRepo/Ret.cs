using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_._plainWorkRepo
{
	/// <summary>
	/// plain(not in any module), work(root or sub of a module, but not inside .git), repo (inside .git)
	/// </summary>
	public enum Ret
	{
		/// <summary>
		/// not in any module.
		/// note, some non-plain folder may incur eroor, eg: "fatal: bad config line 19 in file .git/config" ( The reason might some nuls are at the end.), or the owner is not the current user, then the folder is wrongly deemed as plain.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// alias:
		///		trivia
		///		none
		///		noop
		///		nope
		Plain,

		/// <summary>
		/// the root or sub of a workspace; maybe the root or sub of a submodule. If it's the root, it may contains a ".git" folder
		/// for a bare repo, it's also called Work, as "git rev-parse --is-inside-work-tree" returns true.
		/// </summary>
		Work    
		,

		
		/// <summary>
		/// inside the .git dir (root or sub)
		/// </summary>
		Repo    //inside the .git dir, root or sub 
	}

}

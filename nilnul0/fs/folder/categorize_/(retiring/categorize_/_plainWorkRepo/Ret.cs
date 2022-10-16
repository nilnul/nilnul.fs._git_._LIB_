using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorize_._plainWorkRepo
{

	public enum Ret
	{
		/// <summary>
		/// not in any module
		/// </summary>
		Plain,

		/// <summary>
		/// the root or sub of a workspace; maybe the root or sub of a submodule. If it's the root, it may contains a ".git" folder
		/// </summary>
		Work    
		,

		
		/// <summary>
		/// inside the .git dir (root or sub)
		/// </summary>
		Repo    //inside the .git dir, root or sub 
	}

}

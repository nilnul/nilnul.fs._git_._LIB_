using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git._folder
{

	[Obsolete()]
	public enum NoneWorkRepo
	{
		/// <summary>
		/// not in any workspace
		/// </summary>
		None,

		/// <summary>
		/// the root or sub of a workspace; maybe the root or sub of a submodule
		/// </summary>
		Work    //the root workspace
		,

		
		/// <summary>
		/// inside the .git dir (root or sub)
		/// </summary>
		Repo    //inside the .git dir, root or sub 
	}

}

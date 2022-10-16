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
	public enum NoneRootSubRepo
	{
		/// <summary>
		/// not in any workspace
		/// </summary>
		None,

		/// <summary>
		/// the root of a workspace; maybe the root of a submodule
		/// </summary>
		Root    //the root workspace
		,

		/// <summary>
		/// inside a sub folder of workspace
		/// </summary>
		Sub //sub dir of root workspace
		,
		/// <summary>
		/// inside the .git dir (root or sub)
		/// </summary>
		Repo    //inside the .git dir, root or sub 
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.dir.be_
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete()]
	static public class _WorkX
	{

		static public bool Be( string _rootChildFolder_Location, nilnul.win.prog_.Git git = null)
		{
			return bool.Parse(
				nilnul.win.prog_.Git.RunCmd_result(
					_rootChildFolder_Location,
					"rev-parse --is-inside-work-tree"
					,git
				).msg.ToString().Trim().ToLower()
			)  ;
		}
	}
}

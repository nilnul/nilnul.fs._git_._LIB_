using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.root.dir.be_
{
	/// <summary>
	/// </summary>
	public class Work
	{


		

		static public bool _Be(nilnul.win.prog_.Git git, string _rootDir_Location)
		{

			
			
			return bool.Parse(
				git.runCmd__returnResult(
					_rootDir_Location,
					"rev-parse --is-inside-work-tree"
				).msg.ToString().Trim().ToLower()
			)  ;
		}


		


	}
}

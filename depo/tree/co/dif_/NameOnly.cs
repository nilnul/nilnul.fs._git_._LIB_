using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.tree.co.dif_
{
	///
	///
	/// <summary>
	/// 
	/// </summary>
	static public class _NameOnlyX
	{
		static public void NameOnly(string moduleAddress,string tree, string tree1, nilnul.os.prog_.Git git0nul) {
			nilnul.os.prog_.git._RunX._Vod_0nulable_1address_2args(
				git0nul
				,
				moduleAddress

				,"diff-tree"	// diff is also ok;

				//,"--no-commit-id"
				//this is not necessary.
				,
				"--name-status"
				,
				"-r"	//recursive, including not only child, but also other descendents;
				,
				tree
				,
				tree1
			);
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.location_;

namespace nilnul.fs.git.module.div.be_
{
	/// <summary>
	/// in subworkspace, or in ".git"
	/// </summary>
	public class NonRoot//:nilnul.fs.location_.folder.BeI
	{
		static public bool _Be(string _workspaceSubDir)
		{
			return nilnul.fs.address.eq.Neq.Singleton.neq(
				Module.GetRoot(_workspaceSubDir),
				(_workspaceSubDir)
			);
		}

		static public bool _Be(nilnul.fs.location_.Folder folderInModule) {
			return nilnul.fs.address.eq.Neq.Singleton.neq(
							Module.GetRoot(folderInModule),
							(folderInModule).ToString()
				);
		}
	}
}

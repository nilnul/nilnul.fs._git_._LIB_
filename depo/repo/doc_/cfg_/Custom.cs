using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.doc_.cfg_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _CustomX
	{
		 static public void _assumeModule(nilnul.fs.FolderI module, string customDoc, string key, string val, nilnul.win.prog_.Git git = null)
		{
			

				nilnul.fs.folder.git_._CfgX._Set(
					nilnul.fs.git.module._RepoX.DefaultFolder_assumeModule(
								module
					)
					, customDoc
					, key
					, val
					, git
				);

			
		}
	}
}

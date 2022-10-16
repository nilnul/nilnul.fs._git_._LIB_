using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.txt.str.fro._lines;
using System.IO;

namespace nilnul.fs.git.module
{
	[Obsolete(nameof(cfg.remotes.Show))]
	public class Remotes
	{

		static public IEnumerable<string> GetRemotes_throws(nilnul.win.prog_.Git git, string workingDir)
		{
			return  git.runCmd__retResult_throwErr(workingDir, "remote")
				.ToLines_trimmedAndRemoveWhites(					);
		}

		static public IEnumerable<string> GetRemotes_throws(nilnul.win.prog_.Git git, DirectoryInfo workingDir)
		{
			return  git.runCmd__retResult_throwErr(workingDir, "remote")
				.ToLines_trimmedAndRemoveWhites(					);


		}

		static public IEnumerable<string> GetRemotes_throws( DirectoryInfo workingDir)
		{
			return GetRemotes_throws(nilnul.win.prog_.Git.StaticInstance, workingDir);


		}

		public static IEnumerable<string> GetRemotes_throws(Folder folderGit)
		{
			return GetRemotes_throws(folderGit.git, folderGit.address.ToString());

			//throw new NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.txt;
using nilnul.txt.str;
using nilnul.txt.str.fro;
using nilnul.txt.str.fro._lines;



namespace nilnul.dev.git.module.cfg.remotes
{
	public class Show
	{
		static public string GetVerboseMsg(Folder folder) {
			return folder.runCmd_retMsg_throwErr($"remote -v");

		}

		/*
		 git ls-remote --get-url [REMOTE]

		 */

		static public IEnumerable<string> GetRemotes_throws(nilnul.win.prog_.Git git, string workingDir)
		{
			return git.runCmd__retResult_throwErr(workingDir, "remote")
				.ToLines_trimmedAndRemoveWhites();
		}

		static public IEnumerable<string> GetRemotes_throws( string workingDir)
		{
			return GetRemotes_throws(nilnul.win.prog_.Git.StaticInstance,workingDir);
		}


		static public IEnumerable<string> GetRemotes_throws(nilnul.win.prog_.Git git, DirectoryInfo workingDir)
		{
			return git.runCmd__retResult_throwErr(workingDir, "remote")
				.ToLines_trimmedAndRemoveWhites();


		}

		static public IEnumerable<string> GetRemotes_throws(DirectoryInfo workingDir)
		{
			return GetRemotes_throws(nilnul.win.prog_.Git.StaticInstance, workingDir);


		}

		public static IEnumerable<string> GetRemotes_throws(Folder folderGit)
		{
			return GetRemotes_throws(folderGit.git, folderGit.location);

			//throw new NotImplementedException();
		}
	}
}

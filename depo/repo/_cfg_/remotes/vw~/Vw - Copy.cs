using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;
using nilnul.fs.git.module._cfg_._remote;
using nilnul.txt;
using nilnul.txt.str;
using nilnul.txt.str.fro;
using nilnul.txt.str.fro._lines;



namespace nilnul.fs.git.module._cfg_.remotes
{
	[Obsolete()]
	public class Vw
	{
		static public string GetVerboseMsg(nilnul.fs.Folder folder) {
			return GetVerboseMsg(nilnul.win.prog_.Git.StaticInstance,folder);

		}

		static public string GetVerboseMsg(nilnul.win.prog_.Git git, nilnul.fs.Folder folder) {
			return
				git.runCmd__retResult_throwErr( folder, $"remote -v");

		}

		public  static IEnumerable<string> GetRemotes_throws(GitTop module, nilnul.win.prog_.Git git=null)
		{

			return nilnul.win.prog_.Git.RunCmd__retMsg_throwErr(module,  "remote",git)
				.ToLines_trimmedAndRemoveWhites();
		}

		static public string GetVerboseMsg(nilnul.win.prog_.Git git, string folder) {
			return
				git.runCmd__retResult_throwErr( folder, $"remote -v");

		}


		static public string GetVerboseMsg( string folder) {
			return
				Git.StaticInstance.runCmd__retResult_throwErr( folder, $"remote -v");

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

		public static IEnumerable<string> GetRemotes_throws(nilnul.fs.Folder folderGit)
		{
			return GetRemotes_throws(nilnul.win.prog_.Git.StaticInstance, folderGit);

			//throw new NotImplementedException();
		}
	}
}

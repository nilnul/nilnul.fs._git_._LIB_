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

using G = nilnul.win.prog_.Git;



namespace nilnul.fs.git.module._cfg_.remotes
{
	[Obsolete()]
	public class Vw1
	{

		static public string VerboseMsg( nilnul.fs.git.Module1 folder, G git=null) {
			return
				G.RunCmd__retMsg_throwErr( folder, $"remote -v");

		}
		static public string VerboseMsg(nilnul.fs.FolderI folder, G git=null) {
			return VerboseMsg( Module1.OfFolder(folder));

		}
		static public string VerboseMsg( string folder, G git=null) {
			return
				VerboseMsg(new nilnul.fs.Folder(folder),git);

		}


		public  static IEnumerable<string> Seq(nilnul.fs.git.Module1 module, G git=null)
		{

			return G.RunCmd__retMsg_throwErr(module,  "remote",git)
				.ToLines_trimmedAndRemoveWhites();
		}
		public  static IEnumerable<string> Seq(nilnul.fs.folder_.git_.Top module, G git=null)
		{

			return G.RunCmd__retMsg_throwErr(module,  "remote",git)
				.ToLines_trimmedAndRemoveWhites();
		}



		public static IEnumerable<string> Seq(nilnul.fs.FolderI folderGit, G git=null)
		{
			return Seq(nilnul.fs.git.Module1.OfFolder( folderGit),git);

			//throw new NotImplementedException();
		}
		


		/*
		 git ls-remote --get-url [REMOTE]

		 */

		static public IEnumerable<string> Seq( string workingDir, G git=null)
		{
			return Seq( Module1.OfAddress(workingDir) ,git);
		}

		


		static public IEnumerable<string> Seq( DirectoryInfo workingDir, G git=null)
		{
			return Seq( new nilnul.fs.Folder(workingDir) as nilnul.fs.FolderI, git);


		}



		

	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;
using nilnul.fs.git.module.repo._cfg_._remote;
using nilnul.txt;
using nilnul.txt.str;
using nilnul.txt.str.fro;
using nilnul.txt.str.fro._lines;

using G = nilnul.win.prog_.Git;


namespace nilnul.fs.git.module.repo._cfg_.remotes
{
	static public class _VwX
	{

		static public string VerboseMsg( nilnul.fs.git.Module folder, G git=null) {
			return
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt( folder.top, $"remote -v");

		}
		static public string VerboseMsg(nilnul.fs.FolderI folder, G git=null) {
			return VerboseMsg( new Module(folder));

		}
		static public string VerboseMsg( string _module_address, G git=null) {
			return
				VerboseMsg( nilnul.fs.Folder.FroAddress(_module_address),git);

		}

		public  static IEnumerable<string> Seq(nilnul.fs.git.ModuleI module, G git=null)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module,  "remote",git)
				.ToLines_trimmedAndRemoveWhites();
		}


		public  static IEnumerable<string> Seq(nilnul.fs.git.Module module, G git=null)
		{

			return Seq(module as nilnul.fs.git.ModuleI);
		}

		public  static IEnumerable<string> Seq(nilnul.fs.folder_.git_.Top module, G git=null)
		{
			return Seq((nilnul.fs.git.Module)module,  git);
		}



		public static IEnumerable<string> Seq(nilnul.fs.FolderI folderGit, G git=null)
		{
			return Seq(new nilnul.fs.git.Module( folderGit),git);

			//throw new NotImplementedException();
		}

		public static IEnumerable<string> Seq(nilnul.fs.Folder folderGit, G git=null)
		{
			return Seq((FolderI)( folderGit),git);

			//throw new NotImplementedException();
		}
		


		/*
		 git ls-remote --get-url [REMOTE]

		 */

		static public IEnumerable<string> Seq_ofAddress( string workingDir, G git=null)
		{
			return Seq( Module.FroAddress(workingDir) ,git);
		}

		


		static public IEnumerable<string> Seq( DirectoryInfo workingDir, G git=null)
		{
			return Seq( new nilnul.fs.Folder(workingDir) as nilnul.fs.FolderI, git);


		}



		

	}
}

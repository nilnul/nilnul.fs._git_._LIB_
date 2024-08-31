using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.depo.pier
{
	/// <summary>
	/// creatge snap and move branch
	/// </summary>
	static public class _CommitX
	{
		public static void _Vod_0address_1msg(string gitTop, string commitMsg, Git git=null)
		{
			nilnul.os.prog_.git.run_.exit.result._Vow_codOkX.Vow_0address_1argument(
				gitTop
				,
				$@"commit -m""{commitMsg.Replace(@"""", "_")}"""
				,
				git
			);

		}
		public static void Exe(Top gitTop, string commitMsg, Git git)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				gitTop
				,
				$@"commit -m""{commitMsg.Replace(@"""", "_")}"""
				,
				git
			);

		}


		static public void Exe(nilnul.fs.FolderI workingDir, string commitMsg, Git git=null)
		{
			Exe(new Top(workingDir),commitMsg,git );
		}


		public static void Exe(nilnul.fs.Folder gitTop, string commitMsg, nilnul.win.prog_.Git git=null)
		{
			Exe((FolderI)gitTop,commitMsg,git);
		}

		static public void Exe(string workingDir, string commitMsg, Git git=null)
		{
			Exe(nilnul.fs.Folder.FroAddress(workingDir),commitMsg,git);
		}



	}
}

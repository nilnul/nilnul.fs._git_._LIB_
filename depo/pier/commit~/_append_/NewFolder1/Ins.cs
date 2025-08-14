using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.commits
{
	static public class _InsX
	{
		static public void AddAll_Commit(nilnul.win.prog_.Git git, string module, string commitMsg)
		{

			nilnul.fs.git.module.stage._AddX._ExeWholeWork(git, module);



			Exe(git, module, commitMsg);
		}


		static public void AddAll_Commit(nilnul.fs.Folder module, string commitMsg)
		{
			AddAll_Commit(nilnul.win.prog_.Git.StaticInstance, module, commitMsg);
		}

		static public void AddAll_Commit(nilnul.win.prog_.Git git, nilnul.fs.Folder module, string commitMsg)
		{
			nilnul.fs.git.module.stage._AddX._ExeWholeWork(git, module);



			Ins(git, module, commitMsg);
		}

		static public void Ins(nilnul.win.prog_.Git git, nilnul.fs.Folder workingDir, string commitMsg)
		{
			git.runCmd_throwErr(workingDir, $@"commit -m""{commitMsg.Replace(@"""", "_")}""");

		}


		static public void Exe(nilnul.win.prog_.Git git,string workingDir, string commitMsg)
		{
			git.runCmd_throwErr(workingDir, $@"commit -m""{commitMsg.Replace(@"""", "_")}""");

		}

		static public void Exe(nilnul.fs.Folder workingDir, string commitMsg)
		{
			Git.StaticInstance.runCmd_throwErr(workingDir, $@"commit -m""{commitMsg.Replace(@"""", "_")}""");

		}
	}
}

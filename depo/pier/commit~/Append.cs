using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.commits
{
	static public class _AppendX
	{
		
		/// <summary>
		/// append added.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="workingDir"></param>
		/// <param name="commitMsg"></param>
		static public void Append(nilnul.win.prog_.Git git, nilnul.fs.Folder workingDir, string commitMsg)
		{
			git.runCmd_throwErr(workingDir, $@"commit -m""{commitMsg.Replace(@"""", "_")}""");

		}


		static public void Append(nilnul.win.prog_.Git git,string workingDir, string commitMsg)
		{
			git.runCmd_throwErr(workingDir, $@"commit -m""{commitMsg.Replace(@"""", "_")}""");

		}
		static public void Append(string workingDir, string commitMsg)
		{
			Append(nilnul.win.prog_.Git.StaticInstance, workingDir,commitMsg);

		}

		static public void Append(nilnul.fs.Folder workingDir, string commitMsg)
		{
			Git.StaticInstance.runCmd_throwErr(workingDir, $@"commit -m""{commitMsg.Replace(@"""", "_")}""");

		}
	}
}

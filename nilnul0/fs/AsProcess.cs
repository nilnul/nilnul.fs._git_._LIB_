using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.git
{
	public class AsProcess
	{



		public ProcessStartInfo createProcessInfo(string gitDir) {

			ProcessStartInfo gitInfo = new ProcessStartInfo();
			gitInfo.CreateNoWindow = true;
			gitInfo.RedirectStandardError = true;
			gitInfo.RedirectStandardOutput = true;
			gitInfo.FileName = gitDir + @"\bin\git.exe";
			gitInfo.UseShellExecute = false;
			return gitInfo;


		}

		public void startProcess(string gitDir, string gitCmd,string repoPath ){

			var gitInfo = createProcessInfo(gitDir);
			Process gitProcess = new Process();
			gitInfo.Arguments = gitCmd;  // such as "fetch orign"
			gitInfo.WorkingDirectory = repoPath;

			gitProcess.StartInfo = gitInfo;
			gitProcess.Start();

			string stderr_str = gitProcess.StandardError.ReadToEnd();	// pick up STDERR
																		///See this answer to the question How to capture Shell command output in C#? for details on how to capture both standard-error and standard-output generally; this could fail apparently if the output to standard-error is larger than the relevant buffer
			string stdout_str = gitProcess.StandardOutput.ReadToEnd();   // pick up STDOUT

			gitProcess.WaitForExit();
			gitProcess.Close();

		}

	}
}

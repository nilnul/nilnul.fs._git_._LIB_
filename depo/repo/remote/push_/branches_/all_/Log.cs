using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.push_.branches_.all_
{

	
	static public class _LogX
	{
		static public void _Void_ofAddress(string workingDir, string remote, TextWriter log, TextWriter err, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run_._LogX._ExitCode(workingDir, "push --all " + remote, log,err,git);    //all here means all branches.
		}

	
	}
}

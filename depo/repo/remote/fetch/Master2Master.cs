using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.fetch
{
	static public class _Master2MasterX
	{
		/**:* doesn't work for me (fatal: Invalid refspec '*.*'), but refs/heads/*:refs/heads/* does the trick. Thank you!*/
		/// <summary>
		/// git fetch https://github.com/SamSaffron/dapper-dot-net.git master:master

		/// </summary>
		/// <param name="args"></param>
		static public void Master2Master(nilnul.win.prog_.Git git, string workingAddress, string remote)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(workingAddress, $"fetch {remote} master:master");
		}


		static public void Master2Master(nilnul.win.prog_.Git git, nilnul.fs.Folder workingAddress, string remote)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(workingAddress, $"fetch {remote} master:master");
		}


			static public void Master2Master( string workingAddress, string remote)
		{
			Master2Master(nilnul.win.prog_.Git.StaticInstance, workingAddress,remote);
		}
			static public void Master2Master( nilnul.fs.Folder workingAddress, string remote)
		{
			Master2Master(nilnul.win.prog_.Git.StaticInstance, workingAddress,remote);
		}

}
}

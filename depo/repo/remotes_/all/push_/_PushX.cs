using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using nilnul.win.process;

namespace nilnul.fs.git.module.repo.remotes_.all.push_
{
	/// <summary>
	/// anythig such as folder (sub or root), inside workspace root
	/// or  inside ".git" root;
	/// 
	/// given a specified module instance,
	///		the inners of submodule are excluded for they are in another module.
	/// </summary>
	public static class _BranchesAllX
	{
		static public void Void(string workingDir, TextWriter log, TextWriter err, nilnul.win.prog_.Git git=null)
		{
			try
			{
				nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq_ofAddress(workingDir).ForEach(
					(remote) =>
					{
						fs.git.module.repo.remote.push_.branches_.all_._LogX._Void_ofAddress(workingDir, remote, log,err,git);
					}
				);
			}
			catch (Exception e)
			{
				log.WriteLine("Error in push " + workingDir + ": " + e.Message);
			}
			return;
		}

		static public void Push(string workingDir, nilnul.win.prog_.Git git=null)
		{
			try
			{
				nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq_ofAddress(workingDir).ForEach(
					(remote) =>
					{
						try { module.repo.remote.push_.branches_.all_._VoidX.Void_ofAddress(workingDir, remote,git); } catch (Exception e) { }
					}
				);
			}
			catch (Exception)
			{
				throw;
			}
			return;
		}

	}
}
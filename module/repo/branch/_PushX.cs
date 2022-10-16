using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch
{
	static public class _PushX
	{ 
		/*
		 git push origin
Without additional configuration, pushes the current branch to the configured upstream (remote.origin.merge configuration variable) if it has the same name as the current branch, and errors out without pushing otherwise.


The default behavior of this command when no <refspec> is given can be configured by setting the push option of the remote, or the push.default configuration variable.


For example, to default to pushing only the current branch to origin use git config remote.origin.push HEAD. Any valid <refspec> (like the ones in the examples below) can be configured as the default for git push origin.

			 */
		static void PushByRemotes(string[] args)
		{

		}

		static public void Exe(nilnul.fs.git.Module folder, nilnul.fs.git.module._cfg_._remote.Name remote, nilnul.fs.git.module.repo._branch.Name branch, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.Git.RunCmd_retVoid(folder, $"push {remote} {branch}", git);

		}


		static public string Result(nilnul.fs.git.Module folder, nilnul.fs.git.module._cfg_._remote.Name remote, nilnul.fs.git.module.repo._branch.Name branch, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.Git.RunCmd_result(folder, $"push {remote} {branch}",git).ToString();    //all here means all branches.

		}



		static public string Result(nilnul.fs.git.Module folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{
			return Result( (folder),new _cfg_._remote.Name(remote),new _branch.Name(branch), git);
			
		}




		static public void Exe(nilnul.fs.git.Module folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{
			Exe( (folder),new _cfg_._remote.Name(remote),new _branch.Name(branch), git);
			
		}

		

		/*
		 git push origin master
Find a ref that matches master in the source repository (most likely, it would find refs/heads/master), and update the same ref (e.g. refs/heads/master) in origin repository with it. If master did not exist remotely, it would be created.

			 */
		static public void Exe(nilnul.fs.git.Folder folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{

			Exe(  Module1.OfAddress(folder.address.ToString()), new _cfg_._remote.Name(remote), new _branch.Name(branch)
				,git
			);


		}

		static public string Result(nilnul.fs.git.Folder folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{

			return Result(  Module1.OfAddress(folder.address.ToString()), new _cfg_._remote.Name(remote), new _branch.Name(branch)
				,git
			);


		}




		static public string Result(string folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{
			return Result( Module1.OfAddress(folder),new _cfg_._remote.Name(remote),new _branch.Name(branch), git);
			
		}

		static public void Exe(string folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{
			Exe( Module1.OfAddress(folder),new _cfg_._remote.Name(remote),new _branch.Name(branch), git);
			
		}


		


	

	

	}
}

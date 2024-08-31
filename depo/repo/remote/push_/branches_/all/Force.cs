using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.push_.all_
{
	/// <summary>
	/// </summary>
	static public class _ForceX
	{


		static public string Result(nilnul.fs.git.Module workingDir, _cfg_._remote.Name remote, nilnul.win.prog_.Git git = null)
		{
			return nilnul.win.prog_.git.run._ResultX.Result(workingDir, "push --all -f " + remote).ToString();    //all here means all branches.
		}


		static public string Result(string top, string remote, nilnul.win.prog_.Git git=null) {
			return Result( Module.FroAddress(top) ,new _cfg_._remote.Name(remote), git);
		}
		///// <summary>
		///// remote can be a url
		///// </summary>
		///// <param name="git"></param>
		///// <param name="workingDir"></param>
		///// <param name="remote"></param>
		///// <returns></returns>

		//static public string Result(nilnul.fs.folder_.git_.Top workingDir, _cfg_._remote.Name remote,Git git = null)
		//{
		//	return (git??Git.StaticInstance).runCmd__returnResult(workingDir, "push --all -f " + remote).ToString();  //all here means all branches.

		//}

		//static public string Result(nilnul.fs.Folder workingDir, string remote,Git git = null)
		//{
		//	return Result_byForce(new fs.folder_.GitTop(workingDir), new _cfg_._remote.Name(remote),git);  //all here means all branches.

		//}


	

	}
}

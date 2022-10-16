using nilnul.fs.folder_.git_;
using nilnul.fs.git.module.repo._branch;
using nilnul.win.process;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.local.withCurrent
{
	/// <summary>
	/// </summary>
	/// 
	/// 
	static public class _VwX
	{


		static public _branches.CurrentAndRemaining _CurrentAndRemaining(string _module, nilnul.win.prog_.Git git=null)
		{

			///this will returns only local branch.
			///	note: if current branch is just created without any snaps, it's in the "HEAD" file, but not in the "refs/heads/". This doenot list it out. You have to count on <see cref="repo.head_.branch.vw_"/>
			var result = nilnul.win.prog_.git.run.result._MsgX.OfAddress(_module, "branch",git);



			var outputBranches = nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(result);//.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim(new[] {' ', '\t' }) ).Where(x => x != "");

	
			var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));
			var current = repo.head.branch._VwX.Nulable(_module,git);

			return new _branches.CurrentAndRemaining(
				current is null? new nilnul.txt.Opt(): new txt.Opt(current)
				,
				nonDefaultBranch
			);
		}


		static public _branches.CurrentAndRemaining CurrentAndRemaining(nilnul.fs.git.ModuleI workingDir,nilnul.win.prog_.Git git=null)
		{
			return _CurrentAndRemaining(workingDir.top.ToString(), git);
			
		}
		static public _branches.CurrentAndRemaining CurrentAndRemaining(nilnul.fs.git.Module workingDir,nilnul.win.prog_.Git git=null)
		{
			return CurrentAndRemaining((ModuleI)workingDir, git);
			
		}

		static public _branches.CurrentAndRemaining CurrentAndRemaining(Top top, Git git=null)
		{
			return CurrentAndRemaining( new nilnul.fs.git.Module(top),git);
		}


	}
}

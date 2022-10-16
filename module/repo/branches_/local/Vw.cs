using nilnul.fs.folder_.git_;
using nilnul.fs.git.module.repo._branch;
using nilnul.obj.str.be_;
using nilnul.win.process;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.local
{
	/// <summary>
		/// if the branch in head is not instantiated(pointing to any commit), then it's not included here. To include it, <see cref="branches_.local.withCurrent._VwX"/>
	/// </summary>
	/// <remarks>
	///	current branch, if it's uninstantiated (such as new orphan branch), is excluded.
	/// </remarks>
	/// Note:
	/// vs: <see cref="withCurrent._VwX"/>
	/// 
	/// 
	static public class _VwX
	{


		/// <summary>
		/// </summary>
		/// <param name="_module"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public _branches.CurrentAndRemaining _CurrentAndRemaining(string _module, nilnul.win.prog_.Git git=null)
		{

			var result = nilnul.win.prog_.git.run.result._MsgX.OfAddress(_module, "branch",git);



			var outputBranches = nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(result);//.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim(new[] {' ', '\t' }) ).Where(x => x != "");

			var defaultBranch = outputBranches.Where(
				x => x.StartsWith("*")
			).Select(
				y => new nilnul.txt.op_.unary_.TrimStart(
					nilnul.character_.chas_.SpaceTabVtab.Seq.Concat(new[] { '*' })
				).op (y)
			).Where(
				/// when in detached: 
				///		*(HEAD detached at HEAD)
				///			is the first.

				z => z.None(
					c=> new[] { '(', ')', '/',' ' }.Contains(c)
				)
			);


			var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));


			return new _branches.CurrentAndRemaining(
				nilnul.txt.Opt.CreateFroStr(defaultBranch)
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

using nilnul.fs.folder_.git_;
using nilnul.win.process;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.all
{
	/// <summary>
	/// 
	/// </summary>
	static public class _VwX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="workingDir"></param>
		/// <param name="git"></param>
		/// <returns>
		/// for remote branch, eg:
		///		remotes/svr/branch
		/// </returns>
		static public IEnumerable<string> Txts( nilnul.fs.git.ModuleI  workingDir, nilnul.win.prog_.Git git=null)
		{
			
				var result = nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(workingDir, "branch -a",git);


				var outputBranches = nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(result);//.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim(new[] {' ', '\t' }) ).Where(x => x != "");

				var defaultBranch = outputBranches.Select(
					y => new nilnul.txt.op_.unary_.TrimStart(
						nilnul.character_.chas_.SpaceTab.Array.Concat(new[] { '*' })
					).op(y)
				);
				foreach (var item in defaultBranch)
				{
					const string prefix = "remotes/";
					if (item.StartsWith(prefix))
					{
						yield return item.Substring(prefix.Length);
					}

				}
			
		}
		static public IEnumerable<string> Txts(nilnul.fs.git.Module workingDir, nilnul.win.prog_.Git git = null)
		{
			return Txts( (nilnul.fs.git.ModuleI)(workingDir)  , git);
		}

		static public IEnumerable<string> Txts(nilnul.fs.folder_.git_.Top workingDir, nilnul.win.prog_.Git git = null)
		{
			return Txts( new nilnul.fs.git.Module(workingDir) , git);
		}

		public static IEnumerable<string> Txts(nilnul.fs.FolderI top, win.prog_.Git git=null)
		{
			return Txts(new Top(top),git);
		}

		
		static public IEnumerable<string> Txts_ofModuleAddress(string workingDir, win.prog_.Git git=null)
		{

			return Txts(nilnul.fs.Folder.FroAddress(workingDir),git);
		}
		/*
		 git branch -a to view all(local and tracking) branches
		 
		 
		 */
	}
}

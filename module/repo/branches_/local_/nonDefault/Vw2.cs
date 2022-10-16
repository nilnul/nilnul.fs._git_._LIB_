using nilnul.fs.folder_.git_;
using nilnul.win.process;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.local_.nonDefault
{
	static public class _VwX
	{
		static public IEnumerable<string> Txts( nilnul.fs.git.ModuleI  workingDir, nilnul.win.prog_.Git git=null)
		{
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(workingDir, "branch", git)
			).Where(x=>!x.StartsWith("*"));
			//.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim(new[] {' ', '\t' }) ).Where(x => x != "");

				
				
			
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

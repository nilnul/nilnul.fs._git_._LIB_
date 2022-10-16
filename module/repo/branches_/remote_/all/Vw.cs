using nilnul.win.process;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.remote_.all
{
	static public class _VwX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_module"></param>
		/// <param name="git"></param>
		/// <returns>
		/// eg:
		///		svr/branch
		/// </returns>
		static public IEnumerable<string> _Txts(string _module, nilnul.win.prog_.Git git=null)
		{


			return  nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.win.prog_.git.run.result._MsgX.OfAddress(_module, "branch -r")
			);//.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim(new[] {' ', '\t' }) ).Where(x => x != "");

		
			//foreach (var item in outputBranches)
			//{
			//	const string prefix = "remotes/";
			//	if (item.StartsWith(prefix))
			//	{
			//		yield return item.Substring(prefix.Length);
			//	}
			//	else
			//	{
			//		throw new FormatException($"{ item} is not started with {prefix}");
			//	}

			//}

			//return defaultBranch;
			
		}

		static public IEnumerable<string> Txts(nilnul.fs.git.ModuleI workingDir,nilnul.win.prog_.Git git=null)
		{
			return _Txts(workingDir.top.ToString(), git);
			
		}


	}
}

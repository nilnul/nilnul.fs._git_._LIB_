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

namespace nilnul.fs.git.depo.repo.tags
{
	/// 
	static public class _VwX
	{

		/// <summary>
		/// </summary>
		/// <param name="_module"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<string> _Names_0depo(
			string _module, nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.win.prog_.git.run.result._MsgX._Msg_0address(_module, "tag", git)
			);
		} 

		static public IEnumerable<string> Names(nilnul.fs.git.ModuleI workingDir,nilnul.win.prog_.Git git=null)
		{
			return _Names_0depo(workingDir.top.ToString(), git);
			
		}
		static public IEnumerable<string> Names(nilnul.fs.git.Module workingDir,nilnul.win.prog_.Git git=null)
		{
			return Names((ModuleI)workingDir, git);
			
		}

		static public IEnumerable<string> Names(Top top, Git git=null)
		{
			return Names( new nilnul.fs.git.Module(top),git);
		}


	}
}

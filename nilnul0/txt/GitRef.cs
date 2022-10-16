using nilnul.fs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.be_
{
	/// <summary>
	/// git-check-ref-format 
	/// </summary>
	public class GitRef : nilnul.txt.BeI
	{
		private nilnul.win.prog_.Git _git;

		public nilnul.win.prog_.Git git
		{
			get { return _git; }
			set { _git = value; }
		}


		public GitRef(nilnul.win.prog_.Git git)
		{
			_git = git;
		}

		public GitRef():this(nilnul.win.prog_.Git.StaticInstance)
		{

		}
		//git check-ref-format
		public bool be(string obj)
		{
			return  git.runCmd_retErrCode("check-ref-format")!=0;

			//throw new NotImplementedException();
		}
	}
}

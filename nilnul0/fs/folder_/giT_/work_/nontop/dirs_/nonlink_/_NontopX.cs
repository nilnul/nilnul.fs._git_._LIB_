using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.dirs_.nonlink_
{
	/// <summary>
	/// </remarks>
	///
	static public class _NontopX
	{
		static public IEnumerable<DirectoryInfo> _Infos_assumeNontop(
			DirectoryInfo work_nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var child		//not embed repo. cannot be plain. can be bare repo top. can be work (top or nontop). 
				in
				nilnul.fs.folder.dirs_._NonlinkX1.Infos(work_nontop)
				
			)
			{
				

				if (
					nilnul.fs.folder.be_.git_.Repo.Ov(git).be(child)    //bare repo
				)
				{
					continue;
				}

				if (
					nilnul.fs.git.module.dir_.work.be_._NonTopX._BeNonTop_moduleDirAssumeWork(child, git)
				)
				{
					yield return child;
				}
			}
		}

	}
}

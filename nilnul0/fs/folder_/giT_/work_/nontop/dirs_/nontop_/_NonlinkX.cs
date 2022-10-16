using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.dirs_.nontop_
{
	/// <summary>
	/// </remarks>
	///
	static public class _NonlinkX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="work_nontop">work_.nontop</param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<string> Addresses_ofAddress(
			string work_nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var child		//not embed repo. cannot be plain. can be bare repo top. can be work (top or nontop). 
				in
				Directory.EnumerateDirectories(work_nontop))
			{
				if (nilnul.fs.folder.dir.be_._SymlinkX.Be_ofAddress(child) )
				{
					continue;
				}

				if (
					nilnul.fs.folder.be_.git_.Repo.Ov(git).be_ofAddress(child)	//bare repo
				)
				{	
					continue;
				}

				if (
					nilnul.fs.git.module.dir_.work.be_._NonTopX._Be(child, git)
				)
				{
					yield return child;
				}
			}
		}
	}
}

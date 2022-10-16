using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.dirs_.notDotLed_
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
				nilnul.fs.folder.dirs_._NotDotLedX.Infos(work_nontop)
				
			)
			{
				var tgt = nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(
					child.FullName
				);

				if (
					nilnul.fs.folder.be_.git_.Repo.Ov(git).be(tgt.en)   //bare repo
				)
				{
					continue;
				}

				if (
					nilnul.fs.git.module.dir_.work.be_._NonTopX._Be_assumeWork(tgt.en, git)
				)
				{
					yield return child;
				}
			}
		}

		static public IEnumerable<DirectoryInfo> _Infos_assumeNontop(
			string work_nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Infos_assumeNontop(
				new DirectoryInfo(work_nontop)
				,
				git
			);

		}


	}
}

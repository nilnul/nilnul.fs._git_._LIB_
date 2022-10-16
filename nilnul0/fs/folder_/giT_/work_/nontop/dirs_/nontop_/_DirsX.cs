using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.directory
{
	/// <summary>
	/// find those inside the same work.excluding submodule, or bare_repo
	/// pitfall: symlink worktop will be nontop here, but the target is top.
	/// </summary>
	/// <remarks>
	/// returned:
	///		not repo;
	///		not submodule
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.fs.folder_.giT_.work_.nontop.dirs_._NontopX) +  ". Name of this shall be dir_.work_.Nontop to avoid confusion.")]
	static public class _DirsX
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
			return nilnul.fs.folder_.giT_.work_.nontop.dirs_._NontopX._Addresses_addressAssumeNontop(
				work_nontop
				,
				git
			);
			//foreach (
			//	var child		//not embed repo. can be bare repo top. can be work (top or nontop). cannot be plain
			//	in
			//	Directory.EnumerateDirectories(work_nontop))
			//{
			//	var tgt = nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(child);

			//	if (
			//		nilnul.fs.folder.be_.git_.Repo.Ov(git).be(tgt.en)	//bare repo
			//	)
			//	{	
			//		continue;
			//	}

			//	if (
			//		nilnul.fs.git.module.dir_.work.be_._NonTopX._Be_assumeWork(tgt.en, git)
			//	)
			//	{
			//		yield return child;
			//	}
			//}
		}
	}
}

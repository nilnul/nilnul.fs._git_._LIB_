using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.nontop.dirs_
{
	/// <summary>
	/// find those inside the same work.excluding submodule, or bare_repo
	/// </summary>
	/// <remarks>
	/// pitfall: symlink worktop's root is returned by git commmand as the actual path.
	/// returned:
	///		not repo;
	///		not submodule
	/// </remarks>
	///
	static public class _NontopX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="work_nontop">work_.nontop</param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<DirectoryInfo> _Infos_assumeNontop(
			DirectoryInfo work_nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				var child		//not embed repo. cannot be plain. can be bare repo top. can be work (top or nontop). 
				in

				work_nontop.EnumerateDirectories()
			)
			{
				var tgt = nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(
					child.FullName
				);

				if (
					nilnul.fs.folder.be_.git_.Repo.Ov(git).be(tgt.en)	//bare repo
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="work_nontop">work_.nontop</param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<DirectoryInfo> Infos_addressAssumeNontop(
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="work_nontop">work_.nontop</param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<string> _Addresses_addressAssumeNontop(
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
				var tgt = nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(child);

				if (
					nilnul.fs.folder.be_.git_.Repo.Ov(git).be(tgt.en)	//bare repo
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
	}
}
